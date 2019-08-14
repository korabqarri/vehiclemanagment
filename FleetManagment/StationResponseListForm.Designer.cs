namespace FleetManagment
{
    partial class StationResponseListForm
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
            this.dgvStationResponseList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfVehicles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationResponseList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationResponseBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvStationResponseList);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1200, 659);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1200, 692);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // dgvStationResponseList
            // 
            this.dgvStationResponseList.AllowUserToAddRows = false;
            this.dgvStationResponseList.AllowUserToDeleteRows = false;
            this.dgvStationResponseList.AutoGenerateColumns = false;
            this.dgvStationResponseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationResponseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.ResponseId,
            this.StationId,
            this.NumberOfVehicles,
            this.VehicleTypeId,
            this.Response,
            this.Station,
            this.VehicleType});
            this.dgvStationResponseList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvStationResponseList.DataSource = this.stationResponseBindingSource;
            this.dgvStationResponseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStationResponseList.Location = new System.Drawing.Point(0, 0);
            this.dgvStationResponseList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStationResponseList.MultiSelect = false;
            this.dgvStationResponseList.Name = "dgvStationResponseList";
            this.dgvStationResponseList.ReadOnly = true;
            this.dgvStationResponseList.RowHeadersWidth = 62;
            this.dgvStationResponseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStationResponseList.Size = new System.Drawing.Size(1200, 659);
            this.dgvStationResponseList.TabIndex = 0;
            this.dgvStationResponseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStationResponseList_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 68);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // stationResponseBindingSource
            // 
            this.stationResponseBindingSource.DataSource = typeof(FleetManagment.BO.StationResponse);
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
            this.toolStrip1.Size = new System.Drawing.Size(120, 33);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::FleetManagment.Properties.Resources.Button_Add_icon;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::FleetManagment.Properties.Resources.Button_Refresh_icon;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
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
            // ResponseId
            // 
            this.ResponseId.DataPropertyName = "ResponseId";
            this.ResponseId.HeaderText = "ResponseId";
            this.ResponseId.MinimumWidth = 8;
            this.ResponseId.Name = "ResponseId";
            this.ResponseId.ReadOnly = true;
            this.ResponseId.Visible = false;
            this.ResponseId.Width = 150;
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
            // NumberOfVehicles
            // 
            this.NumberOfVehicles.DataPropertyName = "NumberOfVehicles";
            this.NumberOfVehicles.HeaderText = "NumberOfVehicles";
            this.NumberOfVehicles.MinimumWidth = 8;
            this.NumberOfVehicles.Name = "NumberOfVehicles";
            this.NumberOfVehicles.ReadOnly = true;
            this.NumberOfVehicles.Width = 150;
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
            // Response
            // 
            this.Response.DataPropertyName = "ResponseName";
            this.Response.HeaderText = "Response";
            this.Response.MinimumWidth = 8;
            this.Response.Name = "Response";
            this.Response.ReadOnly = true;
            this.Response.Width = 150;
            // 
            // Station
            // 
            this.Station.DataPropertyName = "StationName";
            this.Station.HeaderText = "Station";
            this.Station.MinimumWidth = 8;
            this.Station.Name = "Station";
            this.Station.ReadOnly = true;
            this.Station.Width = 150;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleTypeName";
            this.VehicleType.HeaderText = "VehicleType";
            this.VehicleType.MinimumWidth = 8;
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            this.VehicleType.Width = 150;
            // 
            // StationResponseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StationResponseListForm";
            this.Text = "StationResponses List";
            this.Activated += new System.EventHandler(this.VehicleTypeListForm_Activated);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationResponseList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stationResponseBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.BindingSource stationResponseBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvStationResponseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Response;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
    }
}