using Master_pol_Drachev.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_pol_Drachev.Classes
{
    public class PartnerProductsContext : PartnerProducts
    {
        public PartnerProductsContext(int id, int product, int partner, int count, DateTime date_sale) : base(id, product, partner, count, date_sale) { }
        public static List<PartnerProductsContext> AllPartnerProducts()
        {
            List<PartnerProductsContext> allClubs = new List<PartnerProductsContext>();
            MySqlConnection connection = DbConnection.OpenConnection();
            MySqlDataReader Query = DbConnection.Query("SELECT * FROM partner_products;", connection);
            while (Query.Read())
            {
                allClubs.Add(new PartnerProductsContext(
                    Query.GetInt32(0),
                    Query.GetInt32(1),
                    Query.GetInt32(2),
                    Query.GetInt32(3),
                    Query.GetDateTime(4)));
            }
            DbConnection.CloseConnection(connection);
            return allClubs;
        }
    }
}
