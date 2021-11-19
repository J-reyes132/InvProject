using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvProject.UserControls
{
    public partial class ReosurceConfigMenu : UserControl
    {
        public ReosurceConfigMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResourceTypesUC RT = new ResourceTypesUC();
            panel1.Controls.Clear();
            RT.Dock = DockStyle.Fill;
            panel1.Controls.Add(RT);

        }
    }
}
