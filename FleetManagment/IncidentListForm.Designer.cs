namespace FleetManagment
{
    partial class IncidentListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddressAdditional = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.cmbResponseId = new System.Windows.Forms.ComboBox();
            this.stationResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chbIsEmergency = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIncidentList = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressAdditional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationResponseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReporterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReporterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReporterSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emergency = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblComment = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidentList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblComment);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnSave);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvIncidentList);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1943, 1268);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1943, 1268);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1323, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(517, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLastname);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtFirstname);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(1322, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 325);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reporter Info";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(67, 158);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.ReadOnly = true;
            this.txtLastname.Size = new System.Drawing.Size(384, 26);
            this.txtLastname.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Lastname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(67, 80);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.ReadOnly = true;
            this.txtFirstname.Size = new System.Drawing.Size(384, 26);
            this.txtFirstname.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Firstname:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLongitude);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLatitude);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAddressAdditional);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(682, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 446);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location Info";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(271, 299);
            this.txtLongitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(171, 26);
            this.txtLongitude.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Longitude:";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(71, 299);
            this.txtLatitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(176, 26);
            this.txtLatitude.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Latitude:";
            // 
            // txtAddressAdditional
            // 
            this.txtAddressAdditional.Location = new System.Drawing.Point(71, 160);
            this.txtAddressAdditional.Multiline = true;
            this.txtAddressAdditional.Name = "txtAddressAdditional";
            this.txtAddressAdditional.Size = new System.Drawing.Size(384, 87);
            this.txtAddressAdditional.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Additional Location Info:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(71, 80);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(384, 26);
            this.txtAddress.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.dtTime);
            this.groupBox1.Controls.Add(this.cmbResponseId);
            this.groupBox1.Controls.Add(this.chbIsEmergency);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 446);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incident Info";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(73, 82);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(384, 87);
            this.txtDescription.TabIndex = 0;
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtTime.Enabled = false;
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(73, 376);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(384, 26);
            this.dtTime.TabIndex = 68;
            // 
            // cmbResponseId
            // 
            this.cmbResponseId.DataSource = this.stationResponseBindingSource;
            this.cmbResponseId.DisplayMember = "ResponseName";
            this.cmbResponseId.FormattingEnabled = true;
            this.cmbResponseId.Location = new System.Drawing.Point(73, 221);
            this.cmbResponseId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbResponseId.Name = "cmbResponseId";
            this.cmbResponseId.Size = new System.Drawing.Size(384, 28);
            this.cmbResponseId.TabIndex = 1;
            this.cmbResponseId.ValueMember = "ID";
            this.cmbResponseId.SelectedIndexChanged += new System.EventHandler(this.CmbResponseId_SelectedIndexChanged);
            // 
            // stationResponseBindingSource
            // 
            this.stationResponseBindingSource.DataSource = typeof(FleetManagment.BO.StationResponse);
            // 
            // chbIsEmergency
            // 
            this.chbIsEmergency.AutoSize = true;
            this.chbIsEmergency.Location = new System.Drawing.Point(73, 286);
            this.chbIsEmergency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbIsEmergency.Name = "chbIsEmergency";
            this.chbIsEmergency.Size = new System.Drawing.Size(132, 24);
            this.chbIsEmergency.TabIndex = 64;
            this.chbIsEmergency.Text = "Is Emergency";
            this.chbIsEmergency.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Response:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Incident Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 347);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Time:";
            // 
            // dgvIncidentList
            // 
            this.dgvIncidentList.AllowUserToAddRows = false;
            this.dgvIncidentList.AllowUserToDeleteRows = false;
            this.dgvIncidentList.AutoGenerateColumns = false;
            this.dgvIncidentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncidentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIncidentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.ResponseId,
            this.Address,
            this.AddressAdditional,
            this.StationResponseId,
            this.ReporterId,
            this.ReporterName,
            this.ReporterSurname,
            this.Emergency,
            this.Latitude,
            this.Longitude});
            this.dgvIncidentList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvIncidentList.DataSource = this.incidentBindingSource;
            this.dgvIncidentList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvIncidentList.Location = new System.Drawing.Point(0, 633);
            this.dgvIncidentList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvIncidentList.MultiSelect = false;
            this.dgvIncidentList.Name = "dgvIncidentList";
            this.dgvIncidentList.ReadOnly = true;
            this.dgvIncidentList.RowHeadersWidth = 62;
            this.dgvIncidentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncidentList.Size = new System.Drawing.Size(1943, 635);
            this.dgvIncidentList.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 62;
            // 
            // ResponseId
            // 
            this.ResponseId.DataPropertyName = "Time";
            this.ResponseId.HeaderText = "Time";
            this.ResponseId.MinimumWidth = 8;
            this.ResponseId.Name = "ResponseId";
            this.ResponseId.ReadOnly = true;
            this.ResponseId.Visible = false;
            this.ResponseId.Width = 150;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 104;
            // 
            // AddressAdditional
            // 
            this.AddressAdditional.DataPropertyName = "AddressAdditional";
            this.AddressAdditional.HeaderText = "AddressAdditional";
            this.AddressAdditional.MinimumWidth = 8;
            this.AddressAdditional.Name = "AddressAdditional";
            this.AddressAdditional.ReadOnly = true;
            this.AddressAdditional.Width = 174;
            // 
            // StationResponseId
            // 
            this.StationResponseId.DataPropertyName = "StationResponseId";
            this.StationResponseId.HeaderText = "StationResponseId";
            this.StationResponseId.MinimumWidth = 8;
            this.StationResponseId.Name = "StationResponseId";
            this.StationResponseId.ReadOnly = true;
            this.StationResponseId.Width = 183;
            // 
            // ReporterId
            // 
            this.ReporterId.DataPropertyName = "ReporterId";
            this.ReporterId.HeaderText = "ReporterId";
            this.ReporterId.MinimumWidth = 8;
            this.ReporterId.Name = "ReporterId";
            this.ReporterId.ReadOnly = true;
            this.ReporterId.Width = 122;
            // 
            // ReporterName
            // 
            this.ReporterName.DataPropertyName = "ReporterName";
            this.ReporterName.HeaderText = "ReporterName";
            this.ReporterName.MinimumWidth = 8;
            this.ReporterName.Name = "ReporterName";
            this.ReporterName.ReadOnly = true;
            this.ReporterName.Width = 150;
            // 
            // ReporterSurname
            // 
            this.ReporterSurname.DataPropertyName = "ReporterSurname";
            this.ReporterSurname.HeaderText = "ReporterSurname";
            this.ReporterSurname.MinimumWidth = 8;
            this.ReporterSurname.Name = "ReporterSurname";
            this.ReporterSurname.ReadOnly = true;
            this.ReporterSurname.Width = 173;
            // 
            // Emergency
            // 
            this.Emergency.DataPropertyName = "Emergency";
            this.Emergency.HeaderText = "Emergency";
            this.Emergency.MinimumWidth = 8;
            this.Emergency.Name = "Emergency";
            this.Emergency.ReadOnly = true;
            this.Emergency.Width = 95;
            // 
            // Latitude
            // 
            this.Latitude.DataPropertyName = "Latitude";
            this.Latitude.HeaderText = "Latitude";
            this.Latitude.MinimumWidth = 8;
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            this.Latitude.Width = 103;
            // 
            // Longitude
            // 
            this.Longitude.DataPropertyName = "Longitude";
            this.Longitude.HeaderText = "Longitude";
            this.Longitude.MinimumWidth = 8;
            this.Longitude.Name = "Longitude";
            this.Longitude.ReadOnly = true;
            this.Longitude.Width = 116;
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
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataSource = typeof(FleetManagment.BO.Incident);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.DarkRed;
            this.lblComment.Location = new System.Drawing.Point(60, 491);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(0, 25);
            this.lblComment.TabIndex = 79;
            // 
            // IncidentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1943, 1268);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IncidentListForm";
            this.Text = "New Incident";
            this.Activated += new System.EventHandler(this.VehicleTypeListForm_Activated);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidentList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvIncidentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressAdditional;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationResponseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReporterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReporterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReporterSurname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Emergency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.ComboBox cmbResponseId;
        private System.Windows.Forms.CheckBox chbIsEmergency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddressAdditional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource stationResponseBindingSource;
        private System.Windows.Forms.Label lblComment;
    }
}