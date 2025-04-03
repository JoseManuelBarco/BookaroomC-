namespace Bookaroom
{
    partial class EventTable
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
            this.capacityfilterlabel = new System.Windows.Forms.Label();
            this.dateendfilterlabel = new System.Windows.Forms.Label();
            this.dateinifilterlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eventdatagridview = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.id_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aforament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_inici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventdatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // capacityfilterlabel
            // 
            this.capacityfilterlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.capacityfilterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.capacityfilterlabel.Location = new System.Drawing.Point(706, 247);
            this.capacityfilterlabel.Name = "capacityfilterlabel";
            this.capacityfilterlabel.Size = new System.Drawing.Size(207, 41);
            this.capacityfilterlabel.TabIndex = 28;
            this.capacityfilterlabel.Text = "VEURE/TREURE AFORO";
            this.capacityfilterlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.capacityfilterlabel.Click += new System.EventHandler(this.capacityfilterlabel_Click_1);
            // 
            // dateendfilterlabel
            // 
            this.dateendfilterlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.dateendfilterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.dateendfilterlabel.Location = new System.Drawing.Point(706, 197);
            this.dateendfilterlabel.Name = "dateendfilterlabel";
            this.dateendfilterlabel.Size = new System.Drawing.Size(207, 44);
            this.dateendfilterlabel.TabIndex = 27;
            this.dateendfilterlabel.Text = "VER/TREURE DATA FI";
            this.dateendfilterlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateendfilterlabel.Click += new System.EventHandler(this.dateendfilterlabel_Click);
            // 
            // dateinifilterlabel
            // 
            this.dateinifilterlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.dateinifilterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.dateinifilterlabel.Location = new System.Drawing.Point(702, 144);
            this.dateinifilterlabel.Name = "dateinifilterlabel";
            this.dateinifilterlabel.Size = new System.Drawing.Size(211, 47);
            this.dateinifilterlabel.TabIndex = 26;
            this.dateinifilterlabel.Text = "VER/TREURE DATA INICI";
            this.dateinifilterlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateinifilterlabel.Click += new System.EventHandler(this.dateinifilterlabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(86)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(768, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "FILTROS";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImage = global::Bookaroom.Properties.Resources.filtros_background;
            this.pictureBox5.Location = new System.Drawing.Point(702, 91);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(211, 204);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(722, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 50);
            this.button3.TabIndex = 23;
            this.button3.Text = "EDITAR USUARIO";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(722, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 50);
            this.button2.TabIndex = 22;
            this.button2.Text = "DESACTIVAR USUARIO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(722, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "CREAR USUARIO";
            this.button1.UseVisualStyleBackColor = false;
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
            this.eventdatagridview.Location = new System.Drawing.Point(36, 76);
            this.eventdatagridview.Name = "eventdatagridview";
            this.eventdatagridview.Size = new System.Drawing.Size(579, 443);
            this.eventdatagridview.TabIndex = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(25, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(601, 466);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(665, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 466);
            this.pictureBox1.TabIndex = 18;
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
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(9, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 35);
            this.toolStrip1.TabIndex = 16;
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(92, 32);
            this.toolStripLabel2.Text = "CERRAR SESIÓN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.pictureBox2.Location = new System.Drawing.Point(9, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(963, 519);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
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
            // EventTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.capacityfilterlabel);
            this.Controls.Add(this.dateendfilterlabel);
            this.Controls.Add(this.dateinifilterlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eventdatagridview);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "EventTable";
            this.Text = "EventTable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventdatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label capacityfilterlabel;
        private System.Windows.Forms.Label dateendfilterlabel;
        private System.Windows.Forms.Label dateinifilterlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView eventdatagridview;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
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