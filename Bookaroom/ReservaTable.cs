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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bookaroom
{
    public partial class ReservaTable : Form
    {
        public ReservaTable()
        {
            InitializeComponent();
            
            ticketsdataGridView.RowHeadersVisible = false;
            ticketsdataGridView.EnableHeadersVisualStyles = false;
            ticketsdataGridView.DefaultCellStyle.BackColor = Color.FromArgb(232, 207, 174);
            ticketsdataGridView.DefaultCellStyle.ForeColor = Color.Black;
            ticketsdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 207, 174);
            ticketsdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            ticketsdataGridView.Columns.Clear();

            ticketsdataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TicketId",        
                HeaderText = "ID Ticket",
                Name = "TicketId"
            });

            ticketsdataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserName",      
                HeaderText = "Nom Usuari",
                Name = "UserName"
            });
            ticketsdataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserID",
                HeaderText = "ID Usuario",
                Name = "UserID"
                
            });
            ticketsdataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EventName", 
                HeaderText = "Nom Esdeveniment",
                Name = "EventName"
            });

            ticketsdataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",        
                HeaderText = "Email",
                Name = "Email"
            });
            ticketsdataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RowColumn",
                HeaderText = "Numero Columna",
                Name = "RowColumn"
            });
            ticketsdataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SeatNumber",
                HeaderText = "Numero Asiento",
                Name = "SeatNumber"
            });
            ticketsdataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Estaddo",
                Name = "Status"
            });



            if (Session.Rol == "Event Organizer")
            {
                gestionarUsuarisToolStripMenuItem.Visible = false;
                gestionarSalasToolStripMenuItem.Visible = false;
            }
            else if (Session.Rol == "SuperAdmin")
            {
                gestionarUsuarisToolStripMenuItem.Visible = true;
                gestionarSalasToolStripMenuItem.Visible = false;

            }
        }
        
    

        private void filterdateinilabel_Click(object sender, EventArgs e)
        {
            this.ticketsdataGridView.Columns["RowColumn"].Visible =
                 !this.ticketsdataGridView.Columns["RowColumn"].Visible;

            this.ticketsdataGridView.Columns["SeatNumber"].Visible =
                !this.ticketsdataGridView.Columns["SeatNumber"].Visible;
        }


        private void seeUserFilterButton_Click(object sender, EventArgs e)
        {
            ticketsdataGridView.ClearSelection();
            ticketsdataGridView.CurrentCell = null;
            string userName = userfilterbox.Text.Trim().ToLower();

            foreach (DataGridViewRow row in this.ticketsdataGridView.Rows)
            {
                row.Visible = true;
            }

            if (string.IsNullOrEmpty(userName))
                return;

            foreach (DataGridViewRow row in this.ticketsdataGridView.Rows)
            {
                if (row.Cells["UserName"].Value != null &&
                    !row.Cells["UserName"].Value.ToString().ToLower().Contains(userName))
                {
                    row.Visible = false;
                }
            }
        }

        private void resetpictureBox_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.ticketsdataGridView.Rows)
            {
                row.Visible = true;
            }
        }
        private void gestionarUsuarisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new UserTable());
        }

        private void gestionarEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new EventTable());
        }

        private void closesessiontoolStripLabel_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new LoginForm());
        }

        private void gestionarSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new RoomTable());

        }
        private void createreservationbutton_Click(object sender, EventArgs e)
        {
            CreateReservationForm f = new CreateReservationForm();
            f.ShowDialog();
        }

        private void desactivatereservationbutton_Click(object sender, EventArgs e)
        {
            if (ticketsdataGridView.SelectedRows.Count > 0)
            {
                int ticketID = Convert.ToInt32(ticketsdataGridView.SelectedRows[0].Cells["TicketId"].Value);
                int active = Convert.ToInt32(ticketsdataGridView.SelectedRows[0].Cells["Status"].Value);

                string action = active == 1 ? "desactivar" : "activar";
                var result = MessageBox.Show($"¿Quieres {action} esta entrada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool updated = TicketsOrm.ToggleActiveStatus(ticketID);
                    if (updated)
                    {
                        MessageBox.Show($"Usuario {action} correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSourceTickets.DataSource = TicketsOrm.SelectEntradesAmbDetalls();
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

        private void editreservationbutton_Click(object sender, EventArgs e)
        {
            if (ticketsdataGridView.SelectedRows.Count > 0)
            {
                int reservationID = Convert.ToInt32(ticketsdataGridView.SelectedRows[0].Cells["TicketId"].Value);
              
                EditReservationForm f = new EditReservationForm(reservationID);
                f.ShowDialog();
                bindingSourceTickets.DataSource = TicketsOrm.SelectEntradesAmbDetalls();


            }
            else
            {
                MessageBox.Show("Porfavor selecione un usuario.");
            }
        }

        private void ReservaTable_Load(object sender, EventArgs e)
        {
            bindingSourceTickets.DataSource = TicketsOrm.SelectEntradesAmbDetalls();
            ticketsdataGridView.Columns["UserID"].Visible = false;
        }

        private void seeseatsinforadiocheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (seeseatsinforadiocheckBox.Checked)
            {
                if (ticketsdataGridView.Columns.Contains("SeatNumber"))
                {
                    ticketsdataGridView.Columns["SeatNumber"].Visible = false;
                }
                if(ticketsdataGridView.Columns.Contains("RowColumn"))
                {
                    ticketsdataGridView.Columns["RowColumn"].Visible = false;
                }
            }
            else
            {
                if (ticketsdataGridView.Columns.Contains("SeatNumber"))
                {
                    ticketsdataGridView.Columns["SeatNumber"].Visible = true;
                }
                if (ticketsdataGridView.Columns.Contains("RowColumn"))
                {
                    ticketsdataGridView.Columns["RowColumn"].Visible = true;
                }
            }
        }

     
    }
}

