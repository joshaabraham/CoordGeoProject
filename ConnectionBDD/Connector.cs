using System;
using MySql.Data.MySqlClient;

namespace ConnectionBDD
{
    public class Connector
    {
        public string connectionString = "Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;";

        public Connector()
        {
        MySqlConnection connection = new MySqlConnection(connectionString);

        }

    }
}
