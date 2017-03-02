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

            if (IsValidData())
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
                int addVenueToDatabase = db.SaveChanges();

                if(addVenueToDatabase > 0)
                {
                    MessageBox.Show("Your Venue has been added", "congratulations");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("You did not enter things in correctly", "Try again");
                }

                
            }
               

        }


        /// <summary>
        /// Once button is pressed all information in text boxes will be cleared
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void FrmCreateVenue_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
        /// <summary>
        /// Will check to see if the tables that can not be null have something inserted into them
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            if (!String.IsNullOrWhiteSpace(txtName.Text) && !String.IsNullOrWhiteSpace(txtAddress.Text) && !String.IsNullOrWhiteSpace(txtCity.Text) && !String.IsNullOrWhiteSpace(txtState.Text))
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
    }
}
