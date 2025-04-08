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
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text.Trim();
            string description = descriptiontextBox.Text;
            DateTime dateTimeini = dateinidateTimePicker.Value;
            DateTime dateTimeend = dataenddateTimePicker.Value;
            int actiu = 0;
            int price = 0;
            int capacity = 0;

            if (int.TryParse(pricetextBox.Text, out price)||int.TryParse(capacitytextBox.Text, out capacity))
            {
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Todos los campos son necesarios.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (EventsBD.AddEvent(name, price, description, capacity, dateTimeini, dateTimeend))
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
                MessageBox.Show("El valor introduït no és un número vàlid.");
            }
                      
        }
    }
}
