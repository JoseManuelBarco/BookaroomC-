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
    public partial class RoomTable : Form
    {
        public RoomTable()
        {
            InitializeComponent();
            dataGridViewRooms.RowHeadersVisible = false;
            dataGridViewRooms.EnableHeadersVisualStyles = false;
            dataGridViewRooms.DefaultCellStyle.BackColor = Color.FromArgb(232, 207, 174);
            dataGridViewRooms.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewRooms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 207, 174);
            dataGridViewRooms.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void RoomTable_Load(object sender, EventArgs e)
        {
            bindingSourceRooms.DataSource = RoomsOrm.Select();
        }

        private void createroomsButton_Click(object sender, EventArgs e)
        {
            CreateRoom f = new CreateRoom();
            f.ShowDialog();
            bindingSourceRooms.DataSource = RoomsOrm.Select();
        }

        private void desactivateroomsbutton_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                int roomid = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells["room_id"].Value);
                int active = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells["status"].Value);

                string action = active == 1 ? "desactivar" : "activar";
                var result = MessageBox.Show($"¿Quieres {action} esta sala?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool updated = RoomsOrm.ToggleActiveStatus(roomid);
                    if (updated)
                    {
                        MessageBox.Show($"Sala {action}da correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSourceRooms.DataSource = RoomsOrm.Select();
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

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new UserTable());
        }

        private void editroomsbutton_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                int roomId = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells["room_id"].Value);

                EditRoomForm f = new EditRoomForm(roomId);
                f.ShowDialog();
                bindingSourceRooms.DataSource = RoomsOrm.Select();

            }

            else
            {
                MessageBox.Show("Porfavor selecione un usuario.");
            }
        }

        private void seeactiveradioButton_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewRooms.ClearSelection();
            dataGridViewRooms.CurrentCell = null;

            foreach (DataGridViewRow row in dataGridViewRooms.Rows)
            {
                if (row.Cells["status"].Value != null && Convert.ToInt32(row.Cells["status"].Value) == 0)
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }
            }
        }

        private void seeinactiveradioButton_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewRooms.ClearSelection();
            dataGridViewRooms.CurrentCell = null;

            foreach (DataGridViewRow row in dataGridViewRooms.Rows)
            {
                if (row.Cells["status"].Value != null && Convert.ToInt32(row.Cells["status"].Value) == 1)
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
                dataGridViewRooms.ClearSelection();
                dataGridViewRooms.CurrentCell = null;

                foreach (DataGridViewRow row in dataGridViewRooms.Rows)
                {
                    row.Visible = true;

                }
        }
    }
}
