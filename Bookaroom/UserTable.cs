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
            dataGridViewUsers.DefaultCellStyle.BackColor = Color.FromArgb(232, 207, 174);
            dataGridViewUsers.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 207, 174);
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void UserTable_Load(object sender, EventArgs e)
        {
            bindingSourceUsers.DataSource = UsersOrm.Select();
        }
        private void closesessionLabel_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new LoginForm());
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
        private void gestionarSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new RoomTable());
        }
        private void createuserButton_Click(object sender, EventArgs e)
        {
            CreateUserForm f = new CreateUserForm();
            f.ShowDialog();
            bindingSourceUsers.DataSource = UsersOrm.Select();

        }
        private void edituserbutton_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["user_id"].Value);

                EditUserForm f = new EditUserForm(userId);
                f.ShowDialog();
                bindingSourceUsers.DataSource = UsersOrm.Select();

            }

            else {
                MessageBox.Show("Porfavor selecione un usuario.");
            }
        }
        private void desactivateuserbutton_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["user_id"].Value);
                int active = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["active"].Value);

                string action = active == 1 ? "desactivar" : "activar";
                var result = MessageBox.Show($"¿Quieres {action} este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool updated = UsersOrm.ToggleActiveStatus(userId);
                    if (updated)
                    {
                        MessageBox.Show($"Usuario {action} correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSourceUsers.DataSource = UsersOrm.Select(); 
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el estado del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario.");
            }
        }
        private void seeinactiveradioButton_CheckedChanged(object sender, EventArgs e)
        {
           dataGridViewUsers.ClearSelection();
           dataGridViewUsers.CurrentCell = null; 

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
        private void seeactiveradioButton_CheckedChanged(object sender, EventArgs e)
        {
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
        private void seeallradioButton_CheckedChanged(object sender, EventArgs e)
        {
            {
                dataGridViewUsers.ClearSelection();
                dataGridViewUsers.CurrentCell = null;

                foreach (DataGridViewRow row in dataGridViewUsers.Rows)
                {
                    row.Visible = true;

                }
            }
        }

       
    }
}
