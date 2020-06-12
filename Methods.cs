using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO   1.

namespace Movies_and_Series
{
    public static class Methods
    {
        public static void HideOrShowSubMenu(Panel panel)
        {
            if (panel.Visible == false)
                panel.Visible = true;
            else panel.Visible = false;
        }
        public static void ResetForm(Form inputForm)
        {
            foreach (var item in inputForm.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox temp = (TextBox)item;
                    temp.Text = "";
                }
                else if (item.GetType() == typeof(RichTextBox))
                {
                    RichTextBox temp = (RichTextBox)item;
                    temp.Text = "";
                }
                else if (item.GetType() == typeof(NumericUpDown))
                {
                    NumericUpDown temp = (NumericUpDown)item;
                    temp.Value = 0;
                }
            }
        }
        public static void ShowDatagridView(DataGridView dataGrid, List<Movie> inputData)
        {
            dataGrid.Columns.Add("Name", "Name");
            dataGrid.Columns.Add("Year", "Year");
            dataGrid.Columns.Add("Actors", "Actors");
            dataGrid.Columns.Add("Description", "Description");

            for (int i = 0; i < inputData.Count; i++)
            {
                string tempActors = inputData[i].ConcatingActors();
                dataGrid.Rows.Add(inputData[i].Name, inputData[i].Year, tempActors, inputData[i].Description);
            }
        }
        public static void ShowDiagramView(DataGridView dataGrid, List<Series> inputData)
        {

            dataGrid.Columns.Add("Name", "Name");
            dataGrid.Columns.Add("Year", "Year");
            dataGrid.Columns.Add("Actors", "Actors");
            dataGrid.Columns.Add("Season", "Season");
            dataGrid.Columns.Add("Episode", "Episode");
            dataGrid.Columns.Add("Description", "Description");

            for (int i = 0; i < inputData.Count; i++)
            {
                string tempActors = inputData[i].ConcatingActors();
                dataGrid.Rows.Add(inputData[i].Name, inputData[i].Year, tempActors, inputData[i].Description);
            }
        }
    }
}
