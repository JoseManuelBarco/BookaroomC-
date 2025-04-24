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
    public partial class EditReservationForm : Form
    {
        int reservationID;
        public EditReservationForm(int reservationID)
        {
            InitializeComponent();
            this.reservationID = reservationID;

            LoadEventsComboBox();
            LoadUsersComboBox();
            LoadSeatsComboBox();
            LoadReservationData();
        }


        private void LoadEventsComboBox()
        {
            DataTable events = EventsBD.GetEvents();
            if (events.Rows.Count > 0)
            {
                eventscomboBox.DataSource = events;
                eventscomboBox.DisplayMember = "name";
                eventscomboBox.ValueMember = "event_id";

                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
                foreach (DataRow row in events.Rows)
                {
                    string fullName = $"{row["name"]}";
                    autoComplete.Add(fullName);
                }

                eventscomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                eventscomboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                eventscomboBox.AutoCompleteCustomSource = autoComplete;
            }
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
        private void LoadSeatsComboBox()
        {
            int seatid = Rooms.GetSeatAssigned(reservationID);  // Asiento asignado
            int salaid = Rooms.GetRoomAssigned(reservationID);  // Sala asignada

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
        private void LoadReservationData()
        {
            DataTable reservation = ReserveBD.GetReservationDetails(reservationID); // Usa el método que te mostré antes

            if (reservation.Rows.Count > 0)
            {
                DataRow row = reservation.Rows[0];

                usercomboBox.SelectedValue = Convert.ToInt32(row["user_id"]);

                eventscomboBox.SelectedValue = Convert.ToInt32(row["event_id"]);
            }
            else
            {
                MessageBox.Show("No se encontraron datos para esta reserva.");
            }
        }
    }
}
