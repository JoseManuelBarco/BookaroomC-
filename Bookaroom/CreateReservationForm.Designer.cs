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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.savechangesbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usercomboBox = new System.Windows.Forms.ComboBox();
            this.seatcomboBox = new System.Windows.Forms.ComboBox();
            this.eventcomboBox = new System.Windows.Forms.ComboBox();
            this.activecheckbox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEvents = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(37, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(195)))), ((int)(((byte)(150)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(263, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 0;
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
            this.button2.TabIndex = 9;
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
            this.savechangesbutton.TabIndex = 8;
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
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Evento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(37, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
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
            // usercomboBox
            // 
            this.usercomboBox.FormattingEnabled = true;
            this.usercomboBox.Location = new System.Drawing.Point(40, 114);
            this.usercomboBox.Name = "usercomboBox";
            this.usercomboBox.Size = new System.Drawing.Size(358, 21);
            this.usercomboBox.TabIndex = 2;
            // 
            // seatcomboBox
            // 
            this.seatcomboBox.FormattingEnabled = true;
            this.seatcomboBox.Location = new System.Drawing.Point(39, 248);
            this.seatcomboBox.Name = "seatcomboBox";
            this.seatcomboBox.Size = new System.Drawing.Size(357, 21);
            this.seatcomboBox.TabIndex = 6;
            this.seatcomboBox.SelectedIndexChanged += new System.EventHandler(this.seatcomboBox_SelectedIndexChanged);
            // 
            // eventcomboBox
            // 
            this.eventcomboBox.FormattingEnabled = true;
            this.eventcomboBox.Location = new System.Drawing.Point(39, 178);
            this.eventcomboBox.Name = "eventcomboBox";
            this.eventcomboBox.Size = new System.Drawing.Size(357, 21);
            this.eventcomboBox.TabIndex = 4;
            this.eventcomboBox.SelectedIndexChanged += new System.EventHandler(this.eventcomboBox_SelectedIndexChanged);
            // 
            // activecheckbox
            // 
            this.activecheckbox.AutoSize = true;
            this.activecheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.activecheckbox.Checked = true;
            this.activecheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activecheckbox.Location = new System.Drawing.Point(40, 301);
            this.activecheckbox.Name = "activecheckbox";
            this.activecheckbox.Size = new System.Drawing.Size(56, 17);
            this.activecheckbox.TabIndex = 7;
            this.activecheckbox.Text = "Activo";
            this.activecheckbox.UseVisualStyleBackColor = false;
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
            // CreateReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(429, 464);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).EndInit();
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
        private System.Windows.Forms.ComboBox usercomboBox;
        private System.Windows.Forms.ComboBox seatcomboBox;
        private System.Windows.Forms.ComboBox eventcomboBox;
        private System.Windows.Forms.CheckBox activecheckbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSourceUsers;
        private System.Windows.Forms.BindingSource bindingSourceEvents;
    }
}