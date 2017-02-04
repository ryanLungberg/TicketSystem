using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace TicketSystem
{
    public partial class TicketSystem : Form
    {
        public TicketSystem()
        {
            InitializeComponent();
        }

        private void TicketSystem_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1000, 700);
            
            //To Do: CHANge this to upcoming events
            populateListBoxWithAllEvents(); //initial populate Events listbox with all events
            PopulateGenres();               // initial Populate genres listbox
        }

        /// <summary>
        /// /populates events listbox with all events
        /// </summary>
        public void populateListBoxWithAllEvents()
        {
            TicketSystemDBEntities db = new TicketSystemDBEntities();
            List<Event> listEvents = db.Events.ToList();
            lstBoxEvents.DataSource = listEvents;
            lstBoxEvents.DisplayMember = nameof(Event.EventNameAndDates);
            lstBoxEvents.ValueMember = nameof(Event.EventID);


        }

        /// <summary>
        /// Populates Genre list box with all genres.
        /// </summary>
        public void PopulateGenres()
        {
            TicketSystemDBEntities db = new TicketSystemDBEntities();
            List<Genre> listGenres = db.Genres.ToList();
            lstSelectGenres.DataSource = listGenres;
            lstSelectGenres.DisplayMember = nameof(Genre.GenreName);
            lstSelectGenres.ValueMember = nameof(Genre.GenreID);
        }


        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            PopulateByEventName();
        }

        /// <summary>
        /// Populates event list box where data/text inside txtSearchEventName  
        /// substring matches the EventName.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopulateByEventName()
        {
            if (!String.IsNullOrWhiteSpace(txtSearchEventName.Text))
            {
                string eventSearch = txtSearchEventName.Text.Trim();
                TicketSystemDBEntities db = new TicketSystemDBEntities();
                List<Event> listOfEvents = db.Events.Where(e => e.EventName.Contains(eventSearch)).ToList();

                lstBoxEvents.DataSource = listOfEvents;
            }
            else
            {
                MessageBox.Show("Enter a Event Name");
            }
        }

        private void btnSearchPerformer_Click(object sender, EventArgs e)
        {
            PopulateByPerformer();
        }
        /// <summary>
        /// Populates event list box where data/text inside performer textbox as 
        /// substring matches the string name of Event.PerformerName. 
        /// </summary>
        private void PopulateByPerformer()
        {
            if (!String.IsNullOrWhiteSpace(txtSearchPerformer.Text)) {
                string performerSearch = txtSearchPerformer.Text.Trim();
                TicketSystemDBEntities db = new TicketSystemDBEntities();
                List<Event> listOfEvents = db.Events.Where(e => e.Performer.PerformerName.Contains(performerSearch)).ToList();

                lstBoxEvents.DataSource = listOfEvents;
            }
            else
            {
                MessageBox.Show("Enter a performer");
            }
        }

        private void btnSearchVenue_Click(object sender, EventArgs e)
        {
            PopulateByVenue();
        }

        /// <summary>
        /// Populates event list box where data/text inside Venue textbox as
        /// substring matches the string name of the Event.VenueName. 
        /// </summary>
        private void PopulateByVenue()
        {
            if (!String.IsNullOrWhiteSpace(txtSearchVenue.Text))
            {
                string venueSearch = txtSearchVenue.Text.Trim();
                TicketSystemDBEntities db = new TicketSystemDBEntities();
                List<Event> listOfEvents = db.Events.Where(e => e.Venue.VenueName.Contains(venueSearch)).ToList();

                lstBoxEvents.DataSource = listOfEvents;
            }
            else
            {
                MessageBox.Show("Enter a venue name");
            }
        }
    

        /// <summary>
        /// Open Event details if an event is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEventDetails_Click(object sender, EventArgs e)
        {
            if (lstBoxEvents.SelectedIndex >= 0)
            {
                //pass Selected event to Frm Event details
                Form FrmEventDetails = new FrmEventDetails((Event)lstBoxEvents.SelectedItem);
                FrmEventDetails.Show();
            }
            else
            {
                MessageBox.Show("Please select an event.");
            }
        }

        
    }
}
