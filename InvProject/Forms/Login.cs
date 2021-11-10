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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

     

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = Txb_user.Text;
            string pass = Txb_Password.Text;
            string result;
            DatabaseLogic DL = new DatabaseLogic();
            result = DL.login(user, pass);

            if (result == "ok")
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
            else 
            {
                MessageBox.Show(result,"Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
