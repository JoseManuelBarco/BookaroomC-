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
    public partial class StaticForm : Form
    {
        private Form activeForm = null;
        public StaticForm()
        {
            InitializeComponent();
            LoadLogin();
        }
        private void LoadLogin()
        {
            OpenForm(new LoginForm());
        }

        public void OpenForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(childForm);
            ContainerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
