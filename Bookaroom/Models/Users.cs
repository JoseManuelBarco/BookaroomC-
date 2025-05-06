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
                        MessageBox.Show("Usuario encontrado. Bienvenido.");
                        valid = true;
                    }
                    else
                    {
                        MessageBox.Show("Tu cuenta está inactiva. Contacta con el administrador.", "Cuenta Inactiva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    MessageBox.Show("Contraseña incorrecta.");
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
            string role = null; // Valor predeterminado si el usuario no tiene rol

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
                role = users.GetString(0);  // Obtiene el valor del rol (suponiendo que 'role' es la primera columna)
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
        public static bool AddUser(string email, string name, string surnames, string password, string role, int actiu)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Bd.connexioJose;
            command.CommandText = "INSERT INTO Usuaris (email, name, surname, password, role, active) VALUES (@Email, @Name, @Surnames, @Password,@Role,@Active)";

            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Surnames", surnames);
            command.Parameters.AddWithValue("@Password", BCrypt.Net.BCrypt.EnhancedHashPassword(password, BCrypt.Net.HashType.SHA512));// BCrypt.Net.BCrypt.EnhancedHashPassword(password, BCrypt.Net.HashType.SHA512));
            command.Parameters.AddWithValue("@Active", actiu);
            command.Parameters.AddWithValue("@Role", role);

            try
            {
                Bd.connexioJose.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
                return false;
            }
            finally
            {
                Bd.connexioJose.Close();
            }
        }
        public static bool DeleteUser(int userId)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Usuaris SET active = @actiu WHERE user_id = @id", Bd.connexioJose);
            try
            {
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@actiu",0); 

                Bd.connexioJose.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                cmd.Dispose();
                Bd.connexioJose.Close();
            }
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

        public static bool ResetPassword(int userId)
        {
            SqlCommand command = new SqlCommand("UPDATE Usuaris SET password = @newPassword WHERE user_id = @userId", Bd.connexioJose);

            string newPassword = "reset123";

            string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(newPassword, BCrypt.Net.HashType.SHA512);

            command.Parameters.AddWithValue("@newPassword", hashedPassword);
            command.Parameters.AddWithValue("@userId", userId);

            try
            {
                Bd.connexioJose.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al restablecer la contraseña: {ex.Message}");
                return false;
            }
            finally
            {
                Bd.connexioJose.Close();
            }
        }
    }
}
