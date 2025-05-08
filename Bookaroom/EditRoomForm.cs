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
    public partial class EditRoomForm : Form
    {
        int roomId;
        public EditRoomForm(int roomId)
        {
            InitializeComponent();
            this.roomId = roomId;
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            try
            {
                var roomData = RoomsOrm.GetRooms(roomId);

                if (roomData != null)
                {
                    sizetextBox.Text = roomData.dimensions.ToString();
                    capacitytextBox.Text = roomData.max_capacity.ToString();
                    seatsnumbertextBox.Text = roomData.num_seats.ToString(); 
                }
                else
                {
                    MessageBox.Show("Evento no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void savechangesbutton_Click(object sender, EventArgs e)
        {
            int roomIDSend = roomId;
            int size = int.Parse(sizetextBox.Text);
            int maxseats = int.Parse(seatsnumbertextBox.Text);
            int capacity = int.Parse(capacitytextBox.Text);

            if (capacity < 0 || capacity > 30)
            {
                MessageBox.Show("El aforo debe estar entre 0 y 30.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (RoomsOrm.ModifyRoom(roomIDSend, capacity, maxseats, size))
            {
                MessageBox.Show("Sala modificada correctament", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al añadir la sala. Por favor vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
