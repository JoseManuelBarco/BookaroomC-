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
            dateinidateTimePicker.Format = DateTimePickerFormat.Custom;
            dateinidateTimePicker.CustomFormat = "yyyy-MM-dd";
            dataenddateTimePicker.Format = DateTimePickerFormat.Custom;
            dataenddateTimePicker.CustomFormat = "yyyy-MM-dd";

       //     AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
       //     roomcomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
       //     roomcomboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
       //     roomcomboBox.AutoCompleteCustomSource = autoComplete;


       //     userscomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
       //     userscomboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
       //     userscomboBox.AutoCompleteCustomSource = autoComplete;
        }
        
        private void savebutton_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text.Trim();
            string description = descriptiontextBox.Text;
            DateTime dateTimeini = dateinidateTimePicker.Value.Date;
            DateTime dateTimeend = dataenddateTimePicker.Value.Date;
            int id_user;
            int id_room;
            int active = 0;
            int price = 0;
            int capacity = 0;

            if (activecheckbox.Checked)
            {
                active = 1;

            }

            if (userscomboBox.SelectedValue != null &&  roomcomboBox.SelectedValue !=null &&
                 int.TryParse(userscomboBox.SelectedValue.ToString(), out id_user) &&
                 int.TryParse(pricetextBox.Text, out price) &&
                 int.TryParse(capacitytextBox.Text, out capacity)&&
                 int.TryParse(roomcomboBox.Text, out id_room))
            {
                if (capacity < 0 || capacity > 30)
                {
                    MessageBox.Show("El aforo debe estar entre 0 y 30.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Todos los campos son necesarios.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (EventsBD.EventConflictExists(dateTimeini, dateTimeend, id_room))
                {
                    MessageBox.Show("Ya hay un evento registrado en esta sala durante este período.", "Conflicto de evento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (EventsBD.AddEvent(name, price, description, capacity, dateTimeini, dateTimeend, id_user, id_room, active))
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

        private void CreateEventForm_Load(object sender, EventArgs e)
        {
            bindingSourceUsers.DataSource = UsersOrm.Select();
            userscomboBox.DisplayMember = "name";
            userscomboBox.ValueMember = "user_id";

            bindingSourceRooms.DataSource = RoomsOrm.Select();
            roomcomboBox.DisplayMember = "room_id";
            roomcomboBox.ValueMember = "room_id";   
       
        }
    }
}
