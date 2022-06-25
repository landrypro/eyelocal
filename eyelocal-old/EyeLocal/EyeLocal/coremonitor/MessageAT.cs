using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeLocal.coremonitor
{
    class MessageAT: Message
    {
        //Constructor
        public MessageAT() { }
        public MessageAT(string msgAT) { this.content = msgAT; }

        //Methodes
        public string getMessage(){ return this.content;}
    }
}
