using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;



namespace EyeLocal.manageapp
{
    class ConnectionDB : Connectable
    {
        string connectionString;
        //NpgsqlConnection connection;
        OdbcConnection connection;
        //OleDbConnection connection;
                

        //Methods
        public ConnectionDB() {
       
            
            this.connectionString = " Driver={PostgreSQL ANSI}; Server=127.0.0.1; Port=5432; Database=EyeLocalDB; Uid=postgres; Pwd=fotisarl;";
            

          }
         //Overriding
        public int connect() 
        {
            try
            {
            //connection = new NpgsqlConnection();

            connection = new OdbcConnection(this.connectionString);
            //connection = new OleDbConnection(this.connectionString);
            connection.Open();
            
            return 0;
            }
            catch (Exception e)
            {

                
                MessageBox.Show(e.Message);
         
                return 1;
            }
       // return 1;
                 //Console.WriteLine("Data does not exist");
             //dr.Close();
            //return 0;
        }

        public int close() {
            connection.Close();
            return 0; 
        }
         //setter
        public void setConnectionString(string cs) { this.connectionString = cs; }
         //getters
        public string getConnectionstring() { return this.connectionString; }
        public OdbcConnection getConnection() { return this.connection; }
        //public NpgsqlTransaction getTransaction() { return this.transaction; }
        //public OleDbConnection getConnection() { return this.connection; }
           }
}
