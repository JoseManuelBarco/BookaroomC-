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
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            if (Session.Rol == "Event Organizer")
            {
                gestionarUserToolStripMenuItem.Visible = false;
            }
            else if(Session.Rol == "SuperAdmin")
            {
                gestionarUserToolStripMenuItem.Visible = true;
            }
        }
        private void capacityfilterlabel_Click_1(object sender, EventArgs e)
        {
                dataGridView1.Columns["capacity"].Visible =
                   !dataGridView1.Columns["capacity"].Visible;
        }
        private void dateendfilterlabel_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["end_date"].Visible =
                !this.dataGridView1.Columns["end_date"].Visible;
        }
        private void dateinifilterlabel_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = EventsOrm.Select();

            if (dataGridView1.Columns.Contains("start_date"))
            {
                dataGridView1.Columns["start_date"].Visible =
                    !dataGridView1.Columns["start_date"].Visible;
            }
            else
            {
                MessageBox.Show("La columna 'start_date' no existe en el DataGridView.");
            }
        }
        private void createeventbutton_Click(object sender, EventArgs e)
        {
            CreateEventForm f = new CreateEventForm();
            f.ShowDialog();
            bindingSource1.DataSource = EventsOrm.Select();
        }

        private void desactivateeventbutton_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = EventsOrm.Select();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int eventId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["event_id"].Value);

                var result = MessageBox.Show("Vols desactivar aquest esdeveniment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    EventsBD.DeleteEvent(eventId);
                    bindingSource1.DataSource = EventsOrm.Select();
                }
            }
            else
            {
                MessageBox.Show("Siusplau selecionni un esdeveniment.");
            }

        }
        private void editeventbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int eventID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["event_id"].Value);

                EditEventForm f = new EditEventForm(eventID);
                f.ShowDialog();
                bindingSource1.DataSource = EventsOrm.Select();
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

        private void EventTable_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = EventsOrm.Select();

        }

    }
}

