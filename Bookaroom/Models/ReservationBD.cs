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

        public static bool SaveReservation(int userId, int eventId, int seatId, int status)
        {
            SqlConnection conn = Bd.connexioJose;
            SqlTransaction transaction = null;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                SqlCommand insertCommand = new SqlCommand(@"
                INSERT INTO Entrades (user_id, event_id, seat_id,status)
                VALUES (@UserId, @EventId, @SeatId, @Status)", conn, transaction);

                insertCommand.Parameters.AddWithValue("@UserId", userId);
                insertCommand.Parameters.AddWithValue("@EventId", eventId);
                insertCommand.Parameters.AddWithValue("@SeatId", seatId);
                insertCommand.Parameters.AddWithValue("@Status", status);


                int result = insertCommand.ExecuteNonQuery();
                if (result <= 0)
                {
                    transaction.Rollback();
                    return false;
                }

                SqlCommand updateCommand = new SqlCommand(@"
                UPDATE Butaca
                SET status = 'Reserved'
                WHERE seat_id = @SeatId", conn, transaction);

                updateCommand.Parameters.AddWithValue("@SeatId", seatId);

                int updateResult = updateCommand.ExecuteNonQuery();
                if (updateResult <= 0)
                {
                    transaction.Rollback();
                    return false;
                }


                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show($"Error al guardar la reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool DeleteReservation(int reservationid)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Entrades SET status = @actiu WHERE ticket_id = @id", Bd.connexioJose);
            try
            {
                cmd.Parameters.AddWithValue("@id", reservationid);
                cmd.Parameters.AddWithValue("@actiu", 0);

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

        public static DataTable GetReservationDetails(int ticketId)
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
              SELECT e.ticket_id, u.user_id, u.name AS user_name, u.email,e.seat_id,
               ev.event_id, ev.name AS event_name,
               b.seat_id, b.seat_number, b.row_number
             FROM Entrades e
             JOIN Usuaris u ON e.user_id = u.user_id
             JOIN Esdeveniments ev ON e.event_id = ev.event_id
             JOIN Butaca b ON e.seat_id = b.seat_id
             WHERE e.ticket_id = @TicketId", Bd.connexioJose);

            command.Parameters.AddWithValue("@TicketId", ticketId);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando la reserva: {ex.Message}");
            }

            return dt;
        }
    }
    }
