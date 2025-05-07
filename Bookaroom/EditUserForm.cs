using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookaroom.Models;
using System.IO;
using System.Net.Mime;

namespace Bookaroom
{
    public partial class EditUserForm : Form
    {
        int userId;
        public EditUserForm(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            Users.GetUser(userId);

            LoadUserData();
        }
        private void LoadUserData()
        {
            DataTable userData = Users.GetUser(userId);
            DataRow row = userData.Rows[0];
            nomtextBox.Text = row["name"].ToString();
            surnametextBox.Text = row["surname"].ToString();
            emailtextBox.Text = row["email"].ToString();
        }

        private void resetpasswordbutton_Click(object sender, EventArgs e)
        {

            string newPassword = UsersOrm.ResetPassword(userId);

            if (!string.IsNullOrEmpty(newPassword))
            {
                string userEmail = UsersOrm.GetUserEmail(userId);

                if (!string.IsNullOrEmpty(userEmail))
                {
                    try
                    {
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("jbarcoc2324@politecnics.barcelona");
                        mail.To.Add(userEmail);
                        mail.Subject = "Restablecimiento de contraseña";
                        mail.IsBodyHtml = true;

                        string body = $@"
                            <html>
                                <body>
                                    <h2>Tu contraseña ha sido restablecida correctamente por nuestro equipo de administradores</h2>
                                    <p>La nueva contraseña es:</p>
                                    <pre>{newPassword}</pre>
                                    <br><br>
                                    <p>Saludos cordiales,</p>
                                    <p>Tu equipo de soporte</p>
                                    <br><br>
                                    <p>That just goes to show you you're nothin' but a Whiskey Delta!</p>
                                    <br><br>
                                    <img src='cid:logo_image' alt='Logo' width='200'/>
                                </body>
                            </html>";

                        mail.Body = body;

                        using (MemoryStream ms = new MemoryStream())
                        {
                            Image logoImage = Properties.Resources.logo_ic;
                            logoImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            ms.Position = 0;

                            Attachment logoAttachment = new Attachment(ms, "logo_ic.png", "image/png");
                            logoAttachment.ContentId = "logo_image";
                            logoAttachment.ContentDisposition.Inline = true;
                            logoAttachment.ContentDisposition.DispositionType = DispositionTypeNames.Inline;

                            mail.Attachments.Add(logoAttachment);

                            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                            smtp.Credentials = new NetworkCredential("jbarcoc2324@politecnics.barcelona", "lhwn xbpl hmkh whuj");
                            smtp.EnableSsl = true;

                            smtp.Send(mail);

                            MessageBox.Show("Correo enviado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hubo un error al restablecer la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
     

        private void confirmchangesbutton_Click(object sender, EventArgs e)
        {
            string name = nomtextBox.Text.Trim();
            string surname = surnametextBox.Text.Trim();
            string email = emailtextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Nombre y correo electrónico son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = UsersOrm.UpdateUser(userId, email, name, surname);

            if (result)
            {
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
