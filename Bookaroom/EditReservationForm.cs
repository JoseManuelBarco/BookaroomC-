using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookaroom.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bookaroom
{
    public partial class EditReservationForm : Form
    {
        int reservationID;
        public EditReservationForm(int reservationIDD)
        {
            InitializeComponent();
            this.reservationID = reservationIDD;

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
        private void LoadReservationData()
        {
            DataTable reservation = ReserveBD.GetReservationDetails(reservationID); 

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



        private void savebutton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(usercomboBox.SelectedValue);
            int eventId = Convert.ToInt32(eventscomboBox.SelectedValue);
            int seatId = Convert.ToInt32(seatcomboBox.SelectedValue);

            bool result = TicketsOrm.UpdateTicket(userId, eventId, seatId, reservationID);

            if (result)
            {
                MessageBox.Show("Reserva actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
