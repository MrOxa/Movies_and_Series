using System;
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
    }
}
