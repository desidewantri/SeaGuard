using Npgsql;
using NpgsqlTypes;
using SeaGuard_Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaGuard_Database.Data
{
    internal class ReportRepository
    {
        // SELECT semua
        public DataTable SelectAll()
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();
            const string sql = @"SELECT id, category, photo_path, latitude, longitude,
                                        notes, status, created_at
                                 FROM reports
                                 ORDER BY created_at DESC";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var rd = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(rd);
            return dt;
        }

        // SELECT by id
        public Report? GetById(string id)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();
            const string sql = @"SELECT id, category, photo_path, latitude, longitude,
                                notes, status, created_at
                         FROM reports
                         WHERE id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var rd = cmd.ExecuteReader();
            if (!rd.Read()) return null; 

            return new Report
            {
                Id = rd.GetString(0),
                Category = rd.GetString(1),
                PhotoPath = rd.IsDBNull(2) ? null : rd.GetString(2),
                Latitude = rd.IsDBNull(3) ? null : rd.GetString(3),
                Longitude = rd.IsDBNull(4) ? null : rd.GetString(4),
                Notes = rd.IsDBNull(5) ? null : rd.GetString(5),
                Status = rd.IsDBNull(6) ? "Pending" : rd.GetString(6),
                Created = rd.GetDateTime(7)
            };
        }

        // INSERT
        public void Insert(string category, string photoPath, string lat, string lng, string notes)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();
            const string sql = @"INSERT INTO reports
                                 (category, photo_path, latitude, longitude, notes)
                                 VALUES (@c, @p, @lat, @lng, @n)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@c", category);
            cmd.Parameters.AddWithValue("@p", (object?)photoPath ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@lat", (object?)lat ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@lng", (object?)lng ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@n", (object?)notes ?? DBNull.Value);
            cmd.ExecuteNonQuery();
        }

        // UPDATE
        public void Update(Report r)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            if (string.IsNullOrWhiteSpace(r.Id))
                throw new ArgumentException("Id tidak boleh kosong untuk update", nameof(r));

            const string sql = @"UPDATE reports
                         SET category=@c,
                             photo_path=@p,
                             latitude=@lat,
                             longitude=@lng,
                             notes=@n,
                             status=@s
                         WHERE id=@id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@c", r.Category);
            cmd.Parameters.AddWithValue("@p", (object?)r.PhotoPath ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@lat", (object?)r.Latitude ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@lng", (object?)r.Longitude ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@n", (object?)r.Notes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@s", string.IsNullOrWhiteSpace(r.Status) ? "Pending" : r.Status);
         
            cmd.Parameters.Add("@id", NpgsqlDbType.Varchar).Value = r.Id;

            cmd.ExecuteNonQuery();
        }


        // DELETE
        public void Delete(string id)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Id tidak boleh kosong untuk delete", nameof(id));

            const string sql = "DELETE FROM reports WHERE id=@id";
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@id", NpgsqlDbType.Varchar).Value = id;

            cmd.ExecuteNonQuery();
        }
    }
}
