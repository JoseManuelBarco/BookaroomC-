namespace Bookaroom
{
    partial class EditReservationForm
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
            this.eventscomboBox = new System.Windows.Forms.ComboBox();
            this.seatcomboBox = new System.Windows.Forms.ComboBox();
            this.usercomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventscomboBox
            // 
            this.eventscomboBox.FormattingEnabled = true;
            this.eventscomboBox.Location = new System.Drawing.Point(39, 245);
            this.eventscomboBox.Name = "eventscomboBox";
            this.eventscomboBox.Size = new System.Drawing.Size(357, 21);
            this.eventscomboBox.TabIndex = 6;
            // 
            // seatcomboBox
            // 
            this.seatcomboBox.FormattingEnabled = true;
            this.seatcomboBox.Location = new System.Drawing.Point(40, 182);
            this.seatcomboBox.Name = "seatcomboBox";
            this.seatcomboBox.Size = new System.Drawing.Size(357, 21);
            this.seatcomboBox.TabIndex = 4;
            // 
            // usercomboBox
            // 
            this.usercomboBox.FormattingEnabled = true;
            this.usercomboBox.Location = new System.Drawing.Point(40, 114);
            this.usercomboBox.Name = "usercomboBox";
            this.usercomboBox.Size = new System.Drawing.Size(358, 21);
            this.usercomboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Outfit", 9.749999F);
            this.label1.Location = new System.Drawing.Point(38, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(195)))), ((int)(((byte)(150)))));
            this.label5.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "EDITAR RESERVA";
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.cancelbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelbutton.ForeColor = System.Drawing.Color.White;
            this.cancelbutton.Location = new System.Drawing.Point(239, 310);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(159, 51);
            this.cancelbutton.TabIndex = 8;
            this.cancelbutton.Text = "CANCELAR";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(40, 310);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(159, 51);
            this.savebutton.TabIndex = 7;
            this.savebutton.Text = "EDITAR RESERVA";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Outfit", 9.749999F);
            this.label4.Location = new System.Drawing.Point(37, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Evento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Outfit", 9.749999F);
            this.label2.Location = new System.Drawing.Point(37, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
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
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Bookaroom.Properties.Resources.Create_Background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 399);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // EditReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(434, 446);
            this.Controls.Add(this.eventscomboBox);
            this.Controls.Add(this.seatcomboBox);
            this.Controls.Add(this.usercomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EditReservationForm";
            this.Text = "EditReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox eventscomboBox;
        private System.Windows.Forms.ComboBox seatcomboBox;
        private System.Windows.Forms.ComboBox usercomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}