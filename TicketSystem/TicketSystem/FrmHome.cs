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
