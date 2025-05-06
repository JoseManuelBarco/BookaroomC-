using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookaroom.Models
{
    internal class SeatsOrm
    {
        public static List<Butaca> Select()
        {
            List<Butaca> _seats = Orm.bd.Butaca
                .ToList();
            return _seats;
        }

    }
}
