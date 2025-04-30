using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookaroom.Models
{
    internal class UsersOrm
    {
        public static List<Usuaris> Select()
        {
            List<Usuaris> _usuaris = Orm.bd.Usuaris
                .ToList();

            return _usuaris;
        }
    }
}
