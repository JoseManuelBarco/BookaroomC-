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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.edituserbutton = new System.Windows.Forms.Button();
            this.desactivateuserbutton = new System.Windows.Forms.Button();
            this.createuserButton = new System.Windows.Forms.Button();
            this.userdataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closesessionLabel = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.id_usuari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.Location = new System.Drawing.Point(706, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 41);
            this.label4.TabIndex = 41;
            this.label4.Text = "FILTRO 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.Location = new System.Drawing.Point(706, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 44);
            this.label3.TabIndex = 40;
            this.label3.Text = "FILTRO 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(702, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 47);
            this.label2.TabIndex = 39;
            this.label2.Text = "FILTRO 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(86)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(768, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "FILTROS";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImage = global::Bookaroom.Properties.Resources.filtros_background;
            this.pictureBox5.Location = new System.Drawing.Point(702, 91);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(211, 204);
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // edituserbutton
            // 
            this.edituserbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.edituserbutton.ForeColor = System.Drawing.Color.White;
            this.edituserbutton.Location = new System.Drawing.Point(722, 447);
            this.edituserbutton.Name = "edituserbutton";
            this.edituserbutton.Size = new System.Drawing.Size(175, 50);
            this.edituserbutton.TabIndex = 36;
            this.edituserbutton.Text = "EDITAR USUARIO";
            this.edituserbutton.UseVisualStyleBackColor = false;
            this.edituserbutton.Click += new System.EventHandler(this.edituserbutton_Click);
            // 
            // desactivateuserbutton
            // 
            this.desactivateuserbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.desactivateuserbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.desactivateuserbutton.Location = new System.Drawing.Point(722, 382);
            this.desactivateuserbutton.Name = "desactivateuserbutton";
            this.desactivateuserbutton.Size = new System.Drawing.Size(175, 50);
            this.desactivateuserbutton.TabIndex = 35;
            this.desactivateuserbutton.Text = "DESACTIVAR USUARIO";
            this.desactivateuserbutton.UseVisualStyleBackColor = false;
            this.desactivateuserbutton.Click += new System.EventHandler(this.desactivateuserbutton_Click);
            // 
            // createuserButton
            // 
            this.createuserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.createuserButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createuserButton.ForeColor = System.Drawing.Color.White;
            this.createuserButton.Location = new System.Drawing.Point(722, 317);
            this.createuserButton.Name = "createuserButton";
            this.createuserButton.Size = new System.Drawing.Size(175, 50);
            this.createuserButton.TabIndex = 34;
            this.createuserButton.Text = "CREAR USUARIO";
            this.createuserButton.UseVisualStyleBackColor = false;
            this.createuserButton.Click += new System.EventHandler(this.createuserButton_Click);
            // 
            // userdataGridView
            // 
            this.userdataGridView.AllowUserToAddRows = false;
            this.userdataGridView.AllowUserToDeleteRows = false;
            this.userdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.userdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuari,
            this.nom,
            this.cognom,
            this.email,
            this.rol,
            this.actiu});
            this.userdataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.userdataGridView.Location = new System.Drawing.Point(36, 76);
            this.userdataGridView.MultiSelect = false;
            this.userdataGridView.Name = "userdataGridView";
            this.userdataGridView.ReadOnly = true;
            this.userdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userdataGridView.Size = new System.Drawing.Size(579, 443);
            this.userdataGridView.TabIndex = 33;
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
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.closesessionLabel});
            this.toolStrip1.Location = new System.Drawing.Point(9, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 35);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 32);
            this.toolStripLabel1.Text = "ACCIONES";
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
            // id_usuari
            // 
            this.id_usuari.HeaderText = "Id_usuari";
            this.id_usuari.Name = "id_usuari";
            this.id_usuari.ReadOnly = true;
            this.id_usuari.Visible = false;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // cognom
            // 
            this.cognom.HeaderText = "Cognom";
            this.cognom.Name = "cognom";
            this.cognom.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // actiu
            // 
            this.actiu.HeaderText = "Actiu";
            this.actiu.Name = "actiu";
            this.actiu.ReadOnly = true;
            // 
            // UserTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.edituserbutton);
            this.Controls.Add(this.desactivateuserbutton);
            this.Controls.Add(this.createuserButton);
            this.Controls.Add(this.userdataGridView);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UserTable";
            this.Text = "UserTable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button edituserbutton;
        private System.Windows.Forms.Button desactivateuserbutton;
        private System.Windows.Forms.Button createuserButton;
        private System.Windows.Forms.DataGridView userdataGridView;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel closesessionLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuari;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognom;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn actiu;
    }
}