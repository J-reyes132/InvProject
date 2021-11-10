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
    public partial class AddResources : UserControl
    {
        public AddResources()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Txb_Tipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_RecibidoPor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txb_serial_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txb_Color_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txb_Modelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txb_Articulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
