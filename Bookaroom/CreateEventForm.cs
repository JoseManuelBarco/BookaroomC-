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
    public partial class CreateEventForm : Form
    {
        public CreateEventForm()
        {
            InitializeComponent();
            dateinidateTimePicker.Value = DateTime.Now;
            dataenddateTimePicker.Value = DateTime.Now;
            LoadUsersComboBox();
            LoadRoomsComboBox();
        }
        private void LoadUsersComboBox()
        {
            DataTable users = Users.GetUsers();

            if (users.Rows.Count > 0)
            {
                userscomboBox.DataSource = users;
                userscomboBox.DisplayMember = "name";
                userscomboBox.ValueMember = "user_id";

                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
                foreach (DataRow row in users.Rows)
                {
                    string fullName = $"{row["name"]}";
                    autoComplete.Add(fullName);
                }

                userscomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                userscomboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                userscomboBox.AutoCompleteCustomSource = autoComplete;
            }
        }
        private void LoadRoomsComboBox()
        {
            DataTable rooms = Rooms.GetRooms();

            if (rooms.Rows.Count > 0)
            {
              
                }
                roomcomboBox.DataSource = rooms;
                roomcomboBox.DisplayMember = "room_id";
                roomcomboBox.ValueMember = "room_id";

                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
                foreach (DataRow row in rooms.Rows)
                {
                    autoComplete.Add(row["room_id"].ToString());
                }

                roomcomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                roomcomboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                roomcomboBox.AutoCompleteCustomSource = autoComplete;
            }
        
        private void savebutton_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text.Trim();
            string description = descriptiontextBox.Text;
            DateTime dateTimeini = dateinidateTimePicker.Value;
            DateTime dateTimeend = dataenddateTimePicker.Value;
            int id_user;
            int id_room;
            int actiu = 0;
            int price = 0;
            int capacity = 0;

            if (userscomboBox.SelectedValue != null &&  roomcomboBox.SelectedValue !=null &&
                 int.TryParse(userscomboBox.SelectedValue.ToString(), out id_user) &&
                 int.TryParse(pricetextBox.Text, out price) &&
                 int.TryParse(capacitytextBox.Text, out capacity)&&
                 int.TryParse(roomcomboBox.Text, out id_room))
            {
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Todos los campos son necesarios.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (EventsBD.AddEvent(name, price, description, capacity, dateTimeini, dateTimeend, id_user, id_room))
                {
                    MessageBox.Show("Usuari afegit correctament", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al añadir el usuario. Por favor vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Datos inválidos. Verifica que todos los valores sean correctos.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
