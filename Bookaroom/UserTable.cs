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
            LoadDataIntoPreExistingColumns();
            userdataGridView.RowHeadersVisible = false;
            userdataGridView.EnableHeadersVisualStyles = false;
            userdataGridView.DefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            userdataGridView.DefaultCellStyle.ForeColor = Color.Black;
            userdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            userdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        }
        private void LoadDataIntoPreExistingColumns()
        {
            try
            {
                userdataGridView.Rows.Clear();

                DataTable usersTable = Users.GetUsers();
                foreach (DataRow row in usersTable.Rows)
                {
                    int rowIndex = userdataGridView.Rows.Add();
                    userdataGridView.Rows[rowIndex].Cells["Id_usuari"].Value = row["user_id"];
                    userdataGridView.Rows[rowIndex].Cells["Nom"].Value = row["name"];
                    userdataGridView.Rows[rowIndex].Cells["Cognom"].Value = row["surname"];
                    userdataGridView.Rows[rowIndex].Cells["Email"].Value = row["email"];
                    userdataGridView.Rows[rowIndex].Cells["Rol"].Value = row["role"];

                    if (row["status"].ToString() == "Activo")
                    {
                        userdataGridView.Rows[rowIndex].Cells["Actiu"].Value = "Activo";
                    }
                    else
                    {
                        userdataGridView.Rows[rowIndex].Cells["Actiu"].Value = "Inactivo";
                    }
                
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
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
            LoadDataIntoPreExistingColumns();

        }

        private void edituserbutton_Click(object sender, EventArgs e)
        {
            if (userdataGridView.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(userdataGridView.SelectedRows[0].Cells["Id_usuari"].Value);

                EditUserForm f = new EditUserForm(userId);
                f.ShowDialog();
                LoadDataIntoPreExistingColumns();

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


                    LoadDataIntoPreExistingColumns();
                }
            }
            else
            {
                MessageBox.Show("Porfavor selecione un usuario.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.userdataGridView.Rows)
            {
                if (row.Cells["Actiu"].Value != null && row.Cells["Actiu"].Value.ToString() == "Inactivo")
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
            foreach (DataGridViewRow row in this.userdataGridView.Rows)
            {
                if (row.Cells["Actiu"].Value != null && row.Cells["Actiu"].Value.ToString() == "Activo")
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
            foreach (DataGridViewRow row in this.userdataGridView.Rows)
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
    }
}
