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
                    int active = users.GetInt32(6);
                    if (active == 1)
                    {
                        valid = true;
                    }
                    else
                    {
                        MessageBox.Show("Tu cuenta está inactiva. Contacta con el administrador.", "Cuenta Inactiva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }

            Bd.connexioJose.Close();
            users.Close();
            return valid;
        }
        public static string checkRol(string email)
        {
            string role = null;

            SqlCommand sentence = new SqlCommand();
            SqlDataReader users;
            sentence.Connection = Bd.connexioJose;
            sentence.CommandText = "SELECT role FROM Usuaris WHERE email = @Email";
            sentence.Parameters.AddWithValue("@Email", email);

            Bd.connexioJose.Open();

            users = sentence.ExecuteReader();

            if (users.HasRows)
            {
                users.Read();
                role = users.GetString(0);  
            }
            else
            {
                MessageBox.Show("Usuari no trobat");
            }

            Bd.connexioJose.Close();
            users.Close();

            return role; 
        }
        public static DataTable GetUsers()
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
              SELECT u.user_id,
               u.name,
               u.surname,
               u.email,
               u.role,
               CASE 
                   WHEN u.active = 1 THEN 'Activo'
                   WHEN u.active = 0 THEN 'Inactivo'
               END AS status
              FROM Usuaris u", Bd.connexioJose);

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
           public static DataTable GetUser(int userID)
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
            SELECT u.user_id,u.name, u.surname, u.email FROM Usuaris u where user_id=@id", Bd.connexioJose);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Parameters.AddWithValue("@id", userID);
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
