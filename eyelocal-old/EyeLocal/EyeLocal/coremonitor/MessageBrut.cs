using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeLocal.coremonitor
{
    class MessageBrut : Message
    {
        //Constructors
        public MessageBrut() { }
        public MessageBrut(string msg) { this.content = msg; }

        //Methodes
        public string getMessage() { return this.content; }
    }
}
