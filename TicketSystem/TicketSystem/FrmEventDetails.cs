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
        Event eventInformation = new Event();

        public FrmEventDetails(Event e)
        {
            InitializeComponent();
            this.eventInformation = e;//This event will be passed in from THe events page.

            AddListItem();
            this.Text = Text + " " + eventInformation.EventName; // Display the event in heading.


        }
        /// <summary>
        /// Add and display information from selected item on homescreen
        /// </summary>
        private void AddListItem()
        {

            txtDetail.Text = eventInformation.EventInfo;
            txtDate.Text = eventInformation.EventStartDate.ToString("dd MMMM, yyyy") + " - " + eventInformation.EventEndDate.ToString("dd MMMM, yyyy");
            txtEvent.Text = eventInformation.EventName;
            txtLocation.Text = eventInformation.Venue.VenueAddress.ToString() + ", " + eventInformation.Venue.VenueCity.ToString() + ", " + eventInformation.Venue.VenueState.ToString();
            txtPrice.Text = eventInformation.EventPriceRange;

        }

        private void FrmEventDetails_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

        }


    }
}
