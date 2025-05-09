using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Bookaroom.Models.TicketsOrm;

namespace Bookaroom.Models
{
    public  class TicketsOrm
    {
        public class EntradaDTO
        {
            public int TicketId { get; set; }
            public string UserName { get; set; }
            public string EventName { get; set; }
            public string Email { get; set; }
            public int? RowColumn { get; set; }
            public int? SeatNumber { get; set; }
            public int? Status { get; set; }
        }

        public static List<EntradaDTO> SelectEntradesAmbDetalls()
        {
            var result = (from entrada in Orm.bd.Entrades
                          join usuari in Orm.bd.Usuaris on entrada.user_id equals usuari.user_id
                          join evente in Orm.bd.Esdeveniments on entrada.event_id equals evente.event_id
                          join asienton in Orm.bd.Butaca on entrada.seat_id equals asienton.seat_id


                          select new EntradaDTO
                          {
                              TicketId = entrada.ticket_id,
                              UserName = usuari.name,
                              EventName = evente.name,
                              Email = usuari.email,
                              RowColumn = asienton.row_number,
                              SeatNumber = asienton.seat_number,
                              Status = entrada.status

                          }).ToList();

            return result;
        }

        public static bool ToggleActiveStatus(int ticketID)
        {
            try
            {
                var ticket = Orm.bd.Entrades.FirstOrDefault(e => e.ticket_id == ticketID);

                if (ticket == null)
                {
                    MessageBox.Show("Ticket no encontrado.");
                    return false;
                }

                ticket.status = ticket.status == 1 ? 0 : 1;

                Orm.bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al canviar l'estat de l'usuari: {ex.Message}");
                return false;
            }
        }

        public static bool InsertTicket(int userId, int eventId, int seatId, int status)
        {
            try
            {
                Entrades newTicket = new Entrades
                {
                    user_id = userId,
                    event_id = eventId,
                    seat_id = seatId,
                    status = status
                };

                Orm.bd.Entrades.Add(newTicket);
                Orm.bd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserint usuari: {ex.Message}");
                return false;
            }

        }
        public static bool UpdateTicket(int userId, int eventId, int seatId, int reservationid)
        {
            try
            {
                var existingTicket = Orm.bd.Entrades.FirstOrDefault(t => t.ticket_id == reservationid);

                if (existingTicket == null)
                {
                    MessageBox.Show("Ticket no encontrado.");
                    return false;
                }

                existingTicket.user_id = userId;
                existingTicket.event_id = eventId;
                existingTicket.seat_id = seatId;

                Orm.bd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error actualizando la reserva: {ex.Message}");
                return false; 
            }
        }
       
        public static List<Butaca> GetAvailableSeatsBySalaId(int salaId)
        {
            try
            {
                var occupiedSeatIds = Orm.bd.Entrades
                    .Where(e => e.seat_id != null)
                    .Select(e => e.seat_id)
                    .ToList();

                var availableSeats = Orm.bd.Butaca
                    .Where(b => b.room_id == salaId && !occupiedSeatIds.Contains(b.seat_id))
                    .ToList();

                return availableSeats;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando butacas: {ex.Message}");
                return new List<Butaca>();
            }
        }

        public static List<Butaca> GetSeatsBySalaId(int salaId)
        {
            try
            {
                var occupiedSeatIds = Orm.bd.Entrades
                    .Where(e => e.seat_id != null)
                    .Select(e => e.seat_id)
                    .ToList();

                var availableSeats = Orm.bd.Butaca
                    .Where(b => b.room_id == salaId && !occupiedSeatIds.Contains(b.seat_id))
                    .ToList();

                return availableSeats;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando butacas: {ex.Message}");
                return new List<Butaca>();
            }
        }
    }
}
