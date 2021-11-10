﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace InvProject
{
    class DatabaseLogic
    {
        public string conn, result, query;
        SqlConnection connection;
        public void connect()
        {
            conn = "server = SIGP-TI01; database = INVPROJECT ; Trusted_Connection=True;";
            //string query = "Select * from Usuarios;";
            connection = new SqlConnection(conn);
            //SqlCommand cmd = new SqlCommand(query, connection);


        }

        public string login(string _User, string _Password)
        {



            query = @"select Usuario, password from usuarios where Usuario= @User and password = @password";
            connect();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@User", _User);
            cmd.Parameters.AddWithValue("@password", _Password);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            connection.Close();

            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                result = "ok";
            }
            else
            {
                result = "Usuario o Contraseña incorrecto";
            }

            return result;
        }

        public string Addresource(string _articulo, string _modelo, string _descripcion, string _color, string _serial, string _recibidoPor, string _tipo)
        {
            query = @"Select Serial from Recursos where Serial= @Serial";
            connect();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@serial", _serial);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            connection.Close();

            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Ya existe un recurso con el serial introducido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = "Error";
            }
            else
            {
                query = @"insert into Recursos values (@articulo, @modelo, @descripcion, @color, @serial, @recibidoPor, @tipo)";
                connection.Open();

                cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@articulo", _articulo);
                cmd.Parameters.AddWithValue("@modelo", _modelo);
                cmd.Parameters.AddWithValue("@descripcion", _descripcion);
                cmd.Parameters.AddWithValue("@color", _color);
                cmd.Parameters.AddWithValue("@serial", _serial);
                cmd.Parameters.AddWithValue("@recibidoPor", _recibidoPor);
                cmd.Parameters.AddWithValue("@tipo", _tipo);
                cmd.CommandType = CommandType.Text;

                i = cmd.ExecuteNonQuery();
                connection.Close();

                if (i > 0)
                {
                    result = "ok";
                }
                else
                {
                    result = "Error";
                }
            }
            ResourcesUC rc = new ResourcesUC();

            return result;
        }

        public string EditResources(int id, string _articulo, string _modelo, string _descripcion, string _color, string _serial, string _recibidoPor, string _tipo) 
        {
            string result;
            query = "Update Recursos set articulo= @articulo, modelo= @modelo,descripcion= @descripcion,  color=@color, serial= @serial, recibido_Por= @recibidoPor, tipo = @tipo where id= @id";

            connect();
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("@articulo", _articulo);
            cmd.Parameters.AddWithValue("@modelo", _modelo);
            cmd.Parameters.AddWithValue("@descripcion", _descripcion);
            cmd.Parameters.AddWithValue("@color", _color);
            cmd.Parameters.AddWithValue("@serial", _serial);
            cmd.Parameters.AddWithValue("@recibidoPor", _recibidoPor);
            cmd.Parameters.AddWithValue("@tipo", _tipo);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
        

            if (i > 0)
            {
                result = "Recurso actualizado";
            }
            else 
            {
                result = "Error";
            }

            return result;
        }

        public string DeleteRow(string _table, int _id)
        {
            string tabla = _table;
            connect();
            query = "delete from "+tabla+" where ID=@ID";
            
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", _id);
            
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();

            result = "ok";


            return result;
        }


        public void DisplayData2Edit(string table, int Id) 
        {
            string query;

            connect();
           

            switch (table) 
            {
                case "Recursos":

                    Forms.Frm_EditResources edit_Resources = new Forms.Frm_EditResources();

                    query = "select * from recursos";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    
                    connection.Open();
                    SqlDataReader Reader = cmd.ExecuteReader();

                    

                    if(Reader.Read())
                    {
                        edit_Resources.Txb_Articulo.Text = Reader.GetValue(0).ToString();
                        edit_Resources.Txb_Modelo.Text = Reader.GetValue(1).ToString();
                        edit_Resources.txb_Descripcion.Text = Reader.GetValue(2).ToString();
                        edit_Resources.comboBox1.Text = Reader.GetValue(3).ToString();
                        edit_Resources.Txb_serial.Text = Reader.GetValue(4).ToString();
                        edit_Resources.Txt_RecibidoPor.Text = Reader.GetValue(5).ToString();
                        edit_Resources.Txb_Tipo.Text = Reader.GetValue(6).ToString();
                    }
                    break;
            }
        }
        public void DisplayData()
        {
            ResourcesUC rc = new ResourcesUC();

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
                rc.dgv_Resources.DataSource = ds.Tables[0];


                //close connection
                connection.Close();
            }
              
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
}

    } }

