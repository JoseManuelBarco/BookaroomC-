using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookaroom.Models;

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


            bool result = UsersOrm.ResetPassword(userId);

            if (result)
            {
                MessageBox.Show("Contraseña restablecida correctamente a 'reset123'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
