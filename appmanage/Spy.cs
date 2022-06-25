using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeLocal.manageapp
{
    class Spy
    {
        //Attributes
        int id;
        string username;
        string task;
        string date;
        string time;

        //Constructor 
        public Spy() { }

        public Spy(int id, string un, string ts, string date,string time)
        {
            this.id = id;
            this.username = un;
            this.task = ts;
        }


        //Setter
        public void setID(int id){   this.id = id;   }
        public void setUsername(string cs){      this.username = cs;  }
        public void setTask(string tsk) { this.task = tsk; }

        public void setDate(string dte)
        {
            // this.date=;

        }

        //Getter
        //..
        public int getID() { return this.id; }
        public string getusername() { return this.username; }
        public string gettask() { return this.task; }
        public string getdate() { return this.date; }
        public string gettime() { return this.time; }



        //Specifics Methodes



    }
}
