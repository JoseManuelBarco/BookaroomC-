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
        }
        private void LoadDataIntoPreExistingColumns()
        {
            try
            {
                eventDataGridView.Rows.Clear();

                DataTable usersTable = EventsBD.GetEvents();
                foreach (DataRow row in usersTable.Rows)
                {
                    int rowIndex = eventDataGridView.Rows.Add();
                    eventDataGridView.Rows[rowIndex].Cells["Id_esdeveniment"].Value = row["id_esdeveniment"];
                    eventDataGridView.Rows[rowIndex].Cells["id_sala"].Value = row["id_sala"];
                    eventDataGridView.Rows[rowIndex].Cells["id_usuari"].Value = row["nom_usuari"];
                    eventDataGridView.Rows[rowIndex].Cells["Nom"].Value = row["nombre"];
                    eventDataGridView.Rows[rowIndex].Cells["descripcio"].Value = row["descripcio"];
                    eventDataGridView.Rows[rowIndex].Cells["aforament"].Value = row["aforament"];
                    eventDataGridView.Rows[rowIndex].Cells["Data_Inici"].Value = row["data_inici"];
                    eventDataGridView.Rows[rowIndex].Cells["Data_fi"].Value = row["data_fi"];
                    eventDataGridView.Rows[rowIndex].Cells["Preu"].Value = row["preu"];




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
    }
}
