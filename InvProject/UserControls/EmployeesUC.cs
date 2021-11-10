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
    public partial class EmployeesUC : UserControl
    {
        public EmployeesUC()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                dgv_Employees.ReadOnly = false;
                dgv_Employees.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                dgv_Employees.ReadOnly = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                checkBox1.CheckState = CheckState.Unchecked;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                checkBox1.CheckState = CheckState.Checked;
            }
        }

        private void dgv_Employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DatabaseLogic DL = new DatabaseLogic();
            int id = Convert.ToInt32(dgv_Employees.CurrentRow.Cells[0].Value.ToString());
            string result = DL.DeleteRow("Empleados", id);

            DisplayData();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DisplayData();
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
                string query = @"SELECT * from Empleados";

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
                this.dgv_Employees.DataSource = ds.Tables[0];


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
