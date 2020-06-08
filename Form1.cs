using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO: 1. Movies button events
//      2. Series buttons events
//      3. help button
//      4. about button
//      5. Make form for the button events

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

        private void button1Movie_Click(object sender, EventArgs e)
        {
            Methods.HideOrShowSubMenu(panelMovie);
        }

        private void SeriesButton_Click(object sender, EventArgs e)
        {
            Methods.HideOrShowSubMenu(panelSeries);
        }

        private void buttonMoviesList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMoviesAndSeriesList());
        }

        private void buttonMoviesUpload_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMovieUpload());
        }

        private void buttonStaredMovies_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMoviesAndSeriesList());
        }

        private void buttonSeriesList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMoviesAndSeriesList());
        }

        private void buttonSeriesUpload_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSeriesUpload());
        }

        private void buttonStaredSeries_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMoviesAndSeriesList());
        }
    }
}
