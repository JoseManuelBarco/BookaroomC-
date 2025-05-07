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
    internal class Users
    {
        public static DataTable GetUsers()
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
              SELECT u.user_id,
               u.name,
               u.surname,
               u.email,
               u.role,
               CASE 
                   WHEN u.active = 1 THEN 'Activo'
                   WHEN u.active = 0 THEN 'Inactivo'
               END AS status
              FROM Usuaris u", Bd.connexioJose);

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
           public static DataTable GetUser(int userID)
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
            SELECT u.user_id,u.name, u.surname, u.email FROM Usuaris u where user_id=@id", Bd.connexioJose);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Parameters.AddWithValue("@id", userID);
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
