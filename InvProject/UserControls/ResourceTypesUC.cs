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

namespace InvProject.UserControls
{
    public partial class ResourceTypesUC : UserControl
    {
        public ResourceTypesUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void ResourceTypesUC_Load(object sender, EventArgs e)
        {

        }

        private void Dgv_TipoRecursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayData()
        {
            string conn = "server = SIGP-TI01; database = INVPROJECT ; Trusted_Connection=True;";
            //string query = "Select * from Usuarios;";
            SqlConnection connection = new SqlConnection(conn);
            //SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            try
            {
                //sql connection object

                //retrieve the SQL Server instance version
                string query = @"Select * from tipo_Recurso";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, connection);


                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set DataGridView control to read-only


                //set the DataGridView control's data source/data table
                this.Dgv_TipoRecursos.DataSource = ds.Tables[0];


                //close connection
                connection.Close();

            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
 
}
