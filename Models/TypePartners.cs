using System;
using System.Collections.Generic;
using System.Text;

namespace Master_pol_Drachev.Models
{
    public class TypePartners
    {
        public int id { get; set; }
        public string name { get; set; }
        public TypePartners() { }
        public TypePartners(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
    }
}
