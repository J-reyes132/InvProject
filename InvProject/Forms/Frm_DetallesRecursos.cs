using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InvProject.Forms
{
    public partial class Frm_DetallesRecursos : Form
    {
        public Frm_DetallesRecursos()
        {
            InitializeComponent();
        }

        public string Table { get; set; }
        public int Id { get; set; }
        private void Frm_DetallesRecursos_Load(object sender, EventArgs e)
        {

            DisplayData2Edit(Id);
        
        }
        public void DisplayData2Edit(int Id)
        {
            string conn = "server = SIGP-TI01; database = INVPROJECT ; Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(conn);

            string query;

                    //Forms.Frm_DetallesRecursos DR = new Forms.Frm_DetallesRecursos();

                    query = "select * from recursos";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader Reader = cmd.ExecuteReader();



                    while (Reader.Read())
                    {
                        
                        Txb_Id.Text = Reader[0].ToString();
                        Txb_Articulo.Text = Reader[1].ToString();
                        Txb_Modelo.Text = Reader[2].ToString();
                        Txb_Descripcion.Text = Reader[3].ToString();
                        Txb_Color.Text = Reader[4].ToString();
                        Txb_Serial.Text = Reader[5].ToString();
                        Txb_Recibido_Por.Text = Reader[6].ToString();
                        Txb_Tipo.Text = Reader[7].ToString();
                    }
                    
            
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (Txb_Articulo.ReadOnly == true)
            {
                Txb_Articulo.ReadOnly = false;
                Txb_Modelo.ReadOnly = false;
                Txb_Descripcion.ReadOnly = false;
                Txb_Color.ReadOnly = false;
                Txb_Serial.ReadOnly = false;
                //Txb_Recibido_Por.ReadOnly = false;
                Txb_Tipo.ReadOnly = false;
            }
            else
            {
                Txb_Articulo.ReadOnly = true;
                Txb_Modelo.ReadOnly = true;
                Txb_Descripcion.ReadOnly = true;
                Txb_Color.ReadOnly = true;
                Txb_Serial.ReadOnly = true;
                //Txb_Recibido_Por.ReadOnly = true;
                Txb_Tipo.ReadOnly = true;
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            DatabaseLogic DL = new DatabaseLogic();
            string result = DL.EditResources(Convert.ToInt32(Txb_Id.Text),Txb_Articulo.Text,Txb_Modelo.Text, Txb_Descripcion.Text, Txb_Color.Text, Txb_Serial.Text, Txb_Recibido_Por.Text, Txb_Tipo.Text);
            MessageBox.Show(result);
            this.Hide();
        }
    }
}
