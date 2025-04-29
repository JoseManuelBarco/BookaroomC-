using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

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
        SELECT b.seat_id,b.seat_number,b.row_number
        FROM Butaca as b
        JOIN Entrades as e on b.seat_id = e.seat_id
        WHERE e.room_id = @SalaId  AND 
            b.seat_id NOT IN (
                SELECT e.seat_id FROM Entrades e WHERE e.seat_id IS NOT NULL
            ", Bd.connexioJose);

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
        public static int GetSeatAssigned(int reservationid)
        {
            int seatid = 0;

            SqlCommand command = new SqlCommand(@"
        SELECT e.seat_id FROM Entrades as e
        JOIN Esdeveniments as es on e.event_id=es.event_id
        WHERE e.ticket_id = @Reservationid", Bd.connexioJose);

            command.Parameters.AddWithValue("@Reservationid", reservationid);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    seatid = Convert.ToInt32(dt.Rows[0]["seat_id"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando butacas: {ex.Message}");
            }

            return seatid;
        }
        public static int GetRoomAssigned(int reservationid)
        {
            int seatid = 0;

            SqlCommand command = new SqlCommand(@"
        SELECT es.room_id FROM Esdeveniments as es
        JOIN Entrades as e on e.event_id=es.event_id
        WHERE e.ticket_id = @Reservationid", Bd.connexioJose);

            command.Parameters.AddWithValue("@Reservationid", reservationid);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    seatid = Convert.ToInt32(dt.Rows[0]["room_id"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando butacas: {ex.Message}");
            }

            return seatid;
        }




        public static DataTable GetSeatsForEdit(int salaId, int seatid)
        {
            DataTable dt = new DataTable();

                            SqlCommand command = new SqlCommand(@"
                             SELECT 
            b.seat_id,
            b.seat_number,
            b.row_number
        FROM Butaca b
        WHERE b.room_id = @SalaID
        AND (
            b.seat_id = @SeatID
            OR b.seat_id NOT IN (
                SELECT e.seat_id FROM Entrades e WHERE e.seat_id IS NOT NULL
            )
        )", Bd.connexioJose);

            command.Parameters.AddWithValue("@SalaID", salaId);
            command.Parameters.AddWithValue("@SeatID", seatid);

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

