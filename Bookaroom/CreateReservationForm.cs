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
        public CreateReservationForm()
        {
            InitializeComponent();
            LoadUsersComboBox();
            LoadEventsComboBox();

        }

        private void LoadEventsComboBox()
        {
            DataTable events = EventsBD.GetEvents();
            if (events.Rows.Count > 0)
            {
                eventcomboBox.DataSource = events;
                eventcomboBox.DisplayMember = "name";
                eventcomboBox.ValueMember = "event_id";

                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
                foreach (DataRow row in events.Rows)
                {
                    string fullName = $"{row["name"]}";
                    autoComplete.Add(fullName);
                }

                eventcomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                eventcomboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                eventcomboBox.AutoCompleteCustomSource = autoComplete;
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
        private void LoadSeatsComboBox(int salaId)
        {
            DataTable seats = Rooms.GetSeatsBySalaId(salaId);

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
            if (eventcomboBox.SelectedItem is DataRowView selectedRow)
            {
                if (selectedRow.Row.Table.Columns.Contains("room_id"))
                {
                    try
                    {
                        int idSala = Convert.ToInt32(selectedRow["room_id"]);
                        LoadSeatsComboBox(idSala);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener la sala: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("La columna 'id_sala' no está en el DataTable.");
                }
            }
        }

        private void savechangesbutton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(usercomboBox.SelectedValue);  // ID del usuario
            int eventId = Convert.ToInt32(eventcomboBox.SelectedValue); // ID del evento
            int seatId = Convert.ToInt32(seatcomboBox.SelectedValue);
            int status = 0;

            if (activecheckbox.Checked)
            {
                status = 1;

            }


            bool result = ReserveBD.SaveReservation(userId, eventId, seatId,status);
            this.Close();          
        }
    }
}
