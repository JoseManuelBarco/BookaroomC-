using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookaroom.Models
{
    internal class Bd
    {
        public static SqlConnection connexioJose = new SqlConnection("Server=localhost;Database=bookaroom;User Id=jose;Password=jose1234;");
        public static SqlConnection connexioEric = new SqlConnection("Server=localhost;Database=bookaroom;User Id=ericp;Password=1234;");

    }
}
