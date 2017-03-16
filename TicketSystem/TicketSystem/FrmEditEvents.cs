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
    public partial class FrmEditEvents : Form
    {
        public FrmEditEvents()
        {
            InitializeComponent();
        }
        BindingSource bindingEvents;
        private void FrmEditEvents_Load(object sender, EventArgs e)
        {
            List<Event> events = GetAllEvents();
            bindingEvents = new BindingSource();
            bindingEvents.DataSource = events;
            cboEventName.DataSource = bindingEvents;
            cboEventName.DisplayMember = nameof(Event.EventName);
        }
      
        private List<Event> GetAllEvents()
        {
            TicketSystemDBEntities db = new TicketSystemDBEntities();
            List<Event> events = (from e in db.Events
                                  select e).ToList();

            return events;

        }

        private void cboEventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event ev = cboEventName.SelectedItem as Event;
            txtStartDate.Text = Convert.ToString(ev.EventStartDate);
            txtEndDate.Text = Convert.ToString(ev.EventEndDate);
            txtPromoter.Text = ev.EventPromoter;
            txtGenreID.Text = Convert.ToString(ev.GenreID);
            txtEventID.Text = Convert.ToString(ev.EventID);
            txtPrice.Text = ev.EventPriceRange;
            txtVenueID.Text = Convert.ToString(ev.VenueID);
            txtPerformerID.Text = Convert.ToString(ev.PerformerID);
            txtEventInfo.Text = ev.EventInfo;
        }

     
        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {
            if (cboEventName.SelectedIndex >= 0)
            {
                int selected = Convert.ToInt32(txtEventID.Text);
                TicketSystemDBEntities db = new TicketSystemDBEntities();
                Event evs = db.Events.Find(selected);

                evs.EventStartDate = Convert.ToDateTime(txtStartDate.Text);
                evs.EventEndDate = Convert.ToDateTime(txtEndDate.Text);
                evs.EventPromoter = txtPromoter.Text;
                evs.EventPriceRange = txtPrice.Text;
                evs.EventInfo = txtEventInfo.Text;
             
                db.Entry(evs).State = System.Data.Entity.EntityState.Modified;

                try
                {
                    db.SaveChanges(); //TODO need to do a query in order to save changes in the database
                    MessageBox.Show("Your changes have been made");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

        }

     
    }
}

