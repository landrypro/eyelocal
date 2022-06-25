using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeLocal.coremonitor
{
    class Server
    {
        string name;
        string comPort;
        

        //Contructor
        public Server() { }
        public Server(string nm, string com) { this.name = nm; this.comPort = com; }

        //Getter 
        public string getName() { return this.name; }
        public string getCOM() { return this.comPort; }

        //Setter
        public void setName(string nm) { this.name = nm; }
        public void setCOM(string com) { this.comPort=com ; }

        //Methods
        public void openPort() { }
        public void close() { }

        public string getInfo() { return " "; }
        public int getState() { return 0; }



    }

}
