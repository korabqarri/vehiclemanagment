namespace FleetManagment
{
    partial class UserListForm
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
            this.dgvUserAccount = new System.Windows.Forms.DataGridView();
            this.cmsUserAccountContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddUser = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccount)).BeginInit();
            this.cmsUserAccountContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvUserAccount);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1716, 832);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1752, 832);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // dgvUserAccount
            // 
            this.dgvUserAccount.AllowUserToAddRows = false;
            this.dgvUserAccount.AllowUserToDeleteRows = false;
            this.dgvUserAccount.AutoGenerateColumns = false;
            this.dgvUserAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.City,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.roleIdDataGridViewTextBoxColumn,
            this.RoleName,
            this.insertByDataGridViewTextBoxColumn,
            this.insDateDataGridViewTextBoxColumn,
            this.updateByDataGridViewTextBoxColumn,
            this.updateDateDataGridViewTextBoxColumn,
            this.updateNoDataGridViewTextBoxColumn});
            this.dgvUserAccount.ContextMenuStrip = this.cmsUserAccountContext;
            this.dgvUserAccount.DataSource = this.userAccountBindingSource;
            this.dgvUserAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserAccount.Location = new System.Drawing.Point(0, 0);
            this.dgvUserAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUserAccount.Name = "dgvUserAccount";
            this.dgvUserAccount.ReadOnly = true;
            this.dgvUserAccount.RowHeadersWidth = 62;
            this.dgvUserAccount.Size = new System.Drawing.Size(1716, 832);
            this.dgvUserAccount.TabIndex = 0;
            this.dgvUserAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserAccount_CellDoubleClick);
            // 
            // cmsUserAccountContext
            // 
            this.cmsUserAccountContext.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsUserAccountContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsUserAccountContext.Name = "cmsUserAccountContext";
            this.cmsUserAccountContext.Size = new System.Drawing.Size(143, 68);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::FleetManagment.Properties.Resources.Actions_document_edit_icon;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::FleetManagment.Properties.Resources.Button_Delete_icon;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // userAccountBindingSource
            // 
            this.userAccountBindingSource.DataSource = typeof(FleetManagment.BO.UserAccount);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddUser,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(36, 82);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbAddUser
            // 
            this.tsbAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddUser.Image = global::FleetManagment.Properties.Resources.user_add_icon;
            this.tsbAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddUser.Name = "tsbAddUser";
            this.tsbAddUser.Size = new System.Drawing.Size(33, 28);
            this.tsbAddUser.Text = "toolStripButton1";
            this.tsbAddUser.Click += new System.EventHandler(this.tsbAddUser_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::FleetManagment.Properties.Resources.Button_Refresh_icon;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(33, 28);
            this.tsbDelete.Text = "toolStripButton1";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
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
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 8;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 150;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // roleIdDataGridViewTextBoxColumn
            // 
            this.roleIdDataGridViewTextBoxColumn.DataPropertyName = "RoleId";
            this.roleIdDataGridViewTextBoxColumn.HeaderText = "RoleId";
            this.roleIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
            this.roleIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "RoleName";
            this.RoleName.MinimumWidth = 8;
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Width = 150;
            // 
            // insertByDataGridViewTextBoxColumn
            // 
            this.insertByDataGridViewTextBoxColumn.DataPropertyName = "InsertBy";
            this.insertByDataGridViewTextBoxColumn.HeaderText = "InsertBy";
            this.insertByDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.insertByDataGridViewTextBoxColumn.Name = "insertByDataGridViewTextBoxColumn";
            this.insertByDataGridViewTextBoxColumn.ReadOnly = true;
            this.insertByDataGridViewTextBoxColumn.Width = 150;
            // 
            // insDateDataGridViewTextBoxColumn
            // 
            this.insDateDataGridViewTextBoxColumn.DataPropertyName = "InsDate";
            this.insDateDataGridViewTextBoxColumn.HeaderText = "InsDate";
            this.insDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.insDateDataGridViewTextBoxColumn.Name = "insDateDataGridViewTextBoxColumn";
            this.insDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.insDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // updateByDataGridViewTextBoxColumn
            // 
            this.updateByDataGridViewTextBoxColumn.DataPropertyName = "UpdateBy";
            this.updateByDataGridViewTextBoxColumn.HeaderText = "UpdateBy";
            this.updateByDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.updateByDataGridViewTextBoxColumn.Name = "updateByDataGridViewTextBoxColumn";
            this.updateByDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateByDataGridViewTextBoxColumn.Width = 150;
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            this.updateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.HeaderText = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            this.updateDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // updateNoDataGridViewTextBoxColumn
            // 
            this.updateNoDataGridViewTextBoxColumn.DataPropertyName = "UpdateNo";
            this.updateNoDataGridViewTextBoxColumn.HeaderText = "UpdateNo";
            this.updateNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.updateNoDataGridViewTextBoxColumn.Name = "updateNoDataGridViewTextBoxColumn";
            this.updateNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 832);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserListForm";
            this.Text = "UserListForm";
            this.Activated += new System.EventHandler(this.UserListForm_Activated);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccount)).EndInit();
            this.cmsUserAccountContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dgvUserAccount;
        private System.Windows.Forms.BindingSource userAccountBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddUser;
        private System.Windows.Forms.ContextMenuStrip cmsUserAccountContext;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateNoDataGridViewTextBoxColumn;
    }
}