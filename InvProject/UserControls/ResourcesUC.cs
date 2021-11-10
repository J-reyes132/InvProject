using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace InvProject
{
    public partial class ResourcesUC : UserControl
    {
        int id;
        public ResourcesUC()
        {
           
            InitializeComponent();
            DisplayData();
         
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_AddResources AR = new Frm_AddResources();
            AR.Show();
            DisplayData();

        }

   
        private void sfDataGrid1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Forms.Frm_EditResources edt = new Forms.Frm_EditResources();
            edt.Show();
            id = Convert.ToInt32(dgv_Resources.CurrentRow.Cells[0].Value.ToString());
            int result = edt.getId(id);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBox1.CheckState == CheckState.Checked)
            {
                dgv_Resources.ReadOnly = false;
                dgv_Resources.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                dgv_Resources.ReadOnly = true;
            }*/

            

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DatabaseLogic DL = new DatabaseLogic();
            int id = Convert.ToInt32(dgv_Resources.CurrentRow.Cells[0].Value.ToString());
            string result = DL.DeleteRow("recursos",id);

            DisplayData();
            
        }

          public void DisplayData() 
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
                string query = @"SELECT * from Recursos";

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
                this.dgv_Resources.DataSource = ds.Tables[0];


                //close connection
                connection.Close();

            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            DisplayData();
        }
    }   
   
}
     
    
