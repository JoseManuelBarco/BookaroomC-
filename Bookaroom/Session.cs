using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookaroom
{
    public static class Session
    {
        public static string Email { get; set; }
        public static string Rol { get; set; }
        public static int Id { get; set; } // Si también quieres guardar el ID del usuario
    }
}
