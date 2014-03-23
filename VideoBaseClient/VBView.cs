using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoBaseClient.VideoBaseDataSetTableAdapters;

namespace VideoBaseClient
{
    public partial class VBView : Form
    {
        private bool _changed;

        public VBView()
        {
            InitializeComponent();
            _changed = false;
        }

        private void toolsSaveButton_Click(object sender, EventArgs e)
        {
            fILMTableAdapter.Update(videoBaseDataSet.FILM);
            dIC_GENRETableAdapter.Update(videoBaseDataSet.DIC_GENRE);
            dIC_COUNTRYTableAdapter.Update(videoBaseDataSet.DIC_COUNTRY);
            dIC_CHARACTERTableAdapter.Update(videoBaseDataSet.DIC_CHARACTER);
            dIC_DIRECTORTableAdapter.Update(videoBaseDataSet.DIC_DIRECTOR);
            _changed = false;
        }

        private void VBView_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "videoBaseDataSet.DIC_COUNTRY". При необходимости она может быть перемещена или удалена.
            this.dIC_COUNTRYTableAdapter.Fill(this.videoBaseDataSet.DIC_COUNTRY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "videoBaseDataSet.DIC_DIRECTOR". При необходимости она может быть перемещена или удалена.
            this.dIC_DIRECTORTableAdapter.Fill(this.videoBaseDataSet.DIC_DIRECTOR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "videoBaseDataSet.DIC_CHARACTER". При необходимости она может быть перемещена или удалена.
            this.dIC_CHARACTERTableAdapter.Fill(this.videoBaseDataSet.DIC_CHARACTER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "videoBaseDataSet.DIC_GENRE". При необходимости она может быть перемещена или удалена.
            this.dIC_GENRETableAdapter.Fill(this.videoBaseDataSet.DIC_GENRE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "videoBaseDataSet.FILM". При необходимости она может быть перемещена или удалена.
            this.fILMTableAdapter.Fill(this.videoBaseDataSet.FILM);

        }

        private void removeFilmButton_Click(object sender, EventArgs e)
        {
            fILMBindingSource.RemoveCurrent();
        }

        private void removeGenreButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int) genresView.CurrentRow.Cells["dGIDDataGridViewTextBoxColumn"].Value;
                int? genresCount = new QueriesTableAdapter().SQCountDG_IDInFILM_DIC_GENRE(id);
                if (genresCount == 0)
                    dICGENREBindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Видалення неможливе! До жанру прив'язані фільми!", "Помилка видалення жанру");
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення жанру", "Помилка видалення жанру");
            }
        }

        private void removeActorButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)actorsView.CurrentRow.Cells["dCRIDDataGridViewTextBoxColumn"].Value;
                int? actorsCount = new QueriesTableAdapter().SQCountDCR_IDInFILM_DIC_CHARACTER(id);
                if (actorsCount == 0)
                    dICCHARACTERBindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Видалення неможливе! До актора прив'язані фільми!", "Помилка видалення актора");
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення актора", "Помилка видалення актора");
            }
        }

        private void removeDirectorButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)directorsView.CurrentRow.Cells["dDIDDataGridViewTextBoxColumn"].Value;
                int? directorsCount = new QueriesTableAdapter().SQCountDD_IDInFILM_DIC_DIRECTOR(id);
                if (directorsCount == 0)
                    dICDIRECTORBindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Видалення неможливе! До режисера прив'язані фільми!", "Помилка видалення режисера");
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення режисера", "Помилка видалення режисера");
            }
        }

        private void removeCountryButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)countriesView.CurrentRow.Cells["dCIDDataGridViewTextBoxColumn"].Value;
                int? countriesCount = new QueriesTableAdapter().SQCountDC_IDInFILM_DIC_COUNTRY(id);
                if (countriesCount == 0)
                    dICDIRECTORBindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Видалення неможливе! До країни прив'язані фільми!", "Помилка видалення країни");
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення країни", "Помилка видалення країни");
            }
            
            dICCOUNTRYBindingSource.RemoveCurrent();
        }

        private void genresView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_changed)
            {
                MessageBox.Show("Необхідно зберегти зміни!", "Перегляд фільмів за жанром");
            }
            else
            {
                try
                {
                    int id = (int) genresView.CurrentRow.Cells["dGIDDataGridViewTextBoxColumn"].Value;
                    string name = (string) genresView.CurrentRow.Cells["dGNAMEDataGridViewTextBoxColumn"].Value;
                    FilmsView filmsDialogView = new FilmsView(id, name);
                    filmsDialogView.ShowDialog(this);
                    filmsDialogView.Dispose();
                }
                catch
                {
                    MessageBox.Show("Помилка переходу до списку фільмів", "Перехід до списку фільмів");
                }
            }
        }

        private void filmsView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _changed = true;
        }

        private void genresView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _changed = true;
        }

        private void actorsView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _changed = true;
        }

        private void directorsView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _changed = true;
        }

        private void countriesView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _changed = true;
        }
    }
}
