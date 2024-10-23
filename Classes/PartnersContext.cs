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
        public PartnersContext(int id, int type, string name, string fio, string adres, long inn, long phone, string email, int rating) : base(id, type, name, fio, adres, inn, phone, email, rating) { }
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
                    clubQuery.GetString(4),
                    clubQuery.GetInt64(5),
                    clubQuery.GetInt64(6),
                    clubQuery.GetString(7),
                    clubQuery.GetInt32(8)
                    ));
            }
            DbConnection.CloseConnection(connection);
            return allClubs;
        }
    }
}
