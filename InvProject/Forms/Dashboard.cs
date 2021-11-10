using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvProject
{
   
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Home_moveUp(object sender, MouseEventArgs e)
        {

        }

        private void Home_Mousemove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;

            else
                this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fileSystemWatcher2_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Dashboard Ds = new Dashboard();
            Ds.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Ds);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //open Resources User Control
            MainPanel.Controls.Clear();
            ResourcesUC Rs = new ResourcesUC();
            Rs.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Rs);

            //Load DataGrid with control user
            
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void OpenAddResourceUC() 
        {
            //open Resources User Control
            
            MainPanel.Controls.Clear();
            UserControls.AddResources As = new UserControls.AddResources();
            As.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(As);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            UserControls.AsignacionesUC AR = new UserControls.AsignacionesUC();
            AR.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(AR);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dashboard Ds = new Dashboard();
            Ds.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Ds);
        }
    }
}
