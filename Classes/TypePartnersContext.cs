using Master_pol_Drachev.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_pol_Drachev.Classes
{
    public class TypePartnersContext : TypePartners
    {
        public TypePartnersContext(int id, string name) : base(id, name) { }
        public static List<TypePartnersContext> AllTypePartners()
        {
            List<TypePartnersContext> allClubs = new List<TypePartnersContext>();
            MySqlConnection connection = DbConnection.OpenConnection();
            MySqlDataReader clubQuery = DbConnection.Query("SELECT * FROM partners_type;", connection);
            while (clubQuery.Read())
            {
                allClubs.Add(new TypePartnersContext(
                    clubQuery.GetInt32(0),
                    clubQuery.GetString(1)));
            }
            DbConnection.CloseConnection(connection);
            return allClubs;
        }
    }
}
