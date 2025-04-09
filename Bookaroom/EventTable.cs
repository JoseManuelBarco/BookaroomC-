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
    public partial class EventTable : Form
    {
        string rolUsuario = Session.Rol;

        public EventTable()
        {
            InitializeComponent();
            LoadDataIntoPreExistingColumns();
            eventdatagridview.RowHeadersVisible = false;
            eventdatagridview.EnableHeadersVisualStyles = false;
            eventdatagridview.DefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            eventdatagridview.DefaultCellStyle.ForeColor = Color.Black;
            eventdatagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            eventdatagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            if (Session.Rol == "Event Organizer")
            {
                gestionarUserToolStripMenuItem.Visible = false;
            }
            else if(Session.Rol == "SuperAdmin")
            {
                gestionarUserToolStripMenuItem.Visible = true;
            }
        }
            





        private void LoadDataIntoPreExistingColumns()
        {
            try
            {
                eventdatagridview.Rows.Clear();

                DataTable usersTable = EventsBD.GetEvents();
                foreach (DataRow row in usersTable.Rows)
                {
                    int rowIndex = eventdatagridview.Rows.Add();
                    eventdatagridview.Rows[rowIndex].Cells["id_event"].Value = row["id_esdeveniment"];
                    eventdatagridview.Rows[rowIndex].Cells["id_sala"].Value = row["id_sala"];
                    eventdatagridview.Rows[rowIndex].Cells["id_usuari"].Value = row["nom_usuari"];
                    eventdatagridview.Rows[rowIndex].Cells["Nom"].Value = row["nombre"];
                    eventdatagridview.Rows[rowIndex].Cells["descripcio"].Value = row["descripcio"];
                    eventdatagridview.Rows[rowIndex].Cells["aforament"].Value = row["aforament"];
                    eventdatagridview.Rows[rowIndex].Cells["Data_Inici"].Value = row["data_inici"];
                    eventdatagridview.Rows[rowIndex].Cells["Data_fi"].Value = row["data_fi"];
                    eventdatagridview.Rows[rowIndex].Cells["Preu"].Value = row["preu"];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }    
        private void capacityfilterlabel_Click_1(object sender, EventArgs e)
        {
            
                this.eventdatagridview.Columns["aforament"].Visible =
                   !this.eventdatagridview.Columns["aforament"].Visible;
        }
        private void dateendfilterlabel_Click(object sender, EventArgs e)
        {
            this.eventdatagridview.Columns["Data_fi"].Visible =
                !this.eventdatagridview.Columns["Data_fi"].Visible;
        }

        private void dateinifilterlabel_Click(object sender, EventArgs e)
        {
            this.eventdatagridview.Columns["Data_Inici"].Visible =
                  !this.eventdatagridview.Columns["Data_Inici"].Visible;
        }

        private void createeventbutton_Click(object sender, EventArgs e)
        {
            CreateEventForm f = new CreateEventForm();
            f.ShowDialog();
            LoadDataIntoPreExistingColumns();
        }

        private void desactivateeventbutton_Click(object sender, EventArgs e)
        {
            if (eventdatagridview.SelectedRows.Count > 0)
            {


                int eventId = Convert.ToInt32(eventdatagridview.SelectedRows[0].Cells["Id_esdeveniment"].Value);

                var result = MessageBox.Show("Vols desactivar aquest esdeveniment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    EventsBD.DeleteEvent(eventId);


                    LoadDataIntoPreExistingColumns();
                }
            }
            else
            {
                MessageBox.Show("Siusplau selecionni un esdeveniment.");
            }
        }

        private void editeventbutton_Click(object sender, EventArgs e)
        {
            if (eventdatagridview.SelectedRows.Count > 0)
            {
                int eventID = Convert.ToInt32(eventdatagridview.SelectedRows[0].Cells["id_event"].Value);

                EditEventForm f = new EditEventForm(eventID);
                f.ShowDialog();
                LoadDataIntoPreExistingColumns();
            }

            else
            {
                MessageBox.Show("Porfavor selecione un usuario.");
            }
        }

        private void gestionarUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new UserTable());
        }

        private void gestionarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new ReservaTable());
        }

        private void closesessiontoolStripLabel_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new LoginForm());
        }
    }
}

