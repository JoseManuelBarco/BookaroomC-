namespace Bookaroom
{
    partial class UserTable
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.edituserbutton = new System.Windows.Forms.Button();
            this.desactivateuserbutton = new System.Windows.Forms.Button();
            this.createuserButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gestionarEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closesessionLabel = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.seeactiveradioButton = new System.Windows.Forms.RadioButton();
            this.seeinactiveradioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.seeallradioButton = new System.Windows.Forms.RadioButton();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            this.gestionarSalasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(762, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "FILTROS";
            // 
            // edituserbutton
            // 
            this.edituserbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.edituserbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.edituserbutton.ForeColor = System.Drawing.Color.White;
            this.edituserbutton.Location = new System.Drawing.Point(690, 285);
            this.edituserbutton.Name = "edituserbutton";
            this.edituserbutton.Size = new System.Drawing.Size(235, 77);
            this.edituserbutton.TabIndex = 36;
            this.edituserbutton.Text = "EDITAR USUARIO";
            this.edituserbutton.UseVisualStyleBackColor = false;
            this.edituserbutton.Click += new System.EventHandler(this.edituserbutton_Click);
            // 
            // desactivateuserbutton
            // 
            this.desactivateuserbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.desactivateuserbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.desactivateuserbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.desactivateuserbutton.Location = new System.Drawing.Point(690, 192);
            this.desactivateuserbutton.Name = "desactivateuserbutton";
            this.desactivateuserbutton.Size = new System.Drawing.Size(235, 81);
            this.desactivateuserbutton.TabIndex = 35;
            this.desactivateuserbutton.Text = "ACTIVAR/DESACTIVAR USUARIO";
            this.desactivateuserbutton.UseVisualStyleBackColor = false;
            this.desactivateuserbutton.Click += new System.EventHandler(this.desactivateuserbutton_Click);
            // 
            // createuserButton
            // 
            this.createuserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.createuserButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createuserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createuserButton.ForeColor = System.Drawing.Color.White;
            this.createuserButton.Location = new System.Drawing.Point(690, 102);
            this.createuserButton.Name = "createuserButton";
            this.createuserButton.Size = new System.Drawing.Size(235, 75);
            this.createuserButton.TabIndex = 34;
            this.createuserButton.Text = "CREAR USUARIO";
            this.createuserButton.UseVisualStyleBackColor = false;
            this.createuserButton.Click += new System.EventHandler(this.createuserButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(25, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(601, 466);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(665, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 466);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.closesessionLabel});
            this.toolStrip1.Location = new System.Drawing.Point(9, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 35);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarEventsToolStripMenuItem,
            this.gestionarReservasToolStripMenuItem,
            this.gestionarSalasToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Bookaroom.Properties.Resources.bookaroom_ic;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 32);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // gestionarEventsToolStripMenuItem
            // 
            this.gestionarEventsToolStripMenuItem.Name = "gestionarEventsToolStripMenuItem";
            this.gestionarEventsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarEventsToolStripMenuItem.Text = "Gestionar Events";
            this.gestionarEventsToolStripMenuItem.Click += new System.EventHandler(this.gestionarEventsToolStripMenuItem_Click);
            // 
            // gestionarReservasToolStripMenuItem
            // 
            this.gestionarReservasToolStripMenuItem.Name = "gestionarReservasToolStripMenuItem";
            this.gestionarReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarReservasToolStripMenuItem.Text = "Gestionar Reservas";
            this.gestionarReservasToolStripMenuItem.Click += new System.EventHandler(this.gestionarReservasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // closesessionLabel
            // 
            this.closesessionLabel.Name = "closesessionLabel";
            this.closesessionLabel.Size = new System.Drawing.Size(92, 32);
            this.closesessionLabel.Text = "CERRAR SESIÓN";
            this.closesessionLabel.Click += new System.EventHandler(this.closesessionLabel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.pictureBox2.Location = new System.Drawing.Point(9, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(963, 519);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.name,
            this.surnames,
            this.email,
            this.role,
            this.active});
            this.dataGridViewUsers.DataSource = this.bindingSourceUsers;
            this.dataGridViewUsers.Location = new System.Drawing.Point(40, 73);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(571, 447);
            this.dataGridViewUsers.TabIndex = 42;
            // 
            // seeactiveradioButton
            // 
            this.seeactiveradioButton.AutoSize = true;
            this.seeactiveradioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.seeactiveradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seeactiveradioButton.ForeColor = System.Drawing.Color.White;
            this.seeactiveradioButton.Location = new System.Drawing.Point(708, 418);
            this.seeactiveradioButton.Name = "seeactiveradioButton";
            this.seeactiveradioButton.Size = new System.Drawing.Size(96, 21);
            this.seeactiveradioButton.TabIndex = 43;
            this.seeactiveradioButton.TabStop = true;
            this.seeactiveradioButton.Text = "Ver activos";
            this.seeactiveradioButton.UseVisualStyleBackColor = false;
            this.seeactiveradioButton.CheckedChanged += new System.EventHandler(this.seeactiveradioButton_CheckedChanged);
            // 
            // seeinactiveradioButton
            // 
            this.seeinactiveradioButton.AutoSize = true;
            this.seeinactiveradioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.seeinactiveradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seeinactiveradioButton.ForeColor = System.Drawing.Color.White;
            this.seeinactiveradioButton.Location = new System.Drawing.Point(708, 445);
            this.seeinactiveradioButton.Name = "seeinactiveradioButton";
            this.seeinactiveradioButton.Size = new System.Drawing.Size(107, 21);
            this.seeinactiveradioButton.TabIndex = 44;
            this.seeinactiveradioButton.TabStop = true;
            this.seeinactiveradioButton.Text = "Ver Inactivos";
            this.seeinactiveradioButton.UseVisualStyleBackColor = false;
            this.seeinactiveradioButton.CheckedChanged += new System.EventHandler(this.seeinactiveradioButton_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(690, 393);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 112);
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // seeallradioButton
            // 
            this.seeallradioButton.AutoSize = true;
            this.seeallradioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.seeallradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seeallradioButton.ForeColor = System.Drawing.Color.White;
            this.seeallradioButton.Location = new System.Drawing.Point(708, 472);
            this.seeallradioButton.Name = "seeallradioButton";
            this.seeallradioButton.Size = new System.Drawing.Size(92, 21);
            this.seeallradioButton.TabIndex = 46;
            this.seeallradioButton.TabStop = true;
            this.seeallradioButton.Text = "Ver Todos";
            this.seeallradioButton.UseVisualStyleBackColor = false;
            this.seeallradioButton.CheckedChanged += new System.EventHandler(this.seeallradioButton_CheckedChanged);
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user_id";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // surnames
            // 
            this.surnames.DataPropertyName = "surname";
            this.surnames.HeaderText = "Apellidos";
            this.surnames.Name = "surnames";
            this.surnames.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Correo";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Rol";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // active
            // 
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "Actiu";
            this.active.Name = "active";
            this.active.ReadOnly = true;
            // 
            // bindingSourceUsers
            // 
            this.bindingSourceUsers.DataSource = typeof(Bookaroom.Models.Usuaris);
            // 
            // gestionarSalasToolStripMenuItem
            // 
            this.gestionarSalasToolStripMenuItem.Name = "gestionarSalasToolStripMenuItem";
            this.gestionarSalasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarSalasToolStripMenuItem.Text = "Gestionar Salas";
            this.gestionarSalasToolStripMenuItem.Click += new System.EventHandler(this.gestionarSalasToolStripMenuItem_Click);
            // 
            // UserTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(988, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seeallradioButton);
            this.Controls.Add(this.seeactiveradioButton);
            this.Controls.Add(this.seeinactiveradioButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.edituserbutton);
            this.Controls.Add(this.desactivateuserbutton);
            this.Controls.Add(this.createuserButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UserTable";
            this.Text = "UserTable";
            this.Load += new System.EventHandler(this.UserTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edituserbutton;
        private System.Windows.Forms.Button desactivateuserbutton;
        private System.Windows.Forms.Button createuserButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel closesessionLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem gestionarEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarReservasToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSourceUsers;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.RadioButton seeactiveradioButton;
        private System.Windows.Forms.RadioButton seeinactiveradioButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton seeallradioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnames;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn active;
        private System.Windows.Forms.ToolStripMenuItem gestionarSalasToolStripMenuItem;
    }
}