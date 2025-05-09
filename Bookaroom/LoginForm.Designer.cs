namespace Bookaroom
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::Bookaroom.Properties.Resources.logo_ic;
            this.pictureBox1.Location = new System.Drawing.Point(335, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // emailtextbox
            // 
            this.emailtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.emailtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailtextbox.Location = new System.Drawing.Point(302, 297);
            this.emailtextbox.Multiline = true;
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.PasswordChar = '#';
            this.emailtextbox.Size = new System.Drawing.Size(380, 40);
            this.emailtextbox.TabIndex = 1;
            this.emailtextbox.UseSystemPasswordChar = true;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.passwordtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordtextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.passwordtextbox.Location = new System.Drawing.Point(302, 358);
            this.passwordtextbox.Multiline = true;
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordtextbox.Size = new System.Drawing.Size(380, 40);
            this.passwordtextbox.TabIndex = 2;
            this.passwordtextbox.TabStop = false;
            this.passwordtextbox.WordWrap = false;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(397, 418);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(192, 47);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "INICIAR SESION";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo Electronico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

