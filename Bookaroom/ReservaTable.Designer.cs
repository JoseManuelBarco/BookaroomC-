namespace Bookaroom
{
    partial class ReservaTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservaTable));
            this.filterdateendlabel = new System.Windows.Forms.Label();
            this.filterdateinilabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editreservationbutton = new System.Windows.Forms.Button();
            this.desactivatereservationbutton = new System.Windows.Forms.Button();
            this.createreservationbutton = new System.Windows.Forms.Button();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.id_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_esdeveniment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_butaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gestionarUsuarisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closesessiontoolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userfilterbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seeUserFilterButton = new System.Windows.Forms.Button();
            this.resetpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // filterdateendlabel
            // 
            this.filterdateendlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.filterdateendlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.filterdateendlabel.Location = new System.Drawing.Point(706, 197);
            this.filterdateendlabel.Name = "filterdateendlabel";
            this.filterdateendlabel.Size = new System.Drawing.Size(207, 44);
            this.filterdateendlabel.TabIndex = 40;
            this.filterdateendlabel.Text = "VER USUARIO ESPECIFICO";
            this.filterdateendlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterdateinilabel
            // 
            this.filterdateinilabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.filterdateinilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.filterdateinilabel.Location = new System.Drawing.Point(702, 144);
            this.filterdateinilabel.Name = "filterdateinilabel";
            this.filterdateinilabel.Size = new System.Drawing.Size(211, 47);
            this.filterdateinilabel.TabIndex = 39;
            this.filterdateinilabel.Text = "VER/QUITAR DATOS BUTACA";
            this.filterdateinilabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterdateinilabel.Click += new System.EventHandler(this.filterdateinilabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(86)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(741, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "FILTROS";
            // 
            // editreservationbutton
            // 
            this.editreservationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.editreservationbutton.ForeColor = System.Drawing.Color.White;
            this.editreservationbutton.Location = new System.Drawing.Point(722, 447);
            this.editreservationbutton.Name = "editreservationbutton";
            this.editreservationbutton.Size = new System.Drawing.Size(175, 50);
            this.editreservationbutton.TabIndex = 36;
            this.editreservationbutton.Text = "EDITAR RESERVA";
            this.editreservationbutton.UseVisualStyleBackColor = false;
            this.editreservationbutton.Click += new System.EventHandler(this.editreservationbutton_Click);
            // 
            // desactivatereservationbutton
            // 
            this.desactivatereservationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.desactivatereservationbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.desactivatereservationbutton.Location = new System.Drawing.Point(722, 382);
            this.desactivatereservationbutton.Name = "desactivatereservationbutton";
            this.desactivatereservationbutton.Size = new System.Drawing.Size(175, 50);
            this.desactivatereservationbutton.TabIndex = 35;
            this.desactivatereservationbutton.Text = "DESACTIVAR RESERVA";
            this.desactivatereservationbutton.UseVisualStyleBackColor = false;
            this.desactivatereservationbutton.Click += new System.EventHandler(this.desactivatereservationbutton_Click);
            // 
            // createreservationbutton
            // 
            this.createreservationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.createreservationbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createreservationbutton.ForeColor = System.Drawing.Color.White;
            this.createreservationbutton.Location = new System.Drawing.Point(722, 317);
            this.createreservationbutton.Name = "createreservationbutton";
            this.createreservationbutton.Size = new System.Drawing.Size(175, 50);
            this.createreservationbutton.TabIndex = 34;
            this.createreservationbutton.Text = "CREAR RESERVA";
            this.createreservationbutton.UseVisualStyleBackColor = false;
            this.createreservationbutton.Click += new System.EventHandler(this.createreservationbutton_Click);
            // 
            // reservationDataGridView
            // 
            this.reservationDataGridView.AllowUserToAddRows = false;
            this.reservationDataGridView.AllowUserToDeleteRows = false;
            this.reservationDataGridView.AllowUserToOrderColumns = true;
            this.reservationDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_entrada,
            this.id_esdeveniment,
            this.id_usuari,
            this.email,
            this.numero_fila,
            this.numero_butaca});
            this.reservationDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.reservationDataGridView.Location = new System.Drawing.Point(36, 76);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationDataGridView.Size = new System.Drawing.Size(579, 443);
            this.reservationDataGridView.TabIndex = 33;
            // 
            // id_entrada
            // 
            this.id_entrada.HeaderText = "ID_entrada";
            this.id_entrada.Name = "id_entrada";
            this.id_entrada.ReadOnly = true;
            this.id_entrada.Visible = false;
            // 
            // id_esdeveniment
            // 
            this.id_esdeveniment.HeaderText = "Nom Esdeveniment";
            this.id_esdeveniment.Name = "id_esdeveniment";
            this.id_esdeveniment.ReadOnly = true;
            // 
            // id_usuari
            // 
            this.id_usuari.HeaderText = "Usuari Assignat";
            this.id_usuari.Name = "id_usuari";
            this.id_usuari.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Correu";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // numero_fila
            // 
            this.numero_fila.HeaderText = "Numero Fila";
            this.numero_fila.Name = "numero_fila";
            this.numero_fila.ReadOnly = true;
            // 
            // numero_butaca
            // 
            this.numero_butaca.HeaderText = "Numero Butaca";
            this.numero_butaca.Name = "numero_butaca";
            this.numero_butaca.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.closesessiontoolStripLabel});
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
            this.gestionarUsuarisToolStripMenuItem,
            this.gestionarEventsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 32);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // gestionarUsuarisToolStripMenuItem
            // 
            this.gestionarUsuarisToolStripMenuItem.Name = "gestionarUsuarisToolStripMenuItem";
            this.gestionarUsuarisToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.gestionarUsuarisToolStripMenuItem.Text = "Gestionar Usuaris";
            this.gestionarUsuarisToolStripMenuItem.Click += new System.EventHandler(this.gestionarUsuarisToolStripMenuItem_Click);
            // 
            // gestionarEventsToolStripMenuItem
            // 
            this.gestionarEventsToolStripMenuItem.Name = "gestionarEventsToolStripMenuItem";
            this.gestionarEventsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.gestionarEventsToolStripMenuItem.Text = "Gestionar Events";
            this.gestionarEventsToolStripMenuItem.Click += new System.EventHandler(this.gestionarEventsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // closesessiontoolStripLabel
            // 
            this.closesessiontoolStripLabel.Name = "closesessiontoolStripLabel";
            this.closesessiontoolStripLabel.Size = new System.Drawing.Size(92, 32);
            this.closesessiontoolStripLabel.Text = "CERRAR SESIÓN";
            this.closesessiontoolStripLabel.Click += new System.EventHandler(this.closesessiontoolStripLabel_Click);
            // 
            // userfilterbox
            // 
            this.userfilterbox.Location = new System.Drawing.Point(709, 260);
            this.userfilterbox.Name = "userfilterbox";
            this.userfilterbox.Size = new System.Drawing.Size(132, 20);
            this.userfilterbox.TabIndex = 41;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // seeUserFilterButton
            // 
            this.seeUserFilterButton.Location = new System.Drawing.Point(847, 257);
            this.seeUserFilterButton.Name = "seeUserFilterButton";
            this.seeUserFilterButton.Size = new System.Drawing.Size(50, 23);
            this.seeUserFilterButton.TabIndex = 43;
            this.seeUserFilterButton.Text = "Ver";
            this.seeUserFilterButton.UseVisualStyleBackColor = true;
            this.seeUserFilterButton.Click += new System.EventHandler(this.seeUserFilterButton_Click);
            // 
            // resetpictureBox
            // 
            this.resetpictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(171)))), ((int)(((byte)(86)))));
            this.resetpictureBox.BackgroundImage = global::Bookaroom.Properties.Resources.reiniciar;
            this.resetpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetpictureBox.Location = new System.Drawing.Point(836, 99);
            this.resetpictureBox.Name = "resetpictureBox";
            this.resetpictureBox.Size = new System.Drawing.Size(39, 37);
            this.resetpictureBox.TabIndex = 44;
            this.resetpictureBox.TabStop = false;
            this.resetpictureBox.Click += new System.EventHandler(this.resetpictureBox_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.pictureBox2.Location = new System.Drawing.Point(9, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(963, 519);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // ReservaTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.resetpictureBox);
            this.Controls.Add(this.seeUserFilterButton);
            this.Controls.Add(this.userfilterbox);
            this.Controls.Add(this.filterdateendlabel);
            this.Controls.Add(this.filterdateinilabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.editreservationbutton);
            this.Controls.Add(this.desactivatereservationbutton);
            this.Controls.Add(this.createreservationbutton);
            this.Controls.Add(this.reservationDataGridView);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ReservaTable";
            this.Text = "ReservaTable";
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label filterdateendlabel;
        private System.Windows.Forms.Label filterdateinilabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button editreservationbutton;
        private System.Windows.Forms.Button desactivatereservationbutton;
        private System.Windows.Forms.Button createreservationbutton;
        private System.Windows.Forms.DataGridView reservationDataGridView;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel closesessiontoolStripLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_esdeveniment;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuari;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_butaca;
        private System.Windows.Forms.TextBox userfilterbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button seeUserFilterButton;
        private System.Windows.Forms.PictureBox resetpictureBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuarisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEventsToolStripMenuItem;
    }
}