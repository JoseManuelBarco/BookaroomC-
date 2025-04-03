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
    public partial class ReservaTable : Form
    {
        public ReservaTable()
        {
            InitializeComponent();
            LoadDataIntoPreExistingColumns();
            reservationDataGridView.RowHeadersVisible = false;
            reservationDataGridView.EnableHeadersVisualStyles = false;
            reservationDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            reservationDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            reservationDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 196, 153);
            reservationDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        }
        
        private void LoadDataIntoPreExistingColumns()
        {
            try
            {
                reservationDataGridView.Rows.Clear();

                DataTable usersTable = ReserveBD.GetTickets();
                foreach (DataRow row in usersTable.Rows)
                {
                    int rowIndex = reservationDataGridView.Rows.Add();
                    reservationDataGridView.Rows[rowIndex].Cells["id_entrada"].Value = row["id_entrada"];
                    reservationDataGridView.Rows[rowIndex].Cells["id_usuari"].Value = row["nom_usuari"];
                    reservationDataGridView.Rows[rowIndex].Cells["numero_butaca"].Value = row["numero_butaca"];
                    reservationDataGridView.Rows[rowIndex].Cells["numero_fila"].Value = row["numero_fila"];
                    reservationDataGridView.Rows[rowIndex].Cells["id_esdeveniment"].Value = row["nom_event"];
                    reservationDataGridView.Rows[rowIndex].Cells["email"].Value = row["email"];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void filterdateinilabel_Click(object sender, EventArgs e)
        {
           
        }

        private void filterdateendlabel_Click(object sender, EventArgs e)
        {
           
        }

        private void capacityfilterlabel_Click(object sender, EventArgs e)
        {
          
        }
    }
    }

