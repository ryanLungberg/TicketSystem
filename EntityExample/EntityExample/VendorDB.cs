using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample
{
    static class VendorDB
    {
        /// <summary>
    /// Gets all vendors from vendors table.
    /// </summary>
    /// <returns></returns>
        public static List<Vendor> GetAllVendors()
        {
            APEntities db = new APEntities();
            List<Vendor> Vendors = (from ven in db.Vendors
                                   select ven).ToList();
            return Vendors;
        }
    }
}
