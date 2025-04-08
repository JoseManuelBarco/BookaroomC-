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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bookaroom
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void createuserbutton_Click(object sender, EventArgs e)
        {
        
            string email = emailtextBox.Text.Trim();
            string name = nomtextBox.Text.Trim();
            string surnames = cognomstextBox.Text.Trim();
            string password = passwordtextBox.Text;
            string confirmPassword = passwordtextBox.Text;
            int actiu = 0;

            if (activecheckBox.Checked)
            {
                actiu = 1;

            }
            if (rolcombobox.SelectedIndex != -1)
            {
                int idrole = rolcombobox.SelectedIndex + 1;

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surnames) ||
                    string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("Todos los campos son necesarios.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

             
                if (Users.AddUser(email, name, surnames, password, idrole, actiu))
                {
                    MessageBox.Show("Usuari afegit correctament", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
                    staticFormmainForm.OpenForm(new UserTable());
                }
                else
                {
                    MessageBox.Show("Error al añadir el usuario. Por favor vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {

           this.Close();
        }
    }
}

