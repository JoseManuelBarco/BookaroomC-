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
            DataTable eventData = EventsBD.GetEvent(eventID);
            DataRow row = eventData.Rows[0];


            nomtextBox.Text = row["name"].ToString();
            capacitytextBox.Text = row["capacity"].ToString();  
            datainidateTimePicker.Value = Convert.ToDateTime(row["start_date"]);  
            dataenddateTimePicker.Value = Convert.ToDateTime(row["end_date"]); 
            pricetextBox.Text = row["price"].ToString();
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


            if (EventsBD.ModifyEvent(eventIDSend, capacity, name, dataini, dataend, price))
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
