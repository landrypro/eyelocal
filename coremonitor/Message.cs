using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeLocal.coremonitor
{
    class Message   //Abstract Class
    {
        //Properties
        public string content;

        //Methods and Constructors
        public Message() { }

        //Methodes
        public void setContent(string msg)
        {
            this.content = msg;
        }
        public string getContent()
        {
            return this.content;
        }

    }
}
 