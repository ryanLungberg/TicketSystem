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
    public partial class FrmCreateEvent : Form
    {
        public FrmCreateEvent()
        {
            InitializeComponent();
            PopulateGenres();
            PopulateVenue();
            PopulatePerformer();
        }
        TicketSystemDBEntities db = new TicketSystemDBEntities();

        private void FrmCreateEvent_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }


        public void PopulateGenres()
        {
            //TicketSystemDBEntities db = new TicketSystemDBEntities();
            List<Genre> listGenres = db.Genres.ToList();
            cboGenre.DataSource = listGenres;
            cboGenre.DisplayMember = nameof(Genre.GenreName);
            cboGenre.ValueMember = nameof(Genre.GenreID);
        }

        public void PopulateVenue()
        {
            //TicketSystemDBEntities db = new TicketSystemDBEntities();
            List<Venue> listGenres = db.Venues.ToList();
            cboVenue.DataSource = listGenres;
            cboVenue.DisplayMember = nameof(Venue.VenueName);
            cboVenue.ValueMember = nameof(Venue.VenueID);
        }

        public void PopulatePerformer()
        {
            //TicketSystemDBEntities db = new TicketSystemDBEntities();
            List<Performer> listGenres = db.Performers.ToList();
            cboPerformer.DataSource = listGenres;
            cboPerformer.DisplayMember = nameof(Performer.PerformerName);
            cboPerformer.ValueMember = nameof(Performer.PerformerID);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                Event ev = new Event();

                ev.EventName = txtName.Text;
                ev.EventPriceRange = txtPrice.Text;
                ev.EventPromoter = txtPromoter.Text;
                ev.EventStartDate = dtpStartDate.Value;
                ev.EventEndDate = dtpEndDate.Value;
                ev.VenueID = ((Venue)cboVenue.SelectedItem).VenueID;
                ev.GenreID = cboGenre.SelectedIndex;
                ev.PerformerID = cboPerformer.SelectedIndex;

                db.Events.Add(ev);
                int pass = db.SaveChanges();
                if (pass > 0)
                {
                    MessageBox.Show("You have just created a new event", "Yay!!!!");
                }

            }
            else
            {
                MessageBox.Show("You did not enter things in correctly", "Try again");
            }

        }

        private bool IsValidData()
        {
            if (!String.IsNullOrWhiteSpace(txtName.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
