using Master_pol_Drachev.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_pol_Drachev.Classes
{
    public class PartnersContext : Partners
    {
        public PartnersContext(int id, int type, string name, string adres, long inn, string fio, string contact, int rating, string places) : base(id, type, name, adres, inn, fio, contact, rating, places) { }
        public static List<PartnersContext> AllPartners()
        {
            List<PartnersContext> allClubs = new List<PartnersContext>();
            MySqlConnection connection = DbConnection.OpenConnection();
            MySqlDataReader clubQuery = DbConnection.Query("SELECT * FROM partners;", connection);
            while (clubQuery.Read())
            {
                allClubs.Add(new PartnersContext(
                    clubQuery.GetInt32(0),
                    clubQuery.GetInt32(1),
                    clubQuery.GetString(2),
                    clubQuery.GetString(3),
                    clubQuery.GetInt64(4),
                    clubQuery.GetString(5),
                    clubQuery.GetString(6),
                    clubQuery.GetInt32(7),
                    clubQuery.GetString(8)));
            }
            DbConnection.CloseConnection(connection);
            return allClubs;
        }
    }
}
