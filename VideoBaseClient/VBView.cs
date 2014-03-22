using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.VideoBaseDataSetTableAdapters;

namespace VideoBaseClient
{
    public partial class VBView : Form
    {
        public VBView()
        {
            InitializeComponent();
        }

        private void toolsSaveButton_Click(object sender, EventArgs e)
        {
            
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
    }
}
