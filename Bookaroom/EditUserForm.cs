using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookaroom.Models;

namespace Bookaroom
{
    public partial class EditUserForm : Form
    {
        int userId;
        public EditUserForm(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            Users.GetUser(userId);

            LoadUserData();
        }
        private void LoadUserData()
        {
                DataTable userData = Users.GetUser(userId); 
                DataRow row = userData.Rows[0];
                nomtextBox.Text = row["nom"].ToString(); 
                surnametextBox.Text = row["cognom"].ToString();  
                emailtextBox.Text = row["email"].ToString();            
        }
    }
}
