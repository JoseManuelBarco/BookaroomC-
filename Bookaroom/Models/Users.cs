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

                //if (BCrypt.Net.BCrypt.EnhancedVerify(password, passwordEncrypted, BCrypt.Net.HashType.SHA512))
                if(password == passwordEncrypted)
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
        public static string checkRol(string email)
        {
            string role = null; // Valor predeterminado si el usuario no tiene rol

            SqlCommand sentence = new SqlCommand();
            SqlDataReader users;
            sentence.Connection = Bd.connexioJose;
            sentence.CommandText = "SELECT rol FROM Usuaris WHERE email = @Email";
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
        public static bool AddUser(string email, string name, string surnames, string password, int roleid, int actiu)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Bd.connexioJose;
            command.CommandText = "INSERT INTO Usuaris (email, nom, cognom, pass,rols) VALUES (@Email, @Name, @Surnames, @Password,@Active,@Role)";

            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Surnames", surnames);
            command.Parameters.AddWithValue("@Password", password);// BCrypt.Net.BCrypt.EnhancedHashPassword(password, BCrypt.Net.HashType.SHA512));
            command.Parameters.AddWithValue("@Active", actiu);
            command.Parameters.AddWithValue("@Role", roleid);

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
            SqlCommand cmd = new SqlCommand("UPDATE usuaris SET ACTIU = @actiu WHERE id = @id", Bd.connexioJose);
            try
            {
                bool actiu = false;
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@actiu",1); 

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
            SELECT u.id_usuari,u.nom, u.cognom, u.email FROM Usuaris u where id_usuari=@id", Bd.connexioJose);

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
