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
            findFilms();
            _changed = false;
        }

        private void findFilms()
        {
            string findName = "%" + filmTitle.Text + "%";
            dTFilmsOfGenreTableAdapter.FillByName(videoBaseDataSet.DTFilmsOfGenre, _genreId, _genreName);
        }
    }
}
