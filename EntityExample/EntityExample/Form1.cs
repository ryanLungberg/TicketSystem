using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Vendor> vendors = VendorDB.GetAllVendors();
            lstVendors.DataSource = vendors;
            lstVendors.DisplayMember = "VendorName";
            lstVendors.ValueMember = "VendorID";
        }
    }
}
