using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookaroom.Models
{
    public static class EventsOrm
    {
   
        
        public static List<Esdeveniments> Select()
        {
            List<Esdeveniments> _esdeveniments = Orm.bd.Esdeveniments
                .OrderBy(e => e.name)
                .ToList();

            return _esdeveniments;
        }

        public static Esdeveniments GetEvent(int eventID)
        {
            return Orm.bd.Esdeveniments
                .FirstOrDefault(e => e.event_id == eventID);  
        }
        public static bool ModifyEvent(int eventID, int capacity, string name, DateTime dataini, DateTime dateend, int price)
        {
            try
            {
                var eventToModify = Orm.bd.Esdeveniments.FirstOrDefault(e => e.event_id == eventID);

                if (eventToModify == null)
                {
                    MessageBox.Show("Evento no encontrado.");
                    return false;
                }

                eventToModify.capacity = capacity;
                eventToModify.name = name;
                eventToModify.start_date = dataini;
                eventToModify.end_date = dateend;
                eventToModify.price = price;

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

