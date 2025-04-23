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
    internal class Rooms
    {
        public static DataTable GetRooms()
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
            SELECT room_id FROM Sales ", Bd.connexioJose);

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

        public static DataTable GetSeatsBySalaId(int salaId)
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
        SELECT seat_id,seat_number,row_number
        FROM Butaca 
        WHERE room_id = @SalaId and status='Available'", Bd.connexioJose);

            command.Parameters.AddWithValue("@SalaId", salaId);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando butacas: {ex.Message}");
            }

            return dt;

        }

        public static DataTable GetSeatsForEdit(int salaId, int seatid)
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
        SELECT seat_id, seat_number, row_number
        FROM Butaca
        WHERE room_id = @SalaId 
        AND (status = 'Available' OR seat_id = @CurrentSeatId)", Bd.connexioJose);

            command.Parameters.AddWithValue("@SalaId", salaId);
            command.Parameters.AddWithValue("@CurrentSeatId", seatid);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando butacas: {ex.Message}");
            }

            return dt;
        }
    }
    }

