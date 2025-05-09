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
    public partial class CreateReservationForm : Form
    {
        int reservationID;

        public CreateReservationForm()
        {
            InitializeComponent();
            LoadUsersComboBox();
            LoadEventsComboBox();
            LoadSeatsComboBox(reservationID);


        }

        private void LoadEventsComboBox()
        {
            bindingSourceEvents.DataSource = EventsOrm.SelectAvailablesEvents();

            eventcomboBox.DataSource = bindingSourceEvents;
            eventcomboBox.DisplayMember = "name"; 
            eventcomboBox.ValueMember = "event_id"; 

            eventcomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            eventcomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        
        private void LoadUsersComboBox()
        {
            DataTable users = Users.GetUsers();

            if (users.Rows.Count > 0)
            {
                usercomboBox.DataSource = users;
                usercomboBox.DisplayMember = "name";
                usercomboBox.ValueMember = "user_id";

                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
                foreach (DataRow row in users.Rows)
                {
                    string fullName = $"{row["name"]}";
                    autoComplete.Add(fullName);
                }

                usercomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                usercomboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                usercomboBox.AutoCompleteCustomSource = autoComplete;
            }
        }
        private void LoadSeatsComboBox(int salaId)
        {
            int seatid = Rooms.GetSeatAssigned(reservationID);
            int salaid = Rooms.GetRoomAssigned(reservationID);

            DataTable seats = Rooms.GetSeatsForEdit(salaid, seatid);

            if (seats.Rows.Count > 0)
            {
                seats.Columns.Add("DisplaySeat", typeof(string));

                foreach (DataRow row in seats.Rows)
                {
                    string fila = row["row_number"].ToString();
                    string asiento = row["seat_number"].ToString();

                    row["DisplaySeat"] = $"Fila {fila} - Asiento {asiento}";
                }

                seatcomboBox.DataSource = seats;
                seatcomboBox.DisplayMember = "DisplaySeat";
                seatcomboBox.ValueMember = "seat_id";
            }
            else
            {
                seatcomboBox.DataSource = null;
            }
        }

        private void seatcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eventcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEvent = eventcomboBox.SelectedItem as Esdeveniments;
            if (selectedEvent != null)
            {
                reservationID = selectedEvent.event_id;
            }
        }

        private void savechangesbutton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(usercomboBox.SelectedValue);  
            int eventId = Convert.ToInt32(eventcomboBox.SelectedValue); 
            int seatId = Convert.ToInt32(seatcomboBox.SelectedValue);
            int status = 0;

            if (activecheckbox.Checked)
            {
                status = 1;

            }


            bool result = TicketsOrm.InsertTicket(userId, eventId, seatId,status);
            this.Close();          
        }
    }
}
