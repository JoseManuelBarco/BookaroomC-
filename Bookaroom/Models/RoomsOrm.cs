using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookaroom.Models
{
    public static class RoomsOrm
    { 
            public static List<Sales> Select()
            {
                List<Sales> _rooms = Orm.bd.Sales
                    .OrderBy(e => e.room_id)
                    .ToList();

                return _rooms;
            }
        public static Sales GetRooms(int roomid)
        {
            return Orm.bd.Sales
                .FirstOrDefault(e => e.room_id == roomid);
        }

        public static bool InsertRooms(int size, int maxCapacity,int maxSeats, int actiu)
        {
            try
            {
                Sales newRoom = new Sales
                {
                    dimensions = size,
                    max_capacity = maxCapacity,
                    num_seats =maxSeats,
                    status = actiu
                };

                Orm.bd.Sales.Add(newRoom);
                Orm.bd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserint usuari: {ex.Message}");
                return false;
            }
        }
        public static bool ToggleActiveStatus(int roomid)
        {
            try
            {
                var room = Orm.bd.Sales.FirstOrDefault(r => r.room_id == roomid);

                if (room == null)
                {
                    MessageBox.Show("Usuari no trobat.");
                    return false;
                }

                room.status = room.status == 1 ? 0 : 1;

                Orm.bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al canviar l'estat de la sala: {ex.Message}");
                return false;
            }
        }
        public static bool ModifyRoom(int roomID, int capacity,int maxseats, int size)
        {
            try
            {
                var eventToModify = Orm.bd.Sales.FirstOrDefault(r => r.room_id == roomID);

                if (eventToModify == null)
                {
                    MessageBox.Show("Sala no encontrada.");
                    return false;
                }

                eventToModify.max_capacity = capacity;
                eventToModify.num_seats = maxseats;
                eventToModify.dimensions = size;

                Orm.bd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el evento: {ex.Message}");
                return false;
            }
        }
    }
}
