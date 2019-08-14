namespace FleetManagment
{
    partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stationResponsesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stationsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.responseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrationToolStripMenuItem,
            this.incidentToolStripMenuItem,
            this.vehicleToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.stationToolStripMenuItem1,
            this.responseToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mainMenu.Size = new System.Drawing.Size(1527, 35);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountToolStripMenuItem,
            this.userAccountTsmi});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.administrationToolStripMenuItem.Text = "Administration";
            this.administrationToolStripMenuItem.Visible = false;
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.userAccountToolStripMenuItem.Text = "CurrentUser";
            this.userAccountToolStripMenuItem.Click += new System.EventHandler(this.userAccountToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiclesToolStripMenuItem,
            this.vehicleTypesToolStripMenuItem});
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            this.vehicleToolStripMenuItem.Visible = false;
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.VehiclesToolStripMenuItem_Click);
            // 
            // vehicleTypesToolStripMenuItem
            // 
            this.vehicleTypesToolStripMenuItem.Name = "vehicleTypesToolStripMenuItem";
            this.vehicleTypesToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.vehicleTypesToolStripMenuItem.Text = "Vehicle Types";
            this.vehicleTypesToolStripMenuItem.Click += new System.EventHandler(this.VehicleTypesToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countriesToolStripMenuItem1,
            this.citiesToolStripMenuItem1});
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Visible = false;
            // 
            // countriesToolStripMenuItem1
            // 
            this.countriesToolStripMenuItem1.Name = "countriesToolStripMenuItem1";
            this.countriesToolStripMenuItem1.Size = new System.Drawing.Size(189, 34);
            this.countriesToolStripMenuItem1.Text = "Countries";
            this.countriesToolStripMenuItem1.Click += new System.EventHandler(this.CountriesToolStripMenuItem1_Click);
            // 
            // citiesToolStripMenuItem1
            // 
            this.citiesToolStripMenuItem1.Name = "citiesToolStripMenuItem1";
            this.citiesToolStripMenuItem1.Size = new System.Drawing.Size(189, 34);
            this.citiesToolStripMenuItem1.Text = "Cities";
            this.citiesToolStripMenuItem1.Click += new System.EventHandler(this.CitiesToolStripMenuItem1_Click);
            // 
            // stationToolStripMenuItem1
            // 
            this.stationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stationResponsesToolStripMenuItem1,
            this.stationsToolStripMenuItem2});
            this.stationToolStripMenuItem1.Name = "stationToolStripMenuItem1";
            this.stationToolStripMenuItem1.Size = new System.Drawing.Size(83, 29);
            this.stationToolStripMenuItem1.Text = "Station";
            this.stationToolStripMenuItem1.Visible = false;
            // 
            // stationResponsesToolStripMenuItem1
            // 
            this.stationResponsesToolStripMenuItem1.Name = "stationResponsesToolStripMenuItem1";
            this.stationResponsesToolStripMenuItem1.Size = new System.Drawing.Size(258, 34);
            this.stationResponsesToolStripMenuItem1.Text = "Station Responses";
            this.stationResponsesToolStripMenuItem1.Click += new System.EventHandler(this.StationResponsesToolStripMenuItem1_Click);
            // 
            // stationsToolStripMenuItem2
            // 
            this.stationsToolStripMenuItem2.Name = "stationsToolStripMenuItem2";
            this.stationsToolStripMenuItem2.Size = new System.Drawing.Size(258, 34);
            this.stationsToolStripMenuItem2.Text = "Stations";
            this.stationsToolStripMenuItem2.Click += new System.EventHandler(this.StationsToolStripMenuItem2_Click);
            // 
            // responseToolStripMenuItem
            // 
            this.responseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.responsesToolStripMenuItem1});
            this.responseToolStripMenuItem.Name = "responseToolStripMenuItem";
            this.responseToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.responseToolStripMenuItem.Text = "Response";
            this.responseToolStripMenuItem.Visible = false;
            // 
            // responsesToolStripMenuItem1
            // 
            this.responsesToolStripMenuItem1.Name = "responsesToolStripMenuItem1";
            this.responsesToolStripMenuItem1.Size = new System.Drawing.Size(198, 34);
            this.responsesToolStripMenuItem1.Text = "Responses";
            this.responsesToolStripMenuItem1.Click += new System.EventHandler(this.ResponsesToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.libraryToolStripMenuItem.Text = "Manuali i perdorimit";
            this.libraryToolStripMenuItem.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // userAccountTsmi
            // 
            this.userAccountTsmi.Image = global::FleetManagment.Properties.Resources.man_icon;
            this.userAccountTsmi.Name = "userAccountTsmi";
            this.userAccountTsmi.Size = new System.Drawing.Size(214, 34);
            this.userAccountTsmi.Text = "UserAccount";
            this.userAccountTsmi.Click += new System.EventHandler(this.userAccountTsmi_Click);
            // 
            // incidentToolStripMenuItem
            // 
            this.incidentToolStripMenuItem.Name = "incidentToolStripMenuItem";
            this.incidentToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.incidentToolStripMenuItem.Text = "Incident";
            this.incidentToolStripMenuItem.Click += new System.EventHandler(this.IncidentToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1527, 820);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userAccountTsmi;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem responseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countriesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stationsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stationResponsesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem responsesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentToolStripMenuItem;
    }
}