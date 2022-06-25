using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeLocal.manageapp
{
    class Communication
    {

        //Attributes
        int id;
        string imei;
        string server;
        string message;


        //Constructions
         public Communication(){ }
        public Communication(int idt,string im, string sv, string me)
        {
            this. id = idt; 
            this.imei = im;
            this.server = sv;
            this.message = me;
        }
            


        //Getters
        public int getid() { return this.id; }
        public string getimei() { return this.imei; }
        public string getserver() { return this.server; }
        public string getserver() { return this.server; }


        //Setters
        public void setid(int idt) { this.id = idt; }
        public void setimei(string im) { this.imei = im; }
        public void setserver(string sv) { this.server = sv; }
        public void setmessage(string me) { this.message = me; }


    }
}
