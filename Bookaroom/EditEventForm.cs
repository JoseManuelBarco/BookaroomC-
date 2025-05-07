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
    public partial class EditEventForm : Form
    {
        int eventID;
        public EditEventForm(int eventID)
        {
            InitializeComponent();
            this.eventID = eventID;
            LoadEventData();
        }
        private void LoadEventData()
        {
            try
            {
                var eventData = EventsOrm.GetEvent(eventID);

                if (eventData != null)
                {
                    nomtextBox.Text = eventData.name;
                    capacitytextBox.Text = eventData.capacity.ToString();
                    datainidateTimePicker.Value = eventData.start_date;
                    dataenddateTimePicker.Value = eventData.end_date;
                    pricetextBox.Text = eventData.price.ToString();
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


        private void button1_Click(object sender, EventArgs e)
        {
            int eventIDSend = eventID;
            string name = nomtextBox.Text.Trim();
            DateTime dataini = datainidateTimePicker.Value;
            DateTime dataend = dataenddateTimePicker.Value;            
            int price = int.Parse(capacitytextBox.Text);
            int capacity = int.Parse(capacitytextBox.Text);

            if (capacity < 0 || capacity > 30)
            {
                MessageBox.Show("El aforo debe estar entre 0 y 30.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (EventsOrm.ModifyEvent(eventIDSend, capacity, name, dataini, dataend, price))
                {
                    MessageBox.Show("Event modificat correctament", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al añadir el usuario. Por favor vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
