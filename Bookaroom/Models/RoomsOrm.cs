using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookaroom.Models
{
    public static class RoomsOrm
    { 
            public static List<Sales> Select()
            {
                List<Sales> _esdeveniments = Orm.bd.Sales
                    .OrderBy(e => e.room_id)
                    .ToList();

                return _esdeveniments;
            }

       
    }
}
