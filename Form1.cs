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
    public partial class Form1 : Form
    {
        Form activeForm = null;
        public Form1()
        {
            InitializeComponent();
            panelSeries.Visible = false;
            panel1Movie.Visible = false;
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
            Methods.HideOrShowSubMenu(panel1Movie);
        }

        private void SeriesButton_Click(object sender, EventArgs e)
        {
            Methods.HideOrShowSubMenu(panelSeries);
        }
    }
}
