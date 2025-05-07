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
            SELECT e.event_id,e.room_id ,u.name as nom_usuari,e.capacity,e.start_date,e.end_date,e.price,e.name,e.description
            FROM Esdeveniments e
            JOIN Usuaris u ON e.user_id = u.user_id
            WHERE e.active = 1", Bd.connexioJose);

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
            SqlCommand cmd = new SqlCommand("UPDATE Esdeveniments SET active = @actiu WHERE event_id = @id", Bd.connexioJose);
            try
            {
                int actiu = 0;
                cmd.Parameters.AddWithValue("@id", eventId);
                cmd.Parameters.AddWithValue("@actiu", actiu);

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

        public static bool AddEvent(string name,int price, string description, int capacity, DateTime datetimeini, DateTime datetimeend,int id_user,int id_room, int active)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Bd.connexioJose;

            command.CommandText = "INSERT INTO Esdeveniments (name, description, start_date, end_date, price, capacity,room_id,user_id,active) " +
                                  "VALUES (@Name, @Description, @DataIni, @DataEnd, @Price, @Capacity, @Id_room, @Id_user, @Active)";

            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@DataIni", datetimeini);
            command.Parameters.AddWithValue("@DataEnd", datetimeend);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@Capacity", capacity);
            command.Parameters.AddWithValue("@Id_room", id_room);
            command.Parameters.AddWithValue("@Id_user", id_user);
            command.Parameters.AddWithValue("@Active", active);


            try
            {
                Bd.connexioJose.Open();
                int resultInsert = command.ExecuteNonQuery();
                return resultInsert > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding event: {ex.Message}");
                return false;
            }
            finally
            {
                Bd.connexioJose.Close();
            }
        }
        public static bool EventConflictExists(DateTime startDate, DateTime endDate, int roomId)
        {
            SqlCommand cmd = new SqlCommand(@"
        SELECT COUNT(*) 
        FROM Esdeveniments 
        WHERE room_id = @RoomId AND active = 1
        AND (
            (@StartDate BETWEEN start_date AND end_date)
            OR (@EndDate BETWEEN start_date AND end_date)
            OR (start_date BETWEEN @StartDate AND @EndDate)
            OR (end_date BETWEEN @StartDate AND @EndDate)
        )", Bd.connexioJose);

            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
            cmd.Parameters.AddWithValue("@RoomId", roomId);

            try
            {
                Bd.connexioJose.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking event conflict: {ex.Message}");
                return true;
            }
            finally
            {
                Bd.connexioJose.Close();
            }
        }


    }
    }

