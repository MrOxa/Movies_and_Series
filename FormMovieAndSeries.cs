using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_and_Series
{
    public partial class FormMoviesAndSeriesList : Form
    {
        public FormMoviesAndSeriesList(bool isMovie, bool Stared)
        {
            InitializeComponent();
            if (isMovie == true && Stared == false)
            {
                Methods.ShowDatagridView(dataGridView1, Program.MoviesList);
            }
            else if (isMovie == false && Stared == false)
            {
                Methods.ShowDiagramView(dataGridView1, Program.SeriesList);
            }
        }
    }
}
