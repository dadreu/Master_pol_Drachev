using System;
using System.Collections.Generic;
using System.Text;

namespace Master_pol_Drachev.Models
{
    public class PartnerProducts
    {
        public int id { get; set; }
        public int product { get; set; }
        public int partner { get; set; }
        public int count { get; set; }
        public DateTime date_sale { get; set; }
        public PartnerProducts() { }
        public PartnerProducts(int id, int product, int partner, int count, DateTime date_sale)
        {
            this.id = id;
            this.product = product;
            this.partner = partner;
            this.count = count;
            this.date_sale = date_sale;

        }
    }
}
