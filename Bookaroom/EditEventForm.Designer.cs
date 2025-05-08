namespace Bookaroom
{
    partial class EditEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEventForm));
            this.dataenddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datainidateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savechangesbutton = new System.Windows.Forms.Button();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.capacitytextBox = new System.Windows.Forms.TextBox();
            this.nomtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataenddateTimePicker
            // 
            this.dataenddateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dataenddateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataenddateTimePicker.Location = new System.Drawing.Point(222, 246);
            this.dataenddateTimePicker.Name = "dataenddateTimePicker";
            this.dataenddateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.dataenddateTimePicker.TabIndex = 8;
            // 
            // datainidateTimePicker
            // 
            this.datainidateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datainidateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datainidateTimePicker.Location = new System.Drawing.Point(40, 246);
            this.datainidateTimePicker.Name = "datainidateTimePicker";
            this.datainidateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.datainidateTimePicker.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(37, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dia de Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(37, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(195)))), ((int)(((byte)(150)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(263, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "EDITAR EVENTO";
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.cancelbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelbutton.ForeColor = System.Drawing.Color.White;
            this.cancelbutton.Location = new System.Drawing.Point(238, 373);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(159, 51);
            this.cancelbutton.TabIndex = 12;
            this.cancelbutton.Text = "CANCELAR";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savechangesbutton
            // 
            this.savechangesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.savechangesbutton.ForeColor = System.Drawing.Color.White;
            this.savechangesbutton.Location = new System.Drawing.Point(40, 373);
            this.savechangesbutton.Name = "savechangesbutton";
            this.savechangesbutton.Size = new System.Drawing.Size(159, 51);
            this.savechangesbutton.TabIndex = 11;
            this.savechangesbutton.Text = "GUARDAR";
            this.savechangesbutton.UseVisualStyleBackColor = false;
            this.savechangesbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pricetextBox
            // 
            this.pricetextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.pricetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricetextBox.Location = new System.Drawing.Point(40, 302);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(358, 20);
            this.pricetextBox.TabIndex = 10;
            // 
            // capacitytextBox
            // 
            this.capacitytextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.capacitytextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capacitytextBox.Location = new System.Drawing.Point(40, 177);
            this.capacitytextBox.Name = "capacitytextBox";
            this.capacitytextBox.Size = new System.Drawing.Size(358, 20);
            this.capacitytextBox.TabIndex = 4;
            // 
            // nomtextBox
            // 
            this.nomtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.nomtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomtextBox.Location = new System.Drawing.Point(40, 118);
            this.nomtextBox.Name = "nomtextBox";
            this.nomtextBox.Size = new System.Drawing.Size(358, 20);
            this.nomtextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(37, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(221, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dia de Finalizacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(37, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aforo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Bookaroom.Properties.Resources.Title_create;
            this.pictureBox2.Location = new System.Drawing.Point(172, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 80);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Bookaroom.Properties.Resources.Create_Background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 452);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(79)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.dataenddateTimePicker);
            this.Controls.Add(this.datainidateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savechangesbutton);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.capacitytextBox);
            this.Controls.Add(this.nomtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditEventForm";
            this.Text = "EditEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataenddateTimePicker;
        private System.Windows.Forms.DateTimePicker datainidateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savechangesbutton;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.TextBox capacitytextBox;
        private System.Windows.Forms.TextBox nomtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}