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
            // MAsukkan koneksi yang sesuai dengan database yang digunakan
            "";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConnString);
        }
    }
}

