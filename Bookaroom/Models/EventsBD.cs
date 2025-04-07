using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

        public static bool DeleteEvent(int eventId)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Esdeveniments SET ACTIU = @actiu WHERE id_esdeveniment = @id", Bd.connexioJose);
            try
            {
                bool actiu = false;
                cmd.Parameters.AddWithValue("@id", eventId);
                cmd.Parameters.AddWithValue("@actiu", 1);

                Bd.connexioJose.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                cmd.Dispose();
                Bd.connexioJose.Close();
            }
        }

        public static bool AddEvent(string email, string name, string surnames, string password, int roleid, int actiu)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Bd.connexioJose;
            command.CommandText = "INSERT INTO Usuaris (email, nom, cognom, pass,rols) VALUES (@Email, @Name, @Surnames, @Password,@Active,@Role)";
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Name", name);
           command.Parameters.AddWithValue("@Surnames", surnames);
           command.Parameters.AddWithValue("@Active", actiu);
            command.Parameters.AddWithValue("@Role", roleid);

            try
            {
                Bd.connexioJose.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
                return false;
            }
            finally
            {
                Bd.connexioJose.Close();
            }
        }
        public static bool ModifyEvent(int eventID,int capacity, string name, DateTime dataini, DateTime dateend, int price)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = Bd.connexioJose;
            command.CommandText = "UPDATE Esdeveniments (capacity, name, dataini, dataend, price) VALUES (@capacity, @Name, @dataini, @dataend,@price) where id_esdeveniment = @eventid";
            command.Parameters.AddWithValue("@capacity", capacity);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@dataini", dataini);
            command.Parameters.AddWithValue("@dataend", dateend);
            command.Parameters.AddWithValue("@price", price);

            try
            {
                Bd.connexioJose.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
                return false;
            }
            finally
            {
                Bd.connexioJose.Close();
            }
        }


        public static DataTable GetEvent(int eventID)
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
                SELECT e.id_esdeveniment, e.nombre, e.aforament, e.data_inici, e.data_fi, e.preu
                FROM Esdeveniments e
                WHERE e.id_esdeveniment = @id", Bd.connexioJose);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Parameters.AddWithValue("@id", eventID);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading event: {ex.Message}");
            }

            return dt;
        }
    }
}
