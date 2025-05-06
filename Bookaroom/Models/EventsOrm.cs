using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}

