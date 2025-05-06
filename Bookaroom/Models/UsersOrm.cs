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
        public static bool ResetPassword(int userId)
        {
            try
            {
                var usuari = Orm.bd.Usuaris.FirstOrDefault(u => u.user_id == userId);

                if (usuari == null)
                {
                    MessageBox.Show("Usuari no trobat.");
                    return false;
                }

                string newPassword = "reset123";
                usuari.password = BCrypt.Net.BCrypt.EnhancedHashPassword(newPassword, BCrypt.Net.HashType.SHA512);

                // Guardar cambios
                Orm.bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al restablir la contrasenya: {ex.Message}");
                return false;
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

                // Cambiar el estado (1 -> 0, 0 -> 1)
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

    }
}
