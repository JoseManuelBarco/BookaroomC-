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
            
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TicketId",        
                HeaderText = "ID Ticket",
                Name = "TicketId"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserName",      
                HeaderText = "Nom Usuari",
                Name = "UserName"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserID",
                HeaderText = "ID Usuario",
                Name = "UserID"
                
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EventName", 
                HeaderText = "Nom Esdeveniment",
                Name = "EventName"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",        
                HeaderText = "Email",
                Name = "Email"
            });


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RowColumn",
                HeaderText = "Numero Columna",
                Name = "RowColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SeatNumber",
                HeaderText = "Numero Asiento",
                Name = "SeatNumber"
            });

            dataGridView1.Columns["UserID"].Visible = false;



            if (Session.Rol == "Event Organizer")
            {
                gestionarUsuarisToolStripMenuItem.Visible = false;
            }
            else if (Session.Rol == "SuperAdmin")
            {
                gestionarUsuarisToolStripMenuItem.Visible = true;
            }
        }
        
    

        private void filterdateinilabel_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["RowColumn"].Visible =
                 !this.dataGridView1.Columns["RowColumn"].Visible;

            this.dataGridView1.Columns["SeatNumber"].Visible =
                !this.dataGridView1.Columns["SeatNumber"].Visible;
        }


        private void seeUserFilterButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            string userName = userfilterbox.Text.Trim().ToLower();

            // Mostrar todas las filas primero
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                row.Visible = true;
            }

            // Si el filtro está vacío, no hacemos nada más
            if (string.IsNullOrEmpty(userName))
                return;

            // Aplicar el filtro por nombre
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
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
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
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

        private void createreservationbutton_Click(object sender, EventArgs e)
        {
            CreateReservationForm f = new CreateReservationForm();
            f.ShowDialog();
        }

        private void desactivatereservationbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int active = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_entrada"].Value);


                int reservationid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_entrada"].Value);

                var result = MessageBox.Show("Quieres desactivar esta reserva?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ReserveBD.DeleteReservation(reservationid);
                }
            }
            else
            {
                MessageBox.Show("Porfavor selecione un usuario.");
            }
        }

        private void editreservationbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int reservationID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_entrada"].Value);
              
                EditReservationForm f = new EditReservationForm(reservationID);
                f.ShowDialog();

            }

            else
            {
                MessageBox.Show("Porfavor selecione un usuario.");
            }
        }

        private void ReservaTable_Load(object sender, EventArgs e)
        {
            bindingSourceTickets.DataSource = TicketsOrm.SelectEntradesAmbDetalls();
        }
    }
}

