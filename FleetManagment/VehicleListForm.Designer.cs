namespace FleetManagment
{
    partial class VehicleListForm
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgvVehicleList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvVehicleList);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 419);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // dgvVehicleList
            // 
            this.dgvVehicleList.AllowUserToAddRows = false;
            this.dgvVehicleList.AllowUserToDeleteRows = false;
            this.dgvVehicleList.AutoGenerateColumns = false;
            this.dgvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.LicensePlate,
            this.VehicleTypeName,
            this.StationName,
            this.IsAvailable,
            this.VehicleTypeId,
            this.StationId});
            this.dgvVehicleList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvVehicleList.DataSource = this.vehicleBindingSource;
            this.dgvVehicleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicleList.Location = new System.Drawing.Point(0, 0);
            this.dgvVehicleList.MultiSelect = false;
            this.dgvVehicleList.Name = "dgvVehicleList";
            this.dgvVehicleList.ReadOnly = true;
            this.dgvVehicleList.RowHeadersWidth = 62;
            this.dgvVehicleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicleList.Size = new System.Drawing.Size(800, 419);
            this.dgvVehicleList.TabIndex = 0;
            this.dgvVehicleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleList_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(FleetManagment.BO.Vehicle);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(91, 31);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::FleetManagment.Properties.Resources.Button_Add_icon;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::FleetManagment.Properties.Resources.Button_Refresh_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 28);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // LicensePlate
            // 
            this.LicensePlate.DataPropertyName = "LicensePlate";
            this.LicensePlate.HeaderText = "License Plate";
            this.LicensePlate.MinimumWidth = 8;
            this.LicensePlate.Name = "LicensePlate";
            this.LicensePlate.ReadOnly = true;
            this.LicensePlate.Width = 150;
            // 
            // VehicleTypeName
            // 
            this.VehicleTypeName.DataPropertyName = "VehicleTypeName";
            this.VehicleTypeName.HeaderText = "Vehicle Type";
            this.VehicleTypeName.MinimumWidth = 8;
            this.VehicleTypeName.Name = "VehicleTypeName";
            this.VehicleTypeName.ReadOnly = true;
            this.VehicleTypeName.Width = 150;
            // 
            // StationName
            // 
            this.StationName.DataPropertyName = "StationName";
            this.StationName.HeaderText = "Station";
            this.StationName.MinimumWidth = 8;
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            this.StationName.Width = 150;
            // 
            // IsAvailable
            // 
            this.IsAvailable.DataPropertyName = "IsAvailable";
            this.IsAvailable.HeaderText = "Available";
            this.IsAvailable.Name = "IsAvailable";
            this.IsAvailable.ReadOnly = true;
            // 
            // VehicleTypeId
            // 
            this.VehicleTypeId.DataPropertyName = "VehicleTypeId";
            this.VehicleTypeId.HeaderText = "VehicleTypeId";
            this.VehicleTypeId.MinimumWidth = 8;
            this.VehicleTypeId.Name = "VehicleTypeId";
            this.VehicleTypeId.ReadOnly = true;
            this.VehicleTypeId.Visible = false;
            this.VehicleTypeId.Width = 150;
            // 
            // StationId
            // 
            this.StationId.DataPropertyName = "StationId";
            this.StationId.HeaderText = "StationId";
            this.StationId.MinimumWidth = 8;
            this.StationId.Name = "StationId";
            this.StationId.ReadOnly = true;
            this.StationId.Visible = false;
            this.StationId.Width = 150;
            // 
            // VehicleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "VehicleListForm";
            this.Text = "Vehicles List";
            this.Activated += new System.EventHandler(this.VehicleTypeListForm_Activated);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvVehicleList;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationId;
    }
}