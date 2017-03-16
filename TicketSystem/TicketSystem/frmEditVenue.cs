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
    public partial class frmEditVenue : Form
    {
        public frmEditVenue()
        {
            InitializeComponent();
        }

        private void frmEditVenue_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Will check to see if the tables that can not be null have something inserted into them
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            if (!String.IsNullOrWhiteSpace(txtVenueName.Text) && !String.IsNullOrWhiteSpace(txtVenueAddress.Text) && !String.IsNullOrWhiteSpace(txtVenueCity.Text) && !String.IsNullOrWhiteSpace(txtVenueState.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Will Clear data
        /// </summary>
        private void ClearData()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO: Implement edit venue behavior
        }
    }
}
