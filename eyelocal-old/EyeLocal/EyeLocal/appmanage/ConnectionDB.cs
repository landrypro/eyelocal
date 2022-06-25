using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EyeLocal.manageapp
{
    class ConnectionDB : Connectable
    {
        string connectionString;


        //Methods
        public ConnectionDB() { }

        //Overriding
        public int connect() 
        {
            return 0;
        }
        public int close() { return 0; }

        //setter
        public void setConnectionString(string cs) { this.connectionString = cs; }
        //getters
        public string getConnectionstring() { return this.connectionString; }


    }
}
