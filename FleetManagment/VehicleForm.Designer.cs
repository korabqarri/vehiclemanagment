namespace FleetManagment
{
    partial class VehicleForm
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
            this.cmbVehicleTypeId = new System.Windows.Forms.ComboBox();
            this.vehicleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.cmbStationId = new System.Windows.Forms.ComboBox();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.checkAvailable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.Location = new System.Drawing.Point(252, 207);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(28, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Vehicle Type";
            // 
            // cmbVehicleTypeId
            // 
            this.cmbVehicleTypeId.DataSource = this.vehicleTypeBindingSource;
            this.cmbVehicleTypeId.DisplayMember = "Name";
            this.cmbVehicleTypeId.FormattingEnabled = true;
            this.cmbVehicleTypeId.Location = new System.Drawing.Point(148, 70);
            this.cmbVehicleTypeId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVehicleTypeId.Name = "cmbVehicleTypeId";
            this.cmbVehicleTypeId.Size = new System.Drawing.Size(273, 21);
            this.cmbVehicleTypeId.TabIndex = 48;
            this.cmbVehicleTypeId.ValueMember = "ID";
            // 
            // vehicleTypeBindingSource
            // 
            this.vehicleTypeBindingSource.DataSource = typeof(FleetManagment.BO.VehicleType);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "License Plate";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(148, 31);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(273, 20);
            this.txtLicensePlate.TabIndex = 50;
            // 
            // cmbStationId
            // 
            this.cmbStationId.DataSource = this.stationBindingSource;
            this.cmbStationId.DisplayMember = "Name";
            this.cmbStationId.FormattingEnabled = true;
            this.cmbStationId.Location = new System.Drawing.Point(148, 111);
            this.cmbStationId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStationId.Name = "cmbStationId";
            this.cmbStationId.Size = new System.Drawing.Size(273, 21);
            this.cmbStationId.TabIndex = 52;
            this.cmbStationId.ValueMember = "ID";
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataSource = typeof(FleetManagment.BO.Station);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Station";
            // 
            // checkAvailable
            // 
            this.checkAvailable.AutoSize = true;
            this.checkAvailable.Location = new System.Drawing.Point(148, 151);
            this.checkAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.checkAvailable.Name = "checkAvailable";
            this.checkAvailable.Size = new System.Drawing.Size(80, 17);
            this.checkAvailable.TabIndex = 53;
            this.checkAvailable.Text = "Is Available";
            this.checkAvailable.UseVisualStyleBackColor = true;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 252);
            this.Controls.Add(this.checkAvailable);
            this.Controls.Add(this.cmbStationId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVehicleTypeId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Name = "VehicleForm";
            this.Text = "Vehicle Form";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVehicleTypeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.BindingSource vehicleTypeBindingSource;
        private System.Windows.Forms.ComboBox cmbStationId;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkAvailable;
    }
}

