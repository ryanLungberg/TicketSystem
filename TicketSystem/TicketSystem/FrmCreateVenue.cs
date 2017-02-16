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

        private void FrmCreateVenue_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
