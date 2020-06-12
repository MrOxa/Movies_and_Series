using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_and_Series
{
    public partial class FormSeriesUpload : Form
    {
        public FormSeriesUpload()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Program.SeriesList.Add(new Series(textBoxName.Text, 
                                              numericUpDownYear.Value.ToString(),
                                              richTextBoxDescription.Text, 
                                              numericUpDownSeason.Value.ToString(), 
                                              numericUpDownEpisode.Value.ToString(), 
                                              textBoxActors.Text.Split(';')));
            Methods.ResetForm(this);
            //MessageBox.Show(typeof(NumericUpDown).ToString());
        }
    }
}
