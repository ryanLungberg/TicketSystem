using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystem
{
    public partial class FrmEventDetails : Form
    {
        Event e = new Event();
        public FrmEventDetails(Event e)
        {
            InitializeComponent();
            this.e = e;//This event will be passed in from THe events page.
            AddListItem();
        }

        private void AddListItem()
        {
            txtDetail.Text = e.EventInfo;
        }

        private void FrmEventDetails_Load(object sender, EventArgs e)
        {
           
        }
    }
}
