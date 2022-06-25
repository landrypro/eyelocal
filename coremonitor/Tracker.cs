using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeLocal.coremonitor
{
    class Tracker
    {
        string imei;
        int sim;
        string carrier;
        string manufacturer;

        //Constructor
        public Tracker() { }
        public Tracker(string im, int sm, string cr, string man)
        {
            this.imei = im;
            this.sim = sm;
            this.carrier = cr;
            this.manufacturer = man;

        }

        //Getter

        public string getimei() { return this.imei; }
        public int getdate() { return this.sim; }
        public string getcarrier() { return this.carrier; }
        public string getmanufacturer() { return this.manufacturer; }

        //Setter
        public void setimei(string im) { this.imei = im; }
        public void setsim(int sm) { this.sim = sm; }
        public void setcarrier(string cr) { this.carrier = cr; }
        public void setmanufacturer(string man) { this.manufacturer = man; }

        //Methods
        public void sendMessage(MessageBrut msg)
        {

        }
        public void receiveMessage()
        {

        }




    }
}
