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
        Venue venueInfomration = new Venue();
        
        public FrmEventDetails(Event e)
        {
            InitializeComponent();
            this.eventInformation = e;//This event will be passed in from THe events page.
            //this.venueInfomration = v;
            AddListItem();
            this.Text = Text + " " + eventInformation.EventName; // Display the event in heading.


        }
        /// <summary>
        /// Add and display information from selected item on homescreen
        /// </summary>
        private void AddListItem()
        {

            txtDetail.Text = eventInformation.EventInfo;
            //TODO: Need to remove time stamp at end of Dates
            txtDate.Text = (eventInformation.EventStartDate.ToString() + " - " + eventInformation.EventEndDate.ToString()); 
            txtEvent.Text = eventInformation.EventName;
            // TODO: Ran into some trouble with this one.  We need to Pass Venue over as well. Not just event it seems.  We need to look into this
            txtLocation.Text = (venueInfomration.VenueAddress.ToString() + venueInfomration.VenueCity.ToString() + venueInfomration.VenueState.ToString()); 
            txtPrice.Text = eventInformation.EventPriceRange;
            
        }

        private void FrmEventDetails_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            
        }

      
    }
}
