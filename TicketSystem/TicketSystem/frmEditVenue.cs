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

        //returns a current list of venues in the database.
        private List<Venue> GetVenues()
        {
            using (TicketSystemDBEntities db = new TicketSystemDBEntities())
                return db.Venues.ToList();
        }

        //repopulates the combobox at the top of frmEditVenue with Venues in the database.
        private void ReloadVenues()
        {
            cboxVenues.Items.Clear();
            foreach (Venue v in GetVenues())
            {
                cboxVenues.Items.Add(v.VenueName);
            }
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
            if (IsValidData())
            {
                TicketSystemDBEntities db = new TicketSystemDBEntities();
                int indexToBeChanged = cboxVenues.SelectedIndex;
                Venue currentVenue = db.Venues.Find(indexToBeChanged);

                //This line must be included to let Entity Framework know that the item has been changed in the database.
                db.Entry(currentVenue).State = System.Data.Entity.EntityState.Modified;

                currentVenue.VenueName = txtVenueName.Text;
                currentVenue.VenueAddress = txtVenueAddress.Text;
                currentVenue.VenueCity = txtVenueCity.Text;
                currentVenue.VenueInfo = txtVenueInfo.Text;
                currentVenue.VenueState = txtVenueState.Text;
                currentVenue.VenueType = txtVenueType.Text;
                currentVenue.VenueURL = txtVenueURL.Text;

                db.SaveChanges();

                ClearData();
                ReloadVenues();
            }
        }
    }
}
