using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookaroom.Models
{
    internal class ReserveBD
    {

        public static DataTable GetTickets()
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
            SELECT e.id_entrada,u.nom as nom_usuari,u.email,ev.nombre as nom_event,b.numero_fila,b.numero_butaca
            FROM Entrades e
            JOIN Usuaris u ON e.id_usuari = u.id_usuari
            JOIN Esdeveniments ev ON e.id_esdeveniment=ev.id_esdeveniment
            JOIN Butaca b ON e.id_butaca = b.id_butaca", Bd.connexioJose);

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
