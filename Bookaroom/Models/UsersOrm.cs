using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookaroom.Models
{

    public static class UsersOrm
    {
        public static List<Usuaris> Select()
        {
            List<Usuaris> _usuaris = Orm.bd.Usuaris
                .ToList();

            return _usuaris;
        }

        public static bool InsertUser(string email, string name, string surname, string password, string role, int actiu)
        {
            try
            {
                Usuaris nouUsuari = new Usuaris
                {
                    email = email,
                    name = name,
                    surname = surname,
                    password = BCrypt.Net.BCrypt.EnhancedHashPassword(password, BCrypt.Net.HashType.SHA512),
                    role = role,
                    active = actiu
                };

                Orm.bd.Usuaris.Add(nouUsuari);
                Orm.bd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserint usuari: {ex.Message}");
                return false;
            }
        }
        public static string ResetPassword(int userId)
        {
            try
            {
                var usuari = Orm.bd.Usuaris.FirstOrDefault(u => u.user_id == userId);

                if (usuari == null)
                {
                    MessageBox.Show("Usuari no trobat.");
                    return null;
                }

                string randomSuffix = GenerateRandomString(8);
                string newPassword = "book" + randomSuffix;

                usuari.password = BCrypt.Net.BCrypt.EnhancedHashPassword(newPassword, BCrypt.Net.HashType.SHA512);

                Orm.bd.SaveChanges();
                return newPassword;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al restablir la contrasenya: {ex.Message}");
                return null;
            }
        }
        public static bool UpdateUser(int userId, string email, string name, string surname)
        {
            try
            {
                var usuari = Orm.bd.Usuaris.FirstOrDefault(u => u.user_id == userId);

                if (usuari == null)
                {
                    MessageBox.Show("Usuari no trobat.");
                    return false;
                }

                usuari.email = email;
                usuari.name = name;
                usuari.surname = surname;

                Orm.bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error actualitzant l'usuari: {ex.Message}");
                return false;
            }
        }
        public static bool ToggleActiveStatus(int userId)
        {
            try
            {
                var usuari = Orm.bd.Usuaris.FirstOrDefault(u => u.user_id == userId);

                if (usuari == null)
                {
                    MessageBox.Show("Usuari no trobat.");
                    return false;
                }

                usuari.active = usuari.active == 1 ? 0 : 1;

                Orm.bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al canviar l'estat de l'usuari: {ex.Message}");
                return false;
            }
        }
        public static bool checkUserBD(string email, string password)
        {
            bool valid = false;

            try
            {
                var usuari = Orm.bd.Usuaris.FirstOrDefault(u => u.email == email);

                if (usuari != null && BCrypt.Net.BCrypt.EnhancedVerify(password, usuari.password, BCrypt.Net.HashType.SHA512))
                {
                    if (usuari.active == 1)
                    {
                        valid = true;
                    }
                    else
                    {
                        MessageBox.Show("Tu cuenta está inactiva. Contacte con el administrador.", "Cuenta Inactiva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valid;
        }
        public static string checkRol(string email)
        {
            string role = null;

            try
            {
                var usuari = Orm.bd.Usuaris.FirstOrDefault(u => u.email == email);

                if (usuari != null)
                {
                    role = usuari.role;
                }
                else
                {
                    MessageBox.Show("Usuari no trobat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el rol: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return role;
        }
        public static string GetUserEmail(int userId)
        {
            try
            {
                var usuari = Orm.bd.Usuaris.FirstOrDefault(u => u.user_id == userId);
                return usuari?.email;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error obtenint el correu de l'usuari: {ex.Message}");
                return null;
            }
        }

        private static string GenerateRandomString(int length)
        {
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                const string chars = "0123456789";
                var data = new byte[length];
                rng.GetBytes(data);
                var result = new char[length];

                for (int i = 0; i < length; i++)
                {
                    result[i] = chars[data[i] % chars.Length];
                }

                return new string(result);
            }
        }
    }
    }
