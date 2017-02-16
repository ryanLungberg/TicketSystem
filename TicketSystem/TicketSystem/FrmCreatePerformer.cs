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
    public partial class FrmCreatePerformer : Form
    {
        public FrmCreatePerformer()
        {
            InitializeComponent();
        }

        private void FrmCreatePerformer_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
