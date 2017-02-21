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
    public partial class FrmCreateVenue : Form
    {
        public FrmCreateVenue()
        {
            InitializeComponent();
        }
        TicketSystemDBEntities db = new TicketSystemDBEntities();

        /// <summary>
        /// Will Add All information from textboxes to TicketSystemDB -Table- Venue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Venue v = new Venue();

            v.VenueName = txtName.Text;
            v.VenueType = txtType.Text;
            v.VenueAddress = txtAddress.Text;
            v.VenueCity = txtCity.Text;
            v.VenueInfo = txtInfo.Text;
            v.VenueState = txtState.Text;
            v.VenueURL = txtURL.Text;

            db.Venues.Add(v);

            int insert = db.SaveChanges();
            if (insert > 0)
            {
                MessageBox.Show("Venue Submitted Correctly");
                
                
            }
            else
            {
                MessageBox.Show("Try Again!!!");
            }
            
            
        }


        /// <summary>
        /// Once button is pressed all information in text boxes will be cleared
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void FrmCreateVenue_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}
