using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    partial class Event
    {
        public string EventNameAndDates { get { return EventName + "\t" + EventStartDate.ToString("MM/dd/yyyy") + "-" + EventEndDate.ToString("MM/dd/yyyy"); } }
    }
}
