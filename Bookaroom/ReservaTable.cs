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
    public partial class ReservaTable : Form
    {
        public ReservaTable()
        {
            InitializeComponent();
            LoadDataIntoPreExistingColumns();
            reservationDataGridView.RowHeadersVisible = false;
            reservationDataGridView.EnableHeadersVisualStyles = false;
            reservationDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            reservationDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            reservationDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            reservationDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            if (Session.Rol == "Event Organizer")
            {
                gestionarUsuarisToolStripMenuItem.Visible = false;
            }
            else if (Session.Rol == "SuperAdmin")
            {
                gestionarUsuarisToolStripMenuItem.Visible = true;
            }
        }
        
        private void LoadDataIntoPreExistingColumns()
        {
            try
            {
                reservationDataGridView.Rows.Clear();

                DataTable usersTable = ReserveBD.GetTickets();
                foreach (DataRow row in usersTable.Rows)
                {
                    int rowIndex = reservationDataGridView.Rows.Add();
                    reservationDataGridView.Rows[rowIndex].Cells["id_entrada"].Value = row["ticket_id"];
                    reservationDataGridView.Rows[rowIndex].Cells["id_usuari"].Value = row["nom_usuari"];
                    reservationDataGridView.Rows[rowIndex].Cells["numero_butaca"].Value = row["row_number"];
                    reservationDataGridView.Rows[rowIndex].Cells["numero_fila"].Value = row["seat_number"];
                    reservationDataGridView.Rows[rowIndex].Cells["id_esdeveniment"].Value = row["nom_event"];
                    reservationDataGridView.Rows[rowIndex].Cells["email"].Value = row["email"];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void filterdateinilabel_Click(object sender, EventArgs e)
        {
            this.reservationDataGridView.Columns["numero_fila"].Visible =
                 !this.reservationDataGridView.Columns["numero_fila"].Visible;

            this.reservationDataGridView.Columns["numero_butaca"].Visible =
                !this.reservationDataGridView.Columns["numero_butaca"].Visible;
        }


        private void seeUserFilterButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.reservationDataGridView.Rows)
            {
                row.Visible = true;
            }
            string userName = userfilterbox.Text;

            foreach (DataGridViewRow row in this.reservationDataGridView.Rows)
            {
                if (row.Cells["id_usuari"].Value != null && !row.Cells["id_usuari"].Value.ToString().ToLower().Contains(userName.ToLower()))
                {
                    row.Visible = false;
                }
            }
        }

        private void resetpictureBox_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.reservationDataGridView.Rows)
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
            LoadDataIntoPreExistingColumns();
        }

        private void desactivatereservationbutton_Click(object sender, EventArgs e)
        {
            if (reservationDataGridView.SelectedRows.Count > 0)
            {
                int active = Convert.ToInt32(reservationDataGridView.SelectedRows[0].Cells["id_entrada"].Value);


                int reservationid = Convert.ToInt32(reservationDataGridView.SelectedRows[0].Cells["id_entrada"].Value);

                var result = MessageBox.Show("Quieres desactivar esta reserva?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ReserveBD.DeleteReservation(reservationid);


                    LoadDataIntoPreExistingColumns();
                }
            }
            else
            {
                MessageBox.Show("Porfavor selecione un usuario.");
            }
        }

        private void editreservationbutton_Click(object sender, EventArgs e)
        {
            if (reservationDataGridView.SelectedRows.Count > 0)
            {
                int reservationID = Convert.ToInt32(reservationDataGridView.SelectedRows[0].Cells["id_entrada"].Value);
              
                EditReservationForm f = new EditReservationForm(reservationID);
                f.ShowDialog();
                LoadDataIntoPreExistingColumns();

            }

            else
            {
                MessageBox.Show("Porfavor selecione un usuario.");
            }
        }
    }
}

