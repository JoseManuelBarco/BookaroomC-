using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
                staticFormmainForm.OpenForm(new EventOrganizerContent()); 
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
