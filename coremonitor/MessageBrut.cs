using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EyeLocal.coremonitor
{
    class MessageBrut : Message
    {
        string content ;

        //Constructors
        //public MessageBrut(string msg ) {   this.content=msg;}


        public MessageBrut() {

            string info = "";

            info = "lat:4.055555 lon:9.697097";
            info += "\n";
            info += "speed:0.00";
            info += "\n";
            info += "T:15/09/02 19:05";
            info += "\n";
            info += "http://maps.google.com/maps?f=q&q=4.055555,9.697097&z=16";
            info += "\n";
            info += "Pwr: ON Door: OFF ACC: OFF";

            this.content = info;
        }
            
             
              //Methodes
        public string getContent() { return this.content; }

        public void setMessage(string msg) { this.content = msg;    }


        //Analyzer et builder of Tracking Info

        //public Tracking AnalyzerMessage()

        public Position AnalyzerMessage()

        {

            float l = 0;
            float lg = 0;
            string dtime = "";
            string url = "";


           // try
           // {
            
            char[] delim = { '\n',' '};
                       
            //To remove carrier return and space in message brut form Tracker
            string[] infoTrack = this.content.Split(delim);

            //To extract  latitude
            string lat = infoTrack[0];

            //char[] sLat={'l','a','t',':'};
            //lat.TrimStart(sLat);
             lat = lat.Substring(4);

            //To extract longitude
            string lng = infoTrack[1];

            //char[] sLng={'l','0','n',':'};
            //lng.TrimStart(sLng);
            lng = lng.Substring(4);


            //To Extract datetime 

            dtime= infoTrack[4];

            //To extract URL
            url = infoTrack[5];

            string stl = lat;
            string stlg = lng;



            l = float.Parse(stl, System.Globalization.CultureInfo.InvariantCulture);
            lg = float.Parse(stlg, System.Globalization.CultureInfo.InvariantCulture);

           // }
           // catch (Exception e ) {

            //    System.Console.WriteLine(e.ToString());
            
          //  }


            return new Position(l, lg, dtime, url);

            //msg="lat:4.055555 lon:9.697097";
            // msg+="\r\n";
             //msg+="speed:0.00";
             //msg+="\r\n";
             //msg+="T:15/09/02 19:05";
             //msg+="\r\n";
             //msg+= "http://maps.google.com/maps?f=q&q=4.055555,9.697097&z=16";
             //msg+="\r\n";
             //msg += "Pwr: ON Door: OFF ACC: OFF";
              //return new Tracking();

        }


    }
}
