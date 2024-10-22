using System;
using System.Collections.Generic;
using System.Text;

namespace Master_pol_Drachev.Models
{
    public class Partners
    {
        public int id { get; set; }
        public int type { get; set; }
        public string name { get; set; }
        public string adres { get; set; }
        public string inn { get; set; }
        public string fio { get; set; }
        public string contact { get; set; }
        public int rating { get; set; }
        public string places { get; set; }
        public string logo { get; set; }
        public Partners() { }
        public Partners(int id, int type, string name, string adres, string inn, string fio, string contact, int rating, string places, string logo)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.adres = adres;
            this.inn = inn;
            this.fio = fio;
            this.contact = contact;
            this.rating = rating;
            this.places = places;
            this.logo = logo;
        }
    }
}
