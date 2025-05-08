using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bookaroom.Models.TicketsOrm;

namespace Bookaroom.Models
{
    public static class TicketsOrm
    {

        public class EntradaDTO
        {
            public int TicketId { get; set; }
            public string UserName { get; set; }
            public string EventName { get; set; }
            public string Email { get; set; }
            public int? RowColumn { get; set; }
            public int? SeatNumber { get; set; }
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
                              SeatNumber = asienton.seat_number

                          }).ToList();

            return result;
        }
    }
}
