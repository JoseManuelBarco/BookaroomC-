using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookaroom.Models
{
    internal class Users
    {
        public static bool checkUserBD(string email, string password)
        {
            bool valid = false;

            SqlCommand sentence = new SqlCommand();
            SqlDataReader users;
            sentence.Connection = Bd.connexioJose;
            sentence.CommandText = "SELECT * FROM Usuaris WHERE email = @Email";
            sentence.Parameters.AddWithValue("@Email", email);

            Bd.connexioJose.Open();

            users = sentence.ExecuteReader();

            if (users.HasRows)
            {
                users.Read();

                string passwordEncrypted = users.GetString(4);

                if (BCrypt.Net.BCrypt.EnhancedVerify(password, passwordEncrypted, BCrypt.Net.HashType.SHA512))
                {

                    MessageBox.Show("Usuari trobat. Benvigut");
                    valid = true;
                }
                else
                {
                    MessageBox.Show("Contrasenya incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuari no trobat");
            }

            Bd.connexioJose.Close();
            users.Close();
            return valid;
        }
        public static DataTable GetUsers()
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
            SELECT u.id_usuari, u.nom, u.cognom, u.email, u.rol FROM Usuaris u", Bd.connexioJose);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }

            return dt;
        }
    }
}
