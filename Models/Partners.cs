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
        public string fio { get; set; }
        public string adres { get; set; }
        public long inn { get; set; }
        public long phone { get; set; }
        public string email { get; set; }
        public int rating { get; set; }
        public Partners() { }
        public Partners(int id, int type, string name, string fio, string adres, long inn, long phone, string email, int rating)
        {
            this.id = id;
            this.type = type;
            this.fio = fio;
            this.name = name;
            this.adres = adres;
            this.inn = inn;
            this.phone = phone;
            this.email = email;
            this.rating = rating;
        }
    }
}
