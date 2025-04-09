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
                    reservationDataGridView.Rows[rowIndex].Cells["id_entrada"].Value = row["id_entrada"];
                    reservationDataGridView.Rows[rowIndex].Cells["id_usuari"].Value = row["nom_usuari"];
                    reservationDataGridView.Rows[rowIndex].Cells["numero_butaca"].Value = row["numero_butaca"];
                    reservationDataGridView.Rows[rowIndex].Cells["numero_fila"].Value = row["numero_fila"];
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
            staticFormmainForm.OpenForm(new EventOrganizerContent());
        }

        private void closesessiontoolStripLabel_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new LoginForm());
        }

        private void createreservationbutton_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new CreateReservationForm());
        }
    }
}

