using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookaroom.Models
{
    internal class EventsBD
    {
         public static DataTable GetEvents()
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
            SELECT e.id_esdeveniment,e.id_sala,u.nom as nom_usuari,e.aforament,e.data_inici,e.data_fi,e.preu,e.nombre,e.descripcio
            FROM Esdeveniments e
            JOIN Usuaris u ON e.id_usuari = u.id_usuari", Bd.connexioJose);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }

            return dt;
        }
    }
}
