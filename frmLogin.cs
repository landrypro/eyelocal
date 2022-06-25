using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeLocal.manageapp;
using Npgsql;

namespace EyeLocal
{
    public partial class frmLogin : Form
    {

        ConnectionDB connDB;
        //public NpgsqlDataAdapter dataAdapter;
        //public OdbcDataAdapter dataAdapter;
        
        //OleDbDataAdapter dataAdapter;
        DataSet dataset;
        public  DataTable datatable;
        
        public frmLogin()
        {
            InitializeComponent();

        }
                private void txtPwd_TextChanged(object sender, EventArgs e) { }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eyeLocalDBDataSet.User_App' table. You can move, or remove it, as needed.
            try
            { 
            
              connDB = new ConnectionDB();
              connDB.connect();
              string query = "SELECT  \"Name\" FROM \"public\".\"User_App\"";

              OdbcCommand cmd = new OdbcCommand(query, connDB.getConnection());
              OdbcDataAdapter dataAdapter = new OdbcDataAdapter(cmd);

              dataAdapter.SelectCommand=cmd;
              datatable = new DataTable();
              dataAdapter.Fill(datatable);
              //dataset = new DataSet();
                             
              cbxUser.DataSource =  datatable;
              cbxUser.DisplayMember = "Name";
              cbxUser.ValueMember = "Name";
                             
          }
                         
                 
           catch (Exception err) {  MessageBox.Show(err.Message);     }   
                      
           }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
            connDB.close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


           // OdbcCommand cmd = new OdbcCommand("SELECT * from login where name =" + cbxUser + "and password =" + txtPwd + "", connection);
            //NpgsqlDataReader dr = cmd.ExecuteReader();
            /*   if (dr.Read())
               {
                   blnfound = true;
                   EyeLocal Eye = new EyeLocal();
                   Eye.Show();
                   this.Hide();
               }
               if (blnfound == false) ;
               MessageBox.Show("username or password is not correct!!!");
               dr.Close();
               connection.Close();

          */
            //this.Close();
            (new frmEyeLocal()).Show();


        }

        private void lblPwd_Click(object sender, EventArgs e)   { }

        private void lblUser_Click(object sender, EventArgs e)  { }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e){ }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Application.Exit();
        }


    }

}




