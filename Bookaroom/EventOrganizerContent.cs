using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookaroom
{
    public partial class EventOrganizerContent : Form
    {
        public EventOrganizerContent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void manageEventImg_Click(object sender, EventArgs e)
        {           
                StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
                staticFormmainForm.OpenForm(new EventTable()); 
                
        }

        private void managereservationimg_Click(object sender, EventArgs e)
        {
            StaticForm staticFormmainForm = (StaticForm)this.ParentForm;
            staticFormmainForm.OpenForm(new ReservaTable());
        }
    }
}
