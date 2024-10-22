using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Master_pol_Drachev.Classes
{
    public class DbConnection
    {
        public enum tabels
        {
            partners
        }
        public List<PartnersContext> AllPartners = PartnersContext.AllPartners();
        public static readonly string connection = "server=localhost;port=3308;database=master_pol;uid=root;";
        public static MySqlConnection OpenConnection()
        {
            try
            {
                MySqlConnection Connection = new MySqlConnection(connection);
                Connection.Open();
                return Connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static MySqlDataReader Query(string Sql, MySqlConnection connection)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(Sql, connection);
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
            MySqlConnection.ClearPool(connection);
        }
    }
}

