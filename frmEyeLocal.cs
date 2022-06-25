using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap;

using EyeLocal.manageapp;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GMap.NET.MapProviders;

using System.Data.Odbc;
using EyeLocal.coremonitor;

namespace EyeLocal
{
   
    
 
    public partial class frmEyeLocal : Form
    {

        ConnectionModem conMod;
        ConnectionDB conDB;
        OdbcDataAdapter dataAdapter;
        MessageBrut trackingInfo;
       

        //GMap.NET.GMaps maps = new GMap.NET.GMaps();

        public frmEyeLocal()
        {
            InitializeComponent();
        }

        private void EyeLocal_Load(object sender, EventArgs e)
        {

            conDB = new ConnectionDB();
            conDB.connect();
           

            string query = "SELECT  \"Registration_No\" FROM \"public\".\"Vehicule\"";

            OdbcCommand cmd = new OdbcCommand(query, conDB.getConnection());
            //NpgsqlDataReader dr = cmd.ExecuteReader();

            //dataAdapter = new OleDbDataAdapter(cmd);
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(cmd);

            DataTable datatable;
            dataAdapter.SelectCommand = cmd;
            datatable = new DataTable();
            dataAdapter.Fill(datatable);
            //dataset = new DataSet();

            lstbxterminal.DataSource = datatable;
            lstbxterminal.DisplayMember = "Registration_No";
            lstbxterminal.ValueMember = "Registration_No";

                      
            //Fill the listbox
            //querylist="sl"

            //Instanciation google map
            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache ;
            //map.SetPositionByKeywords("Douala, Cameroun");
            

            //Set the marker
           GMapOverlay markersOverlay = new GMapOverlay("markers");
           GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(5.966688,8.580528),GMarkerGoogleType.arrow);
           markersOverlay.Markers.Add(marker);

           // map.Overlays.Add(markersOverlay);

            //Initialisation du modem
            conMod = new ConnectionModem();
            conMod.init();

            map.DragButton = System.Windows.Forms.MouseButtons.Left;
            map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

        }





        private void pnlTerminal_Paint(object sender, PaintEventArgs e)  {}

        private void button1_Click(object sender, EventArgs e)  {  }
          
        private void pnlgrid_Paint(object sender, PaintEventArgs e)  { }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void submenurecievesms_Click(object sender, EventArgs e) { }

        private void pnlbody_Paint(object sender, PaintEventArgs e)  {  }


        private void btnSendmsg_Click(object sender, EventArgs e)  
        {

            conMod.sendMessage(txtATCmd.Text + "^(z)");

            //string recMsg = conMod.GetMessage();
            string stream = "";

            stream = stream + conMod.GetMessage();
            // lstbxReceiSMS.Items.Clear();
            lstbxReceiSMS.Items.Add(stream);
                

        }

        private void btnRecevmsg_Click(object sender, EventArgs e) {

            
            
                      

        }

        private void lstbxterminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            string strslct = ""; 
            strslct=lstbxterminal.SelectedValue.ToString();

            string query = "SELECT * FROM \"public\".\"Tracking\" WHERE \"Registration_No\" = '" + strslct + "'";
            OdbcCommand cmd = new OdbcCommand(query, conDB.getConnection());
            //NpgsqlDataReader dr = cmd.ExecuteReader();

            //dataAdapter = new OleDbDataAdapter(cmd);
            OdbcDataAdapter dataAdaptertracking = new OdbcDataAdapter(cmd);

            DataTable datatable;
            dataAdaptertracking.SelectCommand = cmd;
            datatable = new DataTable();
            dataAdaptertracking.Fill(datatable);
            //dataset = new DataSet();

            dataGridTracking.DataSource = datatable;
            //datagridTracking.DataBindings();

             }
            catch (Exception error) {  MessageBox.Show(error.ToString()); }

       }


        private void btnAskPosition_Click(object sender, EventArgs e)
        {
              Position newPosition = new Position();
              MessageBrut msg = new MessageBrut();


              MessageBox.Show(msg.getContent());

              newPosition = msg.AnalyzerMessage();

              MessageBox.Show(newPosition.getlat().ToString());
              MessageBox.Show(newPosition.getlg().ToString());
              MessageBox.Show(newPosition.getUrlMap().ToString());
              MessageBox.Show(newPosition.getdatetime().ToString());
       
                         
             // foreach (string info in msg.AnalyzerMessage() )
             // {
                 // MessageBox.Show(info);
             // }
              
              int Lat = Int32.Parse(txtLat.Text.ToString());  
              int Lng = Int32.Parse(txtLng.Text.ToString());  
                    
             GMapOverlay markersOverlay2 = new GMapOverlay("markers");
             GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Lat, Lng),GMarkerGoogleType.arrow);
             markersOverlay2.Markers.Add(marker);
             map.Overlays.Add(markersOverlay2);
             map.UpdateMarkerLocalPosition(marker);
             map.Update();


        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int eX=0, eY=0;

            PointLatLng p = map.FromLocalToLatLng(eX, eY);
            lblPosition.Text = Convert.ToString(p); 
        }

        private void txtLng_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeRecMSG_Tick(object sender, EventArgs e)
        {
            frmEyeLocal frm =new  frmEyeLocal();

            //frm.btnRecevmsg_Click(object sender, EventArgs e);

        }

        private void btnSendAT_Click(object sender, EventArgs e)
        {
            conMod.sendMessage(txtATCmd.Text);

            //string recMsg = conMod.GetMessage();
            string stream = "";

            stream = stream + conMod.GetMessage();
           // lstbxReceiSMS.Items.Clear();
            lstbxReceiSMS.Items.Add(stream);
        }

        private void SendNumber_Click(object sender, EventArgs e)
        {
            conMod.sendMessage(txtATCmd.Text+"\n");

            //string recMsg = conMod.GetMessage();
            string stream = "";

            stream = stream + conMod.GetMessage();
            // lstbxReceiSMS.Items.Clear();
            lstbxReceiSMS.Items.Add(stream);
        }

        private void dataGridTracking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
