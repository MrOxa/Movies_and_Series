using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO: 1. Make XML reader and writer methods
//      2. Movies button funcionality
//      


namespace Movies_and_Series
{
    public partial class FormMain : Form
    {
        Form activeForm = null;
        public FormMain()
        {
            InitializeComponent();
            panelSeries.Visible = false;
            panelMovie.Visible = false;
        }
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            ChildForm.BringToFront(); //ennek utána jár
            ChildForm.Show();
        }

        private void Button1Movie_Click(object sender, EventArgs e)
        {
            Methods.HideOrShowSubMenu(panelMovie);
        }

        private void SeriesButton_Click(object sender, EventArgs e)
        {
            Methods.HideOrShowSubMenu(panelSeries);
        }

        private void ButtonMoviesList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMoviesAndSeriesList(true,false));
        }

        private void ButtonMoviesUpload_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMovieUpload());
        }

        private void ButtonStaredMovies_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMoviesAndSeriesList(true,true));
        }

        private void ButtonSeriesList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMoviesAndSeriesList(false,false));
        }

        private void ButtonSeriesUpload_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSeriesUpload());
        }

        private void ButtonStaredSeries_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMoviesAndSeriesList(false,true));
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MrOxa/Movies_and_Series");
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MrOxa/Movies_and_Series");
        }
    }
}
