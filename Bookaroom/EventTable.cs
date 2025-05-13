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
            eventdataGridView.RowHeadersVisible = false;
            eventdataGridView.EnableHeadersVisualStyles = false;
            eventdataGridView.DefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            eventdataGridView.DefaultCellStyle.ForeColor = Color.Black;
            eventdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            eventdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            if (Session.Rol == "Event Organizer")
            {
                gestionarUserToolStripMenuItem.Visible = false;
                gestionarSalasToolStripMenuItem.Visible = false;
            }
            else if (Session.Rol == "SuperAdmin")
            {
                gestionarUserToolStripMenuItem.Visible = true;
                gestionarSalasToolStripMenuItem.Visible = false;

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

        private void gestionarSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new RoomTable());
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

            if (eventdataGridView.SelectedRows.Count > 0)
            {
                int eventId = Convert.ToInt32(eventdataGridView.SelectedRows[0].Cells["event_id"].Value);

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
            if (eventdataGridView.SelectedRows.Count > 0)
            {
                int eventID = Convert.ToInt32(eventdataGridView.SelectedRows[0].Cells["event_id"].Value);

                EditEventForm f = new EditEventForm(eventID);
                f.ShowDialog();
                bindingSource1.DataSource = EventsOrm.Select();
            }

            else
            {
                MessageBox.Show("Porfavor selecione un usuario.");
            }

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
        private void seedateiniradiocheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (seedateiniradiocheckBox.Checked)
            {
                if (eventdataGridView.Columns.Contains("start_date"))
                {
                    eventdataGridView.Columns["start_date"].Visible = false; 
                }
            }
            else
            {
                if (eventdataGridView.Columns.Contains("start_date"))
                {
                    eventdataGridView.Columns["start_date"].Visible = true; 
                }
            }
        }

        private void seedateendcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (seedateendcheckBox.Checked)
            {
                if (eventdataGridView.Columns.Contains("end_date"))
                {
                    eventdataGridView.Columns["end_date"].Visible = false; 
                }
            }
            else
            {
                if (eventdataGridView.Columns.Contains("end_date"))
                {
                    eventdataGridView.Columns["end_date"].Visible = true; 
                }
            }
        }

        private void seecapacitycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (seecapacitycheckBox.Checked)
            {
                if (eventdataGridView.Columns.Contains("capacity"))
                {
                    eventdataGridView.Columns["capacity"].Visible = false; 
                }
            }
            else
            {
                if (eventdataGridView.Columns.Contains("capacity"))
                {
                    eventdataGridView.Columns["capacity"].Visible = true;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

