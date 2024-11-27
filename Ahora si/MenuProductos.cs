using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar;

namespace Ahora_si
{
    public partial class MenuProductos : Form
    {
        bool sidebarExpand = true;
        public MenuProductos()
        {
            InitializeComponent();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) // Si está expandida, contraer
            {
                panelSidebar.Width -= 10;
                if (panelSidebar.Width <= 0)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else // Si está contraída, expandir
            {
                panelSidebar.Width += 10;
                if (panelSidebar.Width >= 160)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
