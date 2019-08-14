namespace FleetManagment
{
    partial class StationResponseForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbResponseId = new System.Windows.Forms.ComboBox();
            this.cmbStationId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVehicleTypeId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNumberOfVehicles = new System.Windows.Forms.NumericUpDown();
            this.responseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(533, 314);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.Location = new System.Drawing.Point(375, 314);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(39, 314);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Response";
            // 
            // cmbResponseId
            // 
            this.cmbResponseId.DataSource = this.responseBindingSource;
            this.cmbResponseId.DisplayMember = "Name";
            this.cmbResponseId.FormattingEnabled = true;
            this.cmbResponseId.Location = new System.Drawing.Point(222, 48);
            this.cmbResponseId.Name = "cmbResponseId";
            this.cmbResponseId.Size = new System.Drawing.Size(407, 28);
            this.cmbResponseId.TabIndex = 48;
            this.cmbResponseId.ValueMember = "ID";
            // 
            // cmbStationId
            // 
            this.cmbStationId.DataSource = this.stationBindingSource;
            this.cmbStationId.DisplayMember = "Name";
            this.cmbStationId.FormattingEnabled = true;
            this.cmbStationId.Location = new System.Drawing.Point(222, 110);
            this.cmbStationId.Name = "cmbStationId";
            this.cmbStationId.Size = new System.Drawing.Size(407, 28);
            this.cmbStationId.TabIndex = 50;
            this.cmbStationId.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Number Of Vehicles";
            // 
            // cmbVehicleTypeId
            // 
            this.cmbVehicleTypeId.DataSource = this.vehicleTypesBindingSource;
            this.cmbVehicleTypeId.DisplayMember = "Name";
            this.cmbVehicleTypeId.FormattingEnabled = true;
            this.cmbVehicleTypeId.Location = new System.Drawing.Point(222, 233);
            this.cmbVehicleTypeId.Name = "cmbVehicleTypeId";
            this.cmbVehicleTypeId.Size = new System.Drawing.Size(407, 28);
            this.cmbVehicleTypeId.TabIndex = 54;
            this.cmbVehicleTypeId.ValueMember = "ID";
            this.cmbVehicleTypeId.SelectedIndexChanged += new System.EventHandler(this.CmbVehicleTypeId_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Vehicle Type";
            // 
            // nudNumberOfVehicles
            // 
            this.nudNumberOfVehicles.Location = new System.Drawing.Point(222, 171);
            this.nudNumberOfVehicles.Name = "nudNumberOfVehicles";
            this.nudNumberOfVehicles.Size = new System.Drawing.Size(407, 26);
            this.nudNumberOfVehicles.TabIndex = 55;
            // 
            // responseBindingSource
            // 
            this.responseBindingSource.DataSource = typeof(FleetManagment.BO.Response);
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataSource = typeof(FleetManagment.BO.Station);
            // 
            // vehicleTypesBindingSource
            // 
            this.vehicleTypesBindingSource.DataSource = typeof(FleetManagment.BO.VehicleType);
            // 
            // StationResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 374);
            this.Controls.Add(this.nudNumberOfVehicles);
            this.Controls.Add(this.cmbVehicleTypeId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStationId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbResponseId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StationResponseForm";
            this.Text = "StationResponse Form";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbResponseId;
        private System.Windows.Forms.ComboBox cmbStationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVehicleTypeId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumberOfVehicles;
        private System.Windows.Forms.BindingSource responseBindingSource;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private System.Windows.Forms.BindingSource vehicleTypesBindingSource;
    }
}

