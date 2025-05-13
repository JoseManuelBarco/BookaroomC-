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
            this.label1 = new System.Windows.Forms.Label();
            this.editreservationbutton = new System.Windows.Forms.Button();
            this.desactivatereservationbutton = new System.Windows.Forms.Button();
            this.createreservationbutton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gestionarUsuarisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarSalasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closesessiontoolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userfilterbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seeUserFilterButton = new System.Windows.Forms.Button();
            this.resetpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ticketsdataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSourceTickets = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seeseatsinforadiocheckBox = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(761, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "FILTROS";
            // 
            // editreservationbutton
            // 
            this.editreservationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.editreservationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.editreservationbutton.ForeColor = System.Drawing.Color.White;
            this.editreservationbutton.Location = new System.Drawing.Point(688, 302);
            this.editreservationbutton.Name = "editreservationbutton";
            this.editreservationbutton.Size = new System.Drawing.Size(235, 75);
            this.editreservationbutton.TabIndex = 3;
            this.editreservationbutton.Text = "EDITAR RESERVA";
            this.editreservationbutton.UseVisualStyleBackColor = false;
            this.editreservationbutton.Click += new System.EventHandler(this.editreservationbutton_Click);
            // 
            // desactivatereservationbutton
            // 
            this.desactivatereservationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.desactivatereservationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.desactivatereservationbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.desactivatereservationbutton.Location = new System.Drawing.Point(688, 196);
            this.desactivatereservationbutton.Name = "desactivatereservationbutton";
            this.desactivatereservationbutton.Size = new System.Drawing.Size(235, 75);
            this.desactivatereservationbutton.TabIndex = 2;
            this.desactivatereservationbutton.Text = "ACTIVAR/DESACTIVAR RESERVA";
            this.desactivatereservationbutton.UseVisualStyleBackColor = false;
            this.desactivatereservationbutton.Click += new System.EventHandler(this.desactivatereservationbutton_Click);
            // 
            // createreservationbutton
            // 
            this.createreservationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.createreservationbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createreservationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createreservationbutton.ForeColor = System.Drawing.Color.White;
            this.createreservationbutton.Location = new System.Drawing.Point(688, 90);
            this.createreservationbutton.Name = "createreservationbutton";
            this.createreservationbutton.Size = new System.Drawing.Size(235, 75);
            this.createreservationbutton.TabIndex = 1;
            this.createreservationbutton.Text = "CREAR RESERVA";
            this.createreservationbutton.UseVisualStyleBackColor = false;
            this.createreservationbutton.Click += new System.EventHandler(this.createreservationbutton_Click);
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
            this.gestionarUsuarisToolStripMenuItem,
            this.gestionarEventsToolStripMenuItem,
            this.gestionarSalasToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Bookaroom.Properties.Resources.bookaroom_ic;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 32);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // gestionarUsuarisToolStripMenuItem
            // 
            this.gestionarUsuarisToolStripMenuItem.Name = "gestionarUsuarisToolStripMenuItem";
            this.gestionarUsuarisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarUsuarisToolStripMenuItem.Text = "Gestionar Usuaris";
            this.gestionarUsuarisToolStripMenuItem.Click += new System.EventHandler(this.gestionarUsuarisToolStripMenuItem_Click);
            // 
            // gestionarEventsToolStripMenuItem
            // 
            this.gestionarEventsToolStripMenuItem.Name = "gestionarEventsToolStripMenuItem";
            this.gestionarEventsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarEventsToolStripMenuItem.Text = "Gestionar Events";
            this.gestionarEventsToolStripMenuItem.Click += new System.EventHandler(this.gestionarEventsToolStripMenuItem_Click);
            // 
            // gestionarSalasToolStripMenuItem
            // 
            this.gestionarSalasToolStripMenuItem.Name = "gestionarSalasToolStripMenuItem";
            this.gestionarSalasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarSalasToolStripMenuItem.Text = "Gestionar Salas";
            this.gestionarSalasToolStripMenuItem.Click += new System.EventHandler(this.gestionarSalasToolStripMenuItem_Click);
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
            this.userfilterbox.Location = new System.Drawing.Point(700, 487);
            this.userfilterbox.Name = "userfilterbox";
            this.userfilterbox.Size = new System.Drawing.Size(147, 20);
            this.userfilterbox.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // seeUserFilterButton
            // 
            this.seeUserFilterButton.Location = new System.Drawing.Point(864, 484);
            this.seeUserFilterButton.Name = "seeUserFilterButton";
            this.seeUserFilterButton.Size = new System.Drawing.Size(50, 23);
            this.seeUserFilterButton.TabIndex = 8;
            this.seeUserFilterButton.Text = "Ver";
            this.seeUserFilterButton.UseVisualStyleBackColor = true;
            this.seeUserFilterButton.Click += new System.EventHandler(this.seeUserFilterButton_Click);
            // 
            // resetpictureBox
            // 
            this.resetpictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(171)))), ((int)(((byte)(86)))));
            this.resetpictureBox.BackgroundImage = global::Bookaroom.Properties.Resources.reiniciar;
            this.resetpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetpictureBox.Location = new System.Drawing.Point(892, 395);
            this.resetpictureBox.Name = "resetpictureBox";
            this.resetpictureBox.Size = new System.Drawing.Size(31, 33);
            this.resetpictureBox.TabIndex = 44;
            this.resetpictureBox.TabStop = false;
            this.resetpictureBox.Click += new System.EventHandler(this.resetpictureBox_Click);
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
            // ticketsdataGridView
            // 
            this.ticketsdataGridView.AllowUserToAddRows = false;
            this.ticketsdataGridView.AllowUserToDeleteRows = false;
            this.ticketsdataGridView.AllowUserToOrderColumns = true;
            this.ticketsdataGridView.AutoGenerateColumns = false;
            this.ticketsdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(196)))), ((int)(((byte)(153)))));
            this.ticketsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsdataGridView.DataSource = this.bindingSourceTickets;
            this.ticketsdataGridView.Location = new System.Drawing.Point(36, 70);
            this.ticketsdataGridView.Name = "ticketsdataGridView";
            this.ticketsdataGridView.ReadOnly = true;
            this.ticketsdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ticketsdataGridView.Size = new System.Drawing.Size(578, 451);
            this.ticketsdataGridView.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(688, 395);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 126);
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(697, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione Usuario";
            // 
            // seeseatsinforadiocheckBox
            // 
            this.seeseatsinforadiocheckBox.AutoSize = true;
            this.seeseatsinforadiocheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.seeseatsinforadiocheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seeseatsinforadiocheckBox.ForeColor = System.Drawing.Color.White;
            this.seeseatsinforadiocheckBox.Location = new System.Drawing.Point(703, 433);
            this.seeseatsinforadiocheckBox.Name = "seeseatsinforadiocheckBox";
            this.seeseatsinforadiocheckBox.Size = new System.Drawing.Size(144, 21);
            this.seeseatsinforadiocheckBox.TabIndex = 5;
            this.seeseatsinforadiocheckBox.Text = "Quitar Info Asiento";
            this.seeseatsinforadiocheckBox.UseVisualStyleBackColor = false;
            this.seeseatsinforadiocheckBox.CheckedChanged += new System.EventHandler(this.seeseatsinforadiocheckBox_CheckedChanged);
            // 
            // ReservaTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(988, 559);
            this.Controls.Add(this.resetpictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seeseatsinforadiocheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seeUserFilterButton);
            this.Controls.Add(this.userfilterbox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ticketsdataGridView);
            this.Controls.Add(this.editreservationbutton);
            this.Controls.Add(this.desactivatereservationbutton);
            this.Controls.Add(this.createreservationbutton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ReservaTable";
            this.Text = "ReservaTable";
            this.Load += new System.EventHandler(this.ReservaTable_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editreservationbutton;
        private System.Windows.Forms.Button desactivatereservationbutton;
        private System.Windows.Forms.Button createreservationbutton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel closesessiontoolStripLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox userfilterbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button seeUserFilterButton;
        private System.Windows.Forms.PictureBox resetpictureBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuarisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEventsToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSourceTickets;
        private System.Windows.Forms.DataGridView ticketsdataGridView;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox seeseatsinforadiocheckBox;
        private System.Windows.Forms.ToolStripMenuItem gestionarSalasToolStripMenuItem;
    }
}