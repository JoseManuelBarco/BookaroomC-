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
                eventcomboBox.DisplayMember = "nombre";
                eventcomboBox.ValueMember = "id_esdeveniment";

                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
                foreach (DataRow row in events.Rows)
                {
                    string fullName = $"{row["nombre"]}";
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
                usercomboBox.DisplayMember = "nom";
                usercomboBox.ValueMember = "id_usuari";

                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
                foreach (DataRow row in users.Rows)
                {
                    string fullName = $"{row["nom"]}";
                    autoComplete.Add(fullName);
                }

                usercomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                usercomboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                usercomboBox.AutoCompleteCustomSource = autoComplete;
            }
        }

        private void seatcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eventcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventcomboBox.SelectedItem is DataRowView selectedRow)
            {
                if (selectedRow.Row.Table.Columns.Contains("id_sala"))
                {
                    try
                    {
                        int idSala = Convert.ToInt32(selectedRow["id_sala"]);
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
        private void LoadSeatsComboBox(int salaId)
        {
            DataTable seats = Rooms.GetSeatsBySalaId(salaId);

            if (seats.Rows.Count > 0)
            {
                seatcomboBox.DataSource = seats;
                seatcomboBox.DisplayMember = "numero_butaca";
                seatcomboBox.ValueMember = "id_butaca";
            }
            else
            {
                seatcomboBox.DataSource = null;
            }
        }

        private void savechangesbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
