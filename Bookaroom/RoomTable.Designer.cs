namespace Bookaroom
{
    partial class RoomTable
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
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.room_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxcapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numseatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceRooms = new System.Windows.Forms.BindingSource(this.components);
            this.editroomsbutton = new System.Windows.Forms.Button();
            this.desactivateroomsbutton = new System.Windows.Forms.Button();
            this.createroomsButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gestionarEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closesessionLabel = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.seeinactiveradioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.seeactiveradioButton = new System.Windows.Forms.RadioButton();
            this.seeallradioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AllowUserToOrderColumns = true;
            this.dataGridViewRooms.AutoGenerateColumns = false;
            this.dataGridViewRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.room_id,
            this.inventory_id,
            this.dimensions,
            this.maxcapacity,
            this.numseatsDataGridViewTextBoxColumn,
            this.status});
            this.dataGridViewRooms.DataSource = this.bindingSourceRooms;
            this.dataGridViewRooms.Location = new System.Drawing.Point(43, 72);
            this.dataGridViewRooms.MultiSelect = false;
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRooms.Size = new System.Drawing.Size(571, 447);
            this.dataGridViewRooms.TabIndex = 1;
            // 
            // room_id
            // 
            this.room_id.DataPropertyName = "room_id";
            this.room_id.HeaderText = "Sala";
            this.room_id.Name = "room_id";
            this.room_id.ReadOnly = true;
            // 
            // inventory_id
            // 
            this.inventory_id.DataPropertyName = "inventory_id";
            this.inventory_id.HeaderText = "inventory_id";
            this.inventory_id.Name = "inventory_id";
            this.inventory_id.ReadOnly = true;
            this.inventory_id.Visible = false;
            // 
            // dimensions
            // 
            this.dimensions.DataPropertyName = "dimensions";
            this.dimensions.HeaderText = "Dimensiones";
            this.dimensions.Name = "dimensions";
            this.dimensions.ReadOnly = true;
            // 
            // maxcapacity
            // 
            this.maxcapacity.DataPropertyName = "max_capacity";
            this.maxcapacity.HeaderText = "Capacidad Maxima";
            this.maxcapacity.Name = "maxcapacity";
            this.maxcapacity.ReadOnly = true;
            // 
            // numseatsDataGridViewTextBoxColumn
            // 
            this.numseatsDataGridViewTextBoxColumn.DataPropertyName = "num_seats";
            this.numseatsDataGridViewTextBoxColumn.HeaderText = "Nº Asientos";
            this.numseatsDataGridViewTextBoxColumn.Name = "numseatsDataGridViewTextBoxColumn";
            this.numseatsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Estatus";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // bindingSourceRooms
            // 
            this.bindingSourceRooms.DataSource = typeof(Bookaroom.Models.Sales);
            // 
            // editroomsbutton
            // 
            this.editroomsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.editroomsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.editroomsbutton.ForeColor = System.Drawing.Color.White;
            this.editroomsbutton.Location = new System.Drawing.Point(693, 284);
            this.editroomsbutton.Name = "editroomsbutton";
            this.editroomsbutton.Size = new System.Drawing.Size(235, 77);
            this.editroomsbutton.TabIndex = 4;
            this.editroomsbutton.Text = "EDITAR SALAS";
            this.editroomsbutton.UseVisualStyleBackColor = false;
            this.editroomsbutton.Click += new System.EventHandler(this.editroomsbutton_Click);
            // 
            // desactivateroomsbutton
            // 
            this.desactivateroomsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.desactivateroomsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.desactivateroomsbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.desactivateroomsbutton.Location = new System.Drawing.Point(693, 191);
            this.desactivateroomsbutton.Name = "desactivateroomsbutton";
            this.desactivateroomsbutton.Size = new System.Drawing.Size(235, 81);
            this.desactivateroomsbutton.TabIndex = 3;
            this.desactivateroomsbutton.Text = "ACTIVAR/DESACTIVAR SALAS";
            this.desactivateroomsbutton.UseVisualStyleBackColor = false;
            this.desactivateroomsbutton.Click += new System.EventHandler(this.desactivateroomsbutton_Click);
            // 
            // createroomsButton
            // 
            this.createroomsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.createroomsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createroomsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createroomsButton.ForeColor = System.Drawing.Color.White;
            this.createroomsButton.Location = new System.Drawing.Point(693, 101);
            this.createroomsButton.Name = "createroomsButton";
            this.createroomsButton.Size = new System.Drawing.Size(235, 75);
            this.createroomsButton.TabIndex = 2;
            this.createroomsButton.Text = "CREAR SALAS";
            this.createroomsButton.UseVisualStyleBackColor = false;
            this.createroomsButton.Click += new System.EventHandler(this.createroomsButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(28, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(601, 466);
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(668, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 466);
            this.pictureBox1.TabIndex = 49;
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
            this.toolStrip1.Location = new System.Drawing.Point(12, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarEventsToolStripMenuItem,
            this.gestionarReservasToolStripMenuItem,
            this.gestionarUsuariosToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Bookaroom.Properties.Resources.bookaroom_ic;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 32);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // gestionarEventsToolStripMenuItem
            // 
            this.gestionarEventsToolStripMenuItem.Name = "gestionarEventsToolStripMenuItem";
            this.gestionarEventsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionarEventsToolStripMenuItem.Text = "Gestionar Events";
            this.gestionarEventsToolStripMenuItem.Click += new System.EventHandler(this.gestionarEventsToolStripMenuItem_Click);
            // 
            // gestionarReservasToolStripMenuItem
            // 
            this.gestionarReservasToolStripMenuItem.Name = "gestionarReservasToolStripMenuItem";
            this.gestionarReservasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionarReservasToolStripMenuItem.Text = "Gestionar Reservas";
            this.gestionarReservasToolStripMenuItem.Click += new System.EventHandler(this.gestionarReservasToolStripMenuItem_Click);
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            this.gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            this.gestionarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            this.gestionarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionarUsuariosToolStripMenuItem_Click);
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
            this.pictureBox2.Location = new System.Drawing.Point(12, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(963, 519);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // seeinactiveradioButton
            // 
            this.seeinactiveradioButton.AutoSize = true;
            this.seeinactiveradioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.seeinactiveradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seeinactiveradioButton.ForeColor = System.Drawing.Color.White;
            this.seeinactiveradioButton.Location = new System.Drawing.Point(711, 444);
            this.seeinactiveradioButton.Name = "seeinactiveradioButton";
            this.seeinactiveradioButton.Size = new System.Drawing.Size(107, 21);
            this.seeinactiveradioButton.TabIndex = 7;
            this.seeinactiveradioButton.TabStop = true;
            this.seeinactiveradioButton.Text = "Ver Inactivos";
            this.seeinactiveradioButton.UseVisualStyleBackColor = false;
            this.seeinactiveradioButton.CheckedChanged += new System.EventHandler(this.seeinactiveradioButton_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(693, 392);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 112);
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            // 
            // seeactiveradioButton
            // 
            this.seeactiveradioButton.AutoSize = true;
            this.seeactiveradioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.seeactiveradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seeactiveradioButton.ForeColor = System.Drawing.Color.White;
            this.seeactiveradioButton.Location = new System.Drawing.Point(711, 417);
            this.seeactiveradioButton.Name = "seeactiveradioButton";
            this.seeactiveradioButton.Size = new System.Drawing.Size(96, 21);
            this.seeactiveradioButton.TabIndex = 6;
            this.seeactiveradioButton.TabStop = true;
            this.seeactiveradioButton.Text = "Ver activos";
            this.seeactiveradioButton.UseVisualStyleBackColor = false;
            this.seeactiveradioButton.CheckedChanged += new System.EventHandler(this.seeactiveradioButton_CheckedChanged);
            // 
            // seeallradioButton
            // 
            this.seeallradioButton.AutoSize = true;
            this.seeallradioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.seeallradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seeallradioButton.ForeColor = System.Drawing.Color.White;
            this.seeallradioButton.Location = new System.Drawing.Point(711, 471);
            this.seeallradioButton.Name = "seeallradioButton";
            this.seeallradioButton.Size = new System.Drawing.Size(92, 21);
            this.seeallradioButton.TabIndex = 8;
            this.seeallradioButton.TabStop = true;
            this.seeallradioButton.Text = "Ver Todos";
            this.seeallradioButton.UseVisualStyleBackColor = false;
            this.seeallradioButton.CheckedChanged += new System.EventHandler(this.seeallradioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(765, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "FILTROS";
            // 
            // RoomTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1007, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seeallradioButton);
            this.Controls.Add(this.seeactiveradioButton);
            this.Controls.Add(this.seeinactiveradioButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dataGridViewRooms);
            this.Controls.Add(this.editroomsbutton);
            this.Controls.Add(this.desactivateroomsbutton);
            this.Controls.Add(this.createroomsButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "RoomTable";
            this.Text = "RoomTable";
            this.Load += new System.EventHandler(this.RoomTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Button editroomsbutton;
        private System.Windows.Forms.Button desactivateroomsbutton;
        private System.Windows.Forms.Button createroomsButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem gestionarEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel closesessionLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource bindingSourceRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxcapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn numseatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private System.Windows.Forms.RadioButton seeinactiveradioButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton seeactiveradioButton;
        private System.Windows.Forms.RadioButton seeallradioButton;
        private System.Windows.Forms.Label label1;
    }
}