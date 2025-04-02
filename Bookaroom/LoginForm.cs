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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bookaroom
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();



        }


        private void login_button_Click(object sender, EventArgs e)
        {
             if (!String.IsNullOrEmpty(emailtextbox.Text) || !String.IsNullOrEmpty(passwordtextbox.Text))
            {

                string email = emailtextbox.Text;
                string password = passwordtextbox.Text;
                bool check = Users.checkUserBD(email, password);

                if (check)
                {
                    string rol = Users.checkRol(email);
                    if (rol == "Superadmin") {
                        StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
                        staticFormmainForm.OpenForm(new SuperadminSelection());
                    }
                    else if(rol == "Event Organizer")
                    {
                        StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
                        staticFormmainForm.OpenForm(new EventOrganizerContent());
                    }

                }        
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
