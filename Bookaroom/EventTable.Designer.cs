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
            this.editeventbutton = new System.Windows.Forms.Button();
            this.desactivateeventbutton = new System.Windows.Forms.Button();
            this.createeventbutton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gestionarUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closesessiontoolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.eventdataGridView = new System.Windows.Forms.DataGridView();
            this.event_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seedateiniradiocheckBox = new System.Windows.Forms.CheckBox();
            this.seedateendcheckBox = new System.Windows.Forms.CheckBox();
            this.seecapacitycheckBox = new System.Windows.Forms.CheckBox();
            this.gestionarSalasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // editeventbutton
            // 
            this.editeventbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.editeventbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.editeventbutton.ForeColor = System.Drawing.Color.White;
            this.editeventbutton.Location = new System.Drawing.Point(687, 272);
            this.editeventbutton.Name = "editeventbutton";
            this.editeventbutton.Size = new System.Drawing.Size(235, 73);
            this.editeventbutton.TabIndex = 3;
            this.editeventbutton.Text = "EDITAR EVENTO";
            this.editeventbutton.UseVisualStyleBackColor = false;
            this.editeventbutton.Click += new System.EventHandler(this.editeventbutton_Click);
            // 
            // desactivateeventbutton
            // 
            this.desactivateeventbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.desactivateeventbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.desactivateeventbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.desactivateeventbutton.Location = new System.Drawing.Point(687, 183);
            this.desactivateeventbutton.Name = "desactivateeventbutton";
            this.desactivateeventbutton.Size = new System.Drawing.Size(235, 73);
            this.desactivateeventbutton.TabIndex = 2;
            this.desactivateeventbutton.Text = "DESACTIVAR EVENTO";
            this.desactivateeventbutton.UseVisualStyleBackColor = false;
            this.desactivateeventbutton.Click += new System.EventHandler(this.desactivateeventbutton_Click);
            // 
            // createeventbutton
            // 
            this.createeventbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.createeventbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createeventbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createeventbutton.ForeColor = System.Drawing.Color.White;
            this.createeventbutton.Location = new System.Drawing.Point(687, 93);
            this.createeventbutton.Name = "createeventbutton";
            this.createeventbutton.Size = new System.Drawing.Size(235, 73);
            this.createeventbutton.TabIndex = 1;
            this.createeventbutton.Text = "CREAR EVENTO";
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
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarUserToolStripMenuItem,
            this.gestionarReservasToolStripMenuItem,
            this.gestionarSalasToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 32);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // gestionarUserToolStripMenuItem
            // 
            this.gestionarUserToolStripMenuItem.Name = "gestionarUserToolStripMenuItem";
            this.gestionarUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarUserToolStripMenuItem.Text = "Gestionar Usuaris";
            this.gestionarUserToolStripMenuItem.Click += new System.EventHandler(this.gestionarUserToolStripMenuItem_Click);
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
            // closesessiontoolStripLabel
            // 
            this.closesessiontoolStripLabel.Name = "closesessiontoolStripLabel";
            this.closesessiontoolStripLabel.Size = new System.Drawing.Size(92, 32);
            this.closesessiontoolStripLabel.Text = "CERRAR SESIÓN";
            this.closesessiontoolStripLabel.Click += new System.EventHandler(this.closesessiontoolStripLabel_Click);
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
            // eventdataGridView
            // 
            this.eventdataGridView.AllowUserToAddRows = false;
            this.eventdataGridView.AllowUserToDeleteRows = false;
            this.eventdataGridView.AllowUserToOrderColumns = true;
            this.eventdataGridView.AutoGenerateColumns = false;
            this.eventdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.eventdataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.eventdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.event_id,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.capacity,
            this.start_date,
            this.end_date});
            this.eventdataGridView.DataSource = this.bindingSource1;
            this.eventdataGridView.Location = new System.Drawing.Point(39, 77);
            this.eventdataGridView.Name = "eventdataGridView";
            this.eventdataGridView.ReadOnly = true;
            this.eventdataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.eventdataGridView.RowHeadersVisible = false;
            this.eventdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventdataGridView.Size = new System.Drawing.Size(575, 442);
            this.eventdataGridView.TabIndex = 8;
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacity
            // 
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "Capacidad";
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            // 
            // start_date
            // 
            this.start_date.DataPropertyName = "start_date";
            this.start_date.HeaderText = "Fecha de Inicio";
            this.start_date.Name = "start_date";
            this.start_date.ReadOnly = true;
            // 
            // end_date
            // 
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "Fecha de Finalizacion";
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Bookaroom.Models.Esdeveniments);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(687, 376);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 126);
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(754, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "FILTROS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // seedateiniradiocheckBox
            // 
            this.seedateiniradiocheckBox.AutoSize = true;
            this.seedateiniradiocheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.seedateiniradiocheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seedateiniradiocheckBox.ForeColor = System.Drawing.Color.White;
            this.seedateiniradiocheckBox.Location = new System.Drawing.Point(708, 419);
            this.seedateiniradiocheckBox.Name = "seedateiniradiocheckBox";
            this.seedateiniradiocheckBox.Size = new System.Drawing.Size(147, 21);
            this.seedateiniradiocheckBox.TabIndex = 5;
            this.seedateiniradiocheckBox.Text = "Quitar Dia de Inicio";
            this.seedateiniradiocheckBox.UseVisualStyleBackColor = false;
            this.seedateiniradiocheckBox.CheckedChanged += new System.EventHandler(this.seedateiniradiocheckBox_CheckedChanged);
            // 
            // seedateendcheckBox
            // 
            this.seedateendcheckBox.AutoSize = true;
            this.seedateendcheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.seedateendcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seedateendcheckBox.ForeColor = System.Drawing.Color.White;
            this.seedateendcheckBox.Location = new System.Drawing.Point(708, 446);
            this.seedateendcheckBox.Name = "seedateendcheckBox";
            this.seedateendcheckBox.Size = new System.Drawing.Size(189, 21);
            this.seedateendcheckBox.TabIndex = 6;
            this.seedateendcheckBox.Text = "Quitar Dia de Finalizacion";
            this.seedateendcheckBox.UseVisualStyleBackColor = false;
            this.seedateendcheckBox.CheckedChanged += new System.EventHandler(this.seedateendcheckBox_CheckedChanged);
            // 
            // seecapacitycheckBox
            // 
            this.seecapacitycheckBox.AutoSize = true;
            this.seecapacitycheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.seecapacitycheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seecapacitycheckBox.ForeColor = System.Drawing.Color.White;
            this.seecapacitycheckBox.Location = new System.Drawing.Point(708, 473);
            this.seecapacitycheckBox.Name = "seecapacitycheckBox";
            this.seecapacitycheckBox.Size = new System.Drawing.Size(104, 21);
            this.seecapacitycheckBox.TabIndex = 7;
            this.seecapacitycheckBox.Text = "Quitar Aforo";
            this.seecapacitycheckBox.UseVisualStyleBackColor = false;
            this.seecapacitycheckBox.CheckedChanged += new System.EventHandler(this.seecapacitycheckBox_CheckedChanged);
            // 
            // gestionarSalasToolStripMenuItem
            // 
            this.gestionarSalasToolStripMenuItem.Name = "gestionarSalasToolStripMenuItem";
            this.gestionarSalasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarSalasToolStripMenuItem.Text = "Gestionar Salas";
            this.gestionarSalasToolStripMenuItem.Click += new System.EventHandler(this.gestionarSalasToolStripMenuItem_Click);
            // 
            // EventTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(989, 561);
            this.Controls.Add(this.seecapacitycheckBox);
            this.Controls.Add(this.seedateendcheckBox);
            this.Controls.Add(this.seedateiniradiocheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.eventdataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView eventdataGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox seedateiniradiocheckBox;
        private System.Windows.Forms.CheckBox seedateendcheckBox;
        private System.Windows.Forms.CheckBox seecapacitycheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.ToolStripMenuItem gestionarSalasToolStripMenuItem;
    }
}