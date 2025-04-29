namespace Bookaroom
{
    partial class CreateReservationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.savechangesbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usercomboBox = new System.Windows.Forms.ComboBox();
            this.seatcomboBox = new System.Windows.Forms.ComboBox();
            this.eventcomboBox = new System.Windows.Forms.ComboBox();
            this.activecheckbox = new System.Windows.Forms.CheckBox();
            this.eventdatagridview = new System.Windows.Forms.DataGridView();
            this.id_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aforament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_inici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(37, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Usuari";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(195)))), ((int)(((byte)(150)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(263, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "CREAR RESERVA";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(237, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 51);
            this.button2.TabIndex = 54;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // savechangesbutton
            // 
            this.savechangesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.savechangesbutton.ForeColor = System.Drawing.Color.White;
            this.savechangesbutton.Location = new System.Drawing.Point(39, 337);
            this.savechangesbutton.Name = "savechangesbutton";
            this.savechangesbutton.Size = new System.Drawing.Size(159, 51);
            this.savechangesbutton.TabIndex = 53;
            this.savechangesbutton.Text = "CREAR RESERVA";
            this.savechangesbutton.UseVisualStyleBackColor = false;
            this.savechangesbutton.Click += new System.EventHandler(this.savechangesbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(37, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Esdeveniment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(37, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Butaca";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Bookaroom.Properties.Resources.Title_create;
            this.pictureBox2.Location = new System.Drawing.Point(172, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 80);
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Bookaroom.Properties.Resources.Create_Background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 421);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // usercomboBox
            // 
            this.usercomboBox.FormattingEnabled = true;
            this.usercomboBox.Location = new System.Drawing.Point(40, 114);
            this.usercomboBox.Name = "usercomboBox";
            this.usercomboBox.Size = new System.Drawing.Size(358, 21);
            this.usercomboBox.TabIndex = 58;
            // 
            // seatcomboBox
            // 
            this.seatcomboBox.FormattingEnabled = true;
            this.seatcomboBox.Location = new System.Drawing.Point(39, 248);
            this.seatcomboBox.Name = "seatcomboBox";
            this.seatcomboBox.Size = new System.Drawing.Size(357, 21);
            this.seatcomboBox.TabIndex = 59;
            this.seatcomboBox.SelectedIndexChanged += new System.EventHandler(this.seatcomboBox_SelectedIndexChanged);
            // 
            // eventcomboBox
            // 
            this.eventcomboBox.FormattingEnabled = true;
            this.eventcomboBox.Location = new System.Drawing.Point(39, 178);
            this.eventcomboBox.Name = "eventcomboBox";
            this.eventcomboBox.Size = new System.Drawing.Size(357, 21);
            this.eventcomboBox.TabIndex = 60;
            this.eventcomboBox.SelectedIndexChanged += new System.EventHandler(this.eventcomboBox_SelectedIndexChanged);
            // 
            // activecheckbox
            // 
            this.activecheckbox.AutoSize = true;
            this.activecheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.activecheckbox.Location = new System.Drawing.Point(40, 301);
            this.activecheckbox.Name = "activecheckbox";
            this.activecheckbox.Size = new System.Drawing.Size(50, 17);
            this.activecheckbox.TabIndex = 61;
            this.activecheckbox.Text = "Actiu";
            this.activecheckbox.UseVisualStyleBackColor = false;
            // 
            // eventdatagridview
            // 
            this.eventdatagridview.AllowUserToAddRows = false;
            this.eventdatagridview.AllowUserToDeleteRows = false;
            this.eventdatagridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.eventdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventdatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_event,
            this.id_sala,
            this.id_usuari,
            this.nom,
            this.descripcio,
            this.aforament,
            this.data_inici,
            this.data_fi,
            this.preu});
            this.eventdatagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.eventdatagridview.Location = new System.Drawing.Point(499, 12);
            this.eventdatagridview.Name = "eventdatagridview";
            this.eventdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventdatagridview.Size = new System.Drawing.Size(579, 443);
            this.eventdatagridview.TabIndex = 62;
            // 
            // id_event
            // 
            this.id_event.HeaderText = "ID_event";
            this.id_event.Name = "id_event";
            this.id_event.ReadOnly = true;
            this.id_event.Visible = false;
            // 
            // id_sala
            // 
            this.id_sala.HeaderText = "Numero Sala";
            this.id_sala.Name = "id_sala";
            this.id_sala.ReadOnly = true;
            this.id_sala.Visible = false;
            // 
            // id_usuari
            // 
            this.id_usuari.HeaderText = "Usuario asignado";
            this.id_usuari.Name = "id_usuari";
            this.id_usuari.ReadOnly = true;
            this.id_usuari.Visible = false;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom Event";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // descripcio
            // 
            this.descripcio.HeaderText = "Descripció";
            this.descripcio.Name = "descripcio";
            this.descripcio.ReadOnly = true;
            // 
            // aforament
            // 
            this.aforament.HeaderText = "Aforament";
            this.aforament.Name = "aforament";
            this.aforament.ReadOnly = true;
            // 
            // data_inici
            // 
            this.data_inici.HeaderText = "Data Inici";
            this.data_inici.Name = "data_inici";
            this.data_inici.ReadOnly = true;
            // 
            // data_fi
            // 
            this.data_fi.HeaderText = "Data fi";
            this.data_fi.Name = "data_fi";
            this.data_fi.ReadOnly = true;
            // 
            // preu
            // 
            this.preu.HeaderText = "Preu";
            this.preu.Name = "preu";
            this.preu.ReadOnly = true;
            // 
            // CreateReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1090, 464);
            this.Controls.Add(this.eventdatagridview);
            this.Controls.Add(this.activecheckbox);
            this.Controls.Add(this.eventcomboBox);
            this.Controls.Add(this.seatcomboBox);
            this.Controls.Add(this.usercomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.savechangesbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateReservationForm";
            this.Text = "CreateReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button savechangesbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox usercomboBox;
        private System.Windows.Forms.ComboBox seatcomboBox;
        private System.Windows.Forms.ComboBox eventcomboBox;
        private System.Windows.Forms.CheckBox activecheckbox;
        private System.Windows.Forms.DataGridView eventdatagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_event;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuari;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn aforament;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_inici;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn preu;
    }
}