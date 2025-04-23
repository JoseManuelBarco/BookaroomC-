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
           

            bool result = Users.ResetPassword(userId);

            if (result)
            {
                MessageBox.Show("Contraseña restablecida correctamente a 'reset123'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al restablecer la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
