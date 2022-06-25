namespace EyeLocal
{
    partial class frmEyeLocal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlbody = new System.Windows.Forms.Panel();
            this.btnRecevmsg = new System.Windows.Forms.Button();
            this.pnlgrid = new System.Windows.Forms.Panel();
            this.dataGridTracking = new System.Windows.Forms.DataGridView();
            this.lstbxReceiSMS = new System.Windows.Forms.ListBox();
            this.pnlinfo = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            this.btnuserstatus = new System.Windows.Forms.Button();
            this.btnviews = new System.Windows.Forms.Button();
            this.btnfuntion = new System.Windows.Forms.Button();
            this.btnsystems = new System.Windows.Forms.Button();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.pnlTerminal = new System.Windows.Forms.Panel();
            this.SendNumber = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSendAT = new System.Windows.Forms.Button();
            this.txtATCmd = new System.Windows.Forms.TextBox();
            this.btnSendmsg = new System.Windows.Forms.Button();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.btnAskPosition = new System.Windows.Forms.Button();
            this.lstbxterminal = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menufile = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuuseradmin = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menusms = new System.Windows.Forms.ToolStripMenuItem();
            this.submenusendsms = new System.Windows.Forms.ToolStripMenuItem();
            this.submenurecievesms = new System.Windows.Forms.ToolStripMenuItem();
            this.menusetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.eyeLocalDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeRecMSG = new System.Windows.Forms.Timer(this.components);
            this.pnlbody.SuspendLayout();
            this.pnlgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTracking)).BeginInit();
            this.pnlinfo.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.pnlTerminal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeLocalDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbody
            // 
            this.pnlbody.Controls.Add(this.btnRecevmsg);
            this.pnlbody.Controls.Add(this.pnlgrid);
            this.pnlbody.Controls.Add(this.pnlinfo);
            this.pnlbody.Controls.Add(this.btnviews);
            this.pnlbody.Controls.Add(this.btnfuntion);
            this.pnlbody.Controls.Add(this.btnsystems);
            this.pnlbody.Controls.Add(this.pnlMap);
            this.pnlbody.Controls.Add(this.pnlTerminal);
            this.pnlbody.Controls.Add(this.menuStrip1);
            this.pnlbody.Location = new System.Drawing.Point(2, 2);
            this.pnlbody.Name = "pnlbody";
            this.pnlbody.Size = new System.Drawing.Size(854, 484);
            this.pnlbody.TabIndex = 2;
            this.pnlbody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlbody_Paint);
            // 
            // btnRecevmsg
            // 
            this.btnRecevmsg.Location = new System.Drawing.Point(243, 28);
            this.btnRecevmsg.Name = "btnRecevmsg";
            this.btnRecevmsg.Size = new System.Drawing.Size(93, 23);
            this.btnRecevmsg.TabIndex = 6;
            this.btnRecevmsg.Text = "Receive SMS";
            this.btnRecevmsg.UseVisualStyleBackColor = true;
            this.btnRecevmsg.Click += new System.EventHandler(this.btnRecevmsg_Click);
            // 
            // pnlgrid
            // 
            this.pnlgrid.Controls.Add(this.dataGridTracking);
            this.pnlgrid.Controls.Add(this.lstbxReceiSMS);
            this.pnlgrid.Location = new System.Drawing.Point(121, 330);
            this.pnlgrid.Name = "pnlgrid";
            this.pnlgrid.Size = new System.Drawing.Size(733, 151);
            this.pnlgrid.TabIndex = 3;
            this.pnlgrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlgrid_Paint);
            // 
            // dataGridTracking
            // 
            this.dataGridTracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTracking.Location = new System.Drawing.Point(4, 3);
            this.dataGridTracking.Name = "dataGridTracking";
            this.dataGridTracking.Size = new System.Drawing.Size(726, 68);
            this.dataGridTracking.TabIndex = 0;
            this.dataGridTracking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTracking_CellContentClick);
            // 
            // lstbxReceiSMS
            // 
            this.lstbxReceiSMS.FormattingEnabled = true;
            this.lstbxReceiSMS.Location = new System.Drawing.Point(16, 82);
            this.lstbxReceiSMS.Name = "lstbxReceiSMS";
            this.lstbxReceiSMS.Size = new System.Drawing.Size(630, 69);
            this.lstbxReceiSMS.TabIndex = 3;
            // 
            // pnlinfo
            // 
            this.pnlinfo.Controls.Add(this.lblPosition);
            this.pnlinfo.Controls.Add(this.button2);
            this.pnlinfo.Controls.Add(this.button1);
            this.pnlinfo.Controls.Add(this.btnimport);
            this.pnlinfo.Controls.Add(this.btnuserstatus);
            this.pnlinfo.Location = new System.Drawing.Point(751, 57);
            this.pnlinfo.Name = "pnlinfo";
            this.pnlinfo.Size = new System.Drawing.Size(100, 213);
            this.pnlinfo.TabIndex = 2;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(3, 127);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(35, 13);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(4, 33);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(75, 23);
            this.btnimport.TabIndex = 0;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            // 
            // btnuserstatus
            // 
            this.btnuserstatus.Location = new System.Drawing.Point(4, 4);
            this.btnuserstatus.Name = "btnuserstatus";
            this.btnuserstatus.Size = new System.Drawing.Size(75, 23);
            this.btnuserstatus.TabIndex = 0;
            this.btnuserstatus.Text = "User Status";
            this.btnuserstatus.UseVisualStyleBackColor = true;
            // 
            // btnviews
            // 
            this.btnviews.Location = new System.Drawing.Point(363, 26);
            this.btnviews.Name = "btnviews";
            this.btnviews.Size = new System.Drawing.Size(93, 23);
            this.btnviews.TabIndex = 1;
            this.btnviews.Text = "Views";
            this.btnviews.UseVisualStyleBackColor = true;
            // 
            // btnfuntion
            // 
            this.btnfuntion.Location = new System.Drawing.Point(473, 26);
            this.btnfuntion.Name = "btnfuntion";
            this.btnfuntion.Size = new System.Drawing.Size(93, 23);
            this.btnfuntion.TabIndex = 1;
            this.btnfuntion.Text = "Functions";
            this.btnfuntion.UseVisualStyleBackColor = true;
            // 
            // btnsystems
            // 
            this.btnsystems.Location = new System.Drawing.Point(572, 25);
            this.btnsystems.Name = "btnsystems";
            this.btnsystems.Size = new System.Drawing.Size(93, 23);
            this.btnsystems.TabIndex = 1;
            this.btnsystems.Text = "Systems";
            this.btnsystems.UseVisualStyleBackColor = true;
            this.btnsystems.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.map);
            this.pnlMap.Location = new System.Drawing.Point(121, 57);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(624, 270);
            this.pnlMap.TabIndex = 0;
            // 
            // map
            // 
            this.map.AllowDrop = true;
            this.map.AutoSize = true;
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.AliceBlue;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(4, -3);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 18;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(624, 270);
            this.map.TabIndex = 0;
            this.map.Zoom = 5D;
            // 
            // pnlTerminal
            // 
            this.pnlTerminal.Controls.Add(this.SendNumber);
            this.pnlTerminal.Controls.Add(this.btnClear);
            this.pnlTerminal.Controls.Add(this.btnSendAT);
            this.pnlTerminal.Controls.Add(this.txtATCmd);
            this.pnlTerminal.Controls.Add(this.btnSendmsg);
            this.pnlTerminal.Controls.Add(this.txtLng);
            this.pnlTerminal.Controls.Add(this.txtLat);
            this.pnlTerminal.Controls.Add(this.btnAskPosition);
            this.pnlTerminal.Controls.Add(this.lstbxterminal);
            this.pnlTerminal.Location = new System.Drawing.Point(0, 28);
            this.pnlTerminal.Name = "pnlTerminal";
            this.pnlTerminal.Size = new System.Drawing.Size(119, 453);
            this.pnlTerminal.TabIndex = 0;
            this.pnlTerminal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTerminal_Paint);
            // 
            // SendNumber
            // 
            this.SendNumber.Location = new System.Drawing.Point(19, 293);
            this.SendNumber.Name = "SendNumber";
            this.SendNumber.Size = new System.Drawing.Size(96, 23);
            this.SendNumber.TabIndex = 7;
            this.SendNumber.Text = "SendNumber";
            this.SendNumber.UseVisualStyleBackColor = true;
            this.SendNumber.Click += new System.EventHandler(this.SendNumber_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(22, 384);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSendAT
            // 
            this.btnSendAT.Location = new System.Drawing.Point(16, 265);
            this.btnSendAT.Name = "btnSendAT";
            this.btnSendAT.Size = new System.Drawing.Size(96, 22);
            this.btnSendAT.TabIndex = 6;
            this.btnSendAT.Text = "Send AT";
            this.btnSendAT.UseVisualStyleBackColor = true;
            this.btnSendAT.Click += new System.EventHandler(this.btnSendAT_Click);
            // 
            // txtATCmd
            // 
            this.txtATCmd.Location = new System.Drawing.Point(13, 239);
            this.txtATCmd.Name = "txtATCmd";
            this.txtATCmd.Size = new System.Drawing.Size(99, 20);
            this.txtATCmd.TabIndex = 4;
            // 
            // btnSendmsg
            // 
            this.btnSendmsg.Location = new System.Drawing.Point(19, 322);
            this.btnSendmsg.Name = "btnSendmsg";
            this.btnSendmsg.Size = new System.Drawing.Size(99, 21);
            this.btnSendmsg.TabIndex = 5;
            this.btnSendmsg.Text = "Send SMS";
            this.btnSendmsg.UseVisualStyleBackColor = true;
            this.btnSendmsg.Click += new System.EventHandler(this.btnSendmsg_Click);
            // 
            // txtLng
            // 
            this.txtLng.Location = new System.Drawing.Point(23, 196);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(72, 20);
            this.txtLng.TabIndex = 3;
            this.txtLng.Text = "80";
            this.txtLng.TextChanged += new System.EventHandler(this.txtLng_TextChanged);
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(23, 170);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(73, 20);
            this.txtLat.TabIndex = 2;
            this.txtLat.Text = "80";
            // 
            // btnAskPosition
            // 
            this.btnAskPosition.Location = new System.Drawing.Point(13, 120);
            this.btnAskPosition.Name = "btnAskPosition";
            this.btnAskPosition.Size = new System.Drawing.Size(73, 25);
            this.btnAskPosition.TabIndex = 1;
            this.btnAskPosition.Text = "Ask Position";
            this.btnAskPosition.UseVisualStyleBackColor = true;
            this.btnAskPosition.Click += new System.EventHandler(this.btnAskPosition_Click);
            // 
            // lstbxterminal
            // 
            this.lstbxterminal.FormattingEnabled = true;
            this.lstbxterminal.Location = new System.Drawing.Point(3, 3);
            this.lstbxterminal.Name = "lstbxterminal";
            this.lstbxterminal.Size = new System.Drawing.Size(109, 108);
            this.lstbxterminal.TabIndex = 0;
            this.lstbxterminal.SelectedIndexChanged += new System.EventHandler(this.lstbxterminal_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menufile,
            this.menusms,
            this.menusetting,
            this.menuhelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menufile
            // 
            this.menufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuuseradmin,
            this.closeToolStripMenuItem});
            this.menufile.Name = "menufile";
            this.menufile.Size = new System.Drawing.Size(37, 20);
            this.menufile.Text = "File";
            // 
            // submenuuseradmin
            // 
            this.submenuuseradmin.Name = "submenuuseradmin";
            this.submenuuseradmin.Size = new System.Drawing.Size(103, 22);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // menusms
            // 
            this.menusms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenusendsms,
            this.submenurecievesms});
            this.menusms.Name = "menusms";
            this.menusms.Size = new System.Drawing.Size(42, 20);
            this.menusms.Text = "SMS";
            // 
            // submenusendsms
            // 
            this.submenusendsms.Name = "submenusendsms";
            this.submenusendsms.Size = new System.Drawing.Size(140, 22);
            this.submenusendsms.Text = "Send SMS";
            // 
            // submenurecievesms
            // 
            this.submenurecievesms.Name = "submenurecievesms";
            this.submenurecievesms.Size = new System.Drawing.Size(140, 22);
            this.submenurecievesms.Text = "Recieve SMS";
            this.submenurecievesms.Click += new System.EventHandler(this.submenurecievesms_Click);
            // 
            // menusetting
            // 
            this.menusetting.Name = "menusetting";
            this.menusetting.Size = new System.Drawing.Size(61, 20);
            this.menusetting.Text = "Settings";
            // 
            // menuhelp
            // 
            this.menuhelp.Name = "menuhelp";
            this.menuhelp.Size = new System.Drawing.Size(24, 20);
            this.menuhelp.Text = "?";
            // 
            // timeRecMSG
            // 
            this.timeRecMSG.Tick += new System.EventHandler(this.timeRecMSG_Tick);
            // 
            // frmEyeLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(903, 510);
            this.Controls.Add(this.pnlbody);
            this.Name = "frmEyeLocal";
            this.Text = "EyeLocal";
            this.Load += new System.EventHandler(this.EyeLocal_Load);
            this.pnlbody.ResumeLayout(false);
            this.pnlbody.PerformLayout();
            this.pnlgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTracking)).EndInit();
            this.pnlinfo.ResumeLayout(false);
            this.pnlinfo.PerformLayout();
            this.pnlMap.ResumeLayout(false);
            this.pnlMap.PerformLayout();
            this.pnlTerminal.ResumeLayout(false);
            this.pnlTerminal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyeLocalDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnsystem_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel pnlbody;
        private System.Windows.Forms.Panel pnlTerminal;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Button btnviews;
        private System.Windows.Forms.Button btnfuntion;
        private System.Windows.Forms.Button btnsystems;
        private System.Windows.Forms.Panel pnlinfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnuserstatus;
        private System.Windows.Forms.ListBox lstbxterminal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menufile;
        private System.Windows.Forms.ToolStripMenuItem menusms;
        private System.Windows.Forms.ToolStripMenuItem menusetting;
        private System.Windows.Forms.ToolStripMenuItem menuhelp;
        private System.Windows.Forms.ToolStripMenuItem submenusendsms;
        private System.Windows.Forms.ToolStripMenuItem submenurecievesms;
        private System.Windows.Forms.ToolStripMenuItem submenuuseradmin;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMEIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIMNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedkmhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelerationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eyeLocalDBDataSetBindingSource;
        private System.Windows.Forms.Button btnRecevmsg;
        private System.Windows.Forms.Button btnSendmsg;
        private System.Windows.Forms.Button btnAskPosition;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Panel pnlgrid;
        private System.Windows.Forms.DataGridView dataGridTracking;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Timer timeRecMSG;
        private System.Windows.Forms.TextBox txtATCmd;
        private System.Windows.Forms.ListBox lstbxReceiSMS;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSendAT;
        private System.Windows.Forms.Button SendNumber;
    }
}

