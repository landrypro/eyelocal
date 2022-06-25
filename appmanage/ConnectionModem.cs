using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxSerial;
using System.IO.Ports;


namespace EyeLocal.manageapp
{
    class ConnectionModem : Connectable
    {
       private ComPort port= new ComPort();
        private string stream;

     

        public void setdataPort(ComPort port) { }

        public ComPort getdataPort()  {  return null;    }


        public void sendMessage(string msg) {

            port.WriteString(msg);
                                           
        }


        public string GetMessage()  {
            //port.str
                      
           return port.ReadString();
                }

       // public void Port_Received(object sender, SerialDataReceivedEventArgs e ) {
            
         //   SerialPort sp = (SerialPort)sender;
           // const int bufSize = 12;
           // Byte[] buf = new Byte[bufSize];
           // int msg= sp.Read(buf,0,bufSize)  ;
          //  this.stream = sp.ReadExisting();

         //   MessageBox.Show(this.stream.ToString());
        //}

        public ConnectionModem() {      }
        public int init()
       
        {
            //Initialise Information For AxSerial
            port.Device="COM4";
            port.BaudRate = 9600;
            port.HardwareFlowControl = port.asFLOWCONTROL_DEFAULT;
            port.DataBits = port.asDATABITS_8;
            port.StopBits = port.asSTOPBITS_1;
            port.Parity = port.asPARITY_NONE;

            //For Nativ dll
          // port = new SerialPort("COM8");
          // port.BaudRate = 9600;
          // port.Handshake = Handshake.None;
          // port.DataBits = 8;
          // port.StopBits = StopBits.One;
          // port.Parity = Parity.None;
            
            //Open the Port
            port.Open();

            return 0;
        }


        public int close()
        {
            return 0;
        }
    }
}
