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
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            int size, maxCapacity, maxSeats;

            int actiu = 0;

            if (activecheckbox.Checked)
            {
                actiu = 1;

            }
            if (!int.TryParse(sizetextBox.Text.Trim(), out size))
            {
                MessageBox.Show("Este campo debe de ser numerico.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(maxcapacitytextBox.Text.Trim(), out maxCapacity))
            {
                MessageBox.Show("Este campo debe de ser numerico.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(numerseatstextBox.Text.Trim(), out maxSeats))
            {
                MessageBox.Show("Este campo debe de ser numerico.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maxCapacity > 60)
            {
                MessageBox.Show("El maximo aforo posible por sola puede ser de 60.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maxSeats > 30)
            {
                MessageBox.Show("No puedes poner mas de 30 sillas.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                if (RoomsOrm.InsertRooms(size, maxCapacity, maxSeats,actiu))
                {
                    MessageBox.Show("Usuari afegit correctament", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                
          
        }
    }
}
