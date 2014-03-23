using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoBaseClient
{
    public partial class FilmsView : Form
    {
        private bool _changed;
        private int _genreId;
        private string _genreName;

        public FilmsView(int genreId, string genreName)
        {
            InitializeComponent();
            Text = string.Concat(Text, " ", genreName);
            _genreId = genreId;
            _genreName = genreName;
            dTFilmsOfGenreTableAdapter.Fill(videoBaseDataSet.DTFilmsOfGenre, genreId);
            _changed = false;
        }

        private void findFilms()
        {
            string filmTitle = "%" + tbFilmTitle.Text + "%";
            string actorName = "%" + tbActorName.Text + "%";
            string directorName = "%" + tbDirectorName.Text + "%";
            dTFilmsOfGenreTableAdapter.FillByFilmTitleActorDirector(
                videoBaseDataSet.DTFilmsOfGenre,
                _genreId,
                filmTitle,
                actorName,
                directorName);
        }

        private void toolStripSearch_Click(object sender, EventArgs e)
        {
            findFilms();
        }

        private void filmView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                id = (int) filmView.CurrentRow.Cells["fMIDDataGridViewTextBoxColumn"].Value;
                dTCharactersOfFilmTableAdapter.Fill(videoBaseDataSet.DTCharactersOfFilm, id);
            }
            catch
            {
                MessageBox.Show("Помилка виведення списку акторів!", "Помилка");
            }
        }
    }
}
