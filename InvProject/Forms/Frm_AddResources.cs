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
    public partial class Frm_AddResources : Form
    {
        public Frm_AddResources()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResourcesUC Rc = new ResourcesUC();
            DatabaseLogic DL = new DatabaseLogic();
            string result = DL.Addresource(Txb_Articulo.Text, Txb_Modelo.Text, txb_Descripcion.Text, Txb_Color.Text, Txb_serial.Text, Txt_RecibidoPor.Text, Txb_Tipo.Text);

            if (result == "ok")
            {
                MessageBox.Show("Recurso agredado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
               
                
                
            }
            else
            {
                MessageBox.Show("No se pudo agregar un recurso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txb_Descripcion.Text = "";
            Txb_Articulo.Text = "";
            Txb_Color.Text = "";
            Txb_Modelo.Text = "";
            Txb_serial.Text = "";
            Txb_Tipo.Text = "";
            Txt_RecibidoPor.Text = "";
        }
    }
}
