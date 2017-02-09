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
       
        public FrmEventDetails(Event e)
        {
            InitializeComponent();
            Event CurrentEvent = e;//This event will be passed in from THe events page.
            AddListItem();
        }

        private void AddListItem()
        {
            //TODO
        }

        private void FrmEventDetails_Load(object sender, EventArgs e)
        {
           
        }
    }
}
