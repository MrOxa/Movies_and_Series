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
    public partial class FormMovieUpload : Form
    {
        public FormMovieUpload()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Program.MoviesList.Add(new Movie(textBoxName.Text, 
                                            numericUpDownYear.Value.ToString(), 
                                            richTextBoxDescripton.Text, 
                                            textBoxActors.Text.Split(',')));
            Methods.ResetForm(this);
        }
    }
}
