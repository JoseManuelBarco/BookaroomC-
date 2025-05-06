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
    public partial class UserTable : Form
    {
        public UserTable()
        {
            InitializeComponent();
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.DefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            dataGridViewUsers.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        }
 
        private void closesessionLabel_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new LoginForm());
        }

        private void createuserButton_Click(object sender, EventArgs e)
        {
            CreateUserForm f = new CreateUserForm();
            f.ShowDialog();

        }

        private void edituserbutton_Click(object sender, EventArgs e)
        {
            if (userdataGridView.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(userdataGridView.SelectedRows[0].Cells["Id_usuari"].Value);

                EditUserForm f = new EditUserForm(userId);
                f.ShowDialog();

            }

            else {
                MessageBox.Show("Porfavor selecione un usuario.");
            }
        }

        private void desactivateuserbutton_Click(object sender, EventArgs e)
        {
            if (userdataGridView.SelectedRows.Count > 0)
            {
                int active=Convert.ToInt32(userdataGridView.SelectedRows[0].Cells["Id_usuari"].Value);


                int userId = Convert.ToInt32(userdataGridView.SelectedRows[0].Cells["Id_usuari"].Value);

                var result = MessageBox.Show("Quieres desactivar este usuario?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Users.DeleteUser(userId);
                }
            }
            else
            {
                MessageBox.Show("Porfavor selecione un usuario.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.ClearSelection();
            dataGridViewUsers.CurrentCell = null; // Muy importante

            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                if (row.Cells["active"].Value != null && Convert.ToInt32(row.Cells["active"].Value) == 0)
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }
            }
        }

        private void seeNotActives_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.ClearSelection();
            dataGridViewUsers.CurrentCell = null; // Muy importante

            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                if (row.Cells["active"].Value != null && Convert.ToInt32(row.Cells["active"].Value) == 1)
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }
            }
        }

        private void makeAllVisible_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.ClearSelection();
            dataGridViewUsers.CurrentCell = null;
            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                row.Visible = true;

            }
        }

        private void gestionarEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new EventTable());
        }

        private void gestionarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new ReservaTable());
        }

        private void UserTable_Load(object sender, EventArgs e)
        {
            bindingSourceUsers.DataSource = UsersOrm.Select();

        }
    }
}
