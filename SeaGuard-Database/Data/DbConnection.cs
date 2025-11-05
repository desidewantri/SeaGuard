using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaGuard_Database.Data
{
    internal class DbConnection
    {
        private const string ConnString =
            "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=SeaGuard";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConnString);
        }
    }
}
