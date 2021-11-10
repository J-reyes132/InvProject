using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvProject.Forms
{
    public partial class Frm_EditResources : Form
    {
        public int Id;
        public Frm_EditResources()
        {
            InitializeComponent();
        }

        public int getId(int id) 
        {
            Id = id;

            return Id;
        }

        private void Frm_EditResources_Load(object sender, EventArgs e)
        {
            DatabaseLogic DL = new DatabaseLogic();

            DL.DisplayData2Edit("Recursos", Id);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txb_Color.Text = comboBox1.Text;
            DatabaseLogic DL = new DatabaseLogic();
            DL.EditResources(Id,Txb_Articulo.Text, Txb_Modelo.Text, txb_Descripcion.Text, Txb_Color.Text, Txb_serial.Text, Txt_RecibidoPor.Text, Txb_Tipo.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txb_Articulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
