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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventTable));
            this.capacityfilterlabel = new System.Windows.Forms.Label();
            this.dateendfilterlabel = new System.Windows.Forms.Label();
            this.dateinifilterlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editeventbutton = new System.Windows.Forms.Button();
            this.desactivateeventbutton = new System.Windows.Forms.Button();
            this.createeventbutton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gestionarUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closesessiontoolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.event_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // capacityfilterlabel
            // 
            this.capacityfilterlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.capacityfilterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.capacityfilterlabel.Location = new System.Drawing.Point(706, 247);
            this.capacityfilterlabel.Name = "capacityfilterlabel";
            this.capacityfilterlabel.Size = new System.Drawing.Size(207, 41);
            this.capacityfilterlabel.TabIndex = 28;
            this.capacityfilterlabel.Text = "VEURE/TREURE AFOR.";
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
            // editeventbutton
            // 
            this.editeventbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.editeventbutton.ForeColor = System.Drawing.Color.White;
            this.editeventbutton.Location = new System.Drawing.Point(722, 447);
            this.editeventbutton.Name = "editeventbutton";
            this.editeventbutton.Size = new System.Drawing.Size(175, 50);
            this.editeventbutton.TabIndex = 23;
            this.editeventbutton.Text = "EDITAR ESDEVENIMENT";
            this.editeventbutton.UseVisualStyleBackColor = false;
            this.editeventbutton.Click += new System.EventHandler(this.editeventbutton_Click);
            // 
            // desactivateeventbutton
            // 
            this.desactivateeventbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.desactivateeventbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.desactivateeventbutton.Location = new System.Drawing.Point(722, 382);
            this.desactivateeventbutton.Name = "desactivateeventbutton";
            this.desactivateeventbutton.Size = new System.Drawing.Size(175, 50);
            this.desactivateeventbutton.TabIndex = 22;
            this.desactivateeventbutton.Text = "DESACTIVAR ESDEVENIMENT";
            this.desactivateeventbutton.UseVisualStyleBackColor = false;
            this.desactivateeventbutton.Click += new System.EventHandler(this.desactivateeventbutton_Click);
            // 
            // createeventbutton
            // 
            this.createeventbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.createeventbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createeventbutton.ForeColor = System.Drawing.Color.White;
            this.createeventbutton.Location = new System.Drawing.Point(722, 317);
            this.createeventbutton.Name = "createeventbutton";
            this.createeventbutton.Size = new System.Drawing.Size(175, 50);
            this.createeventbutton.TabIndex = 21;
            this.createeventbutton.Text = "CREAR ESDEVENIMENT";
            this.createeventbutton.UseVisualStyleBackColor = false;
            this.createeventbutton.Click += new System.EventHandler(this.createeventbutton_Click);
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
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarUserToolStripMenuItem,
            this.gestionarReservasToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 32);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // gestionarUserToolStripMenuItem
            // 
            this.gestionarUserToolStripMenuItem.Name = "gestionarUserToolStripMenuItem";
            this.gestionarUserToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionarUserToolStripMenuItem.Text = "Gestionar Usuaris";
            this.gestionarUserToolStripMenuItem.Click += new System.EventHandler(this.gestionarUserToolStripMenuItem_Click);
            // 
            // gestionarReservasToolStripMenuItem
            // 
            this.gestionarReservasToolStripMenuItem.Name = "gestionarReservasToolStripMenuItem";
            this.gestionarReservasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionarReservasToolStripMenuItem.Text = "Gestionar Reservas";
            this.gestionarReservasToolStripMenuItem.Click += new System.EventHandler(this.gestionarReservasToolStripMenuItem_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.pictureBox2.Location = new System.Drawing.Point(9, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(963, 519);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.event_id,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(39, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(575, 442);
            this.dataGridView1.TabIndex = 29;
            // 
            // event_id
            // 
            this.event_id.DataPropertyName = "event_id";
            this.event_id.HeaderText = "event_id";
            this.event_id.Name = "event_id";
            this.event_id.ReadOnly = true;
            this.event_id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Bookaroom.Models.Esdeveniments);
            // 
            // EventTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(979, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.capacityfilterlabel);
            this.Controls.Add(this.dateendfilterlabel);
            this.Controls.Add(this.dateinifilterlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.editeventbutton);
            this.Controls.Add(this.desactivateeventbutton);
            this.Controls.Add(this.createeventbutton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "EventTable";
            this.Text = "EventTable";
            this.Load += new System.EventHandler(this.EventTable_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label capacityfilterlabel;
        private System.Windows.Forms.Label dateendfilterlabel;
        private System.Windows.Forms.Label dateinifilterlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button editeventbutton;
        private System.Windows.Forms.Button desactivateeventbutton;
        private System.Windows.Forms.Button createeventbutton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel closesessiontoolStripLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem gestionarUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarReservasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
    }
}