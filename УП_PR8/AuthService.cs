using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_PR8
{
    internal class AuthService
    {
        private readonly string connectionString = "Host=localhost;Database=job_center;Username=postgres;Password=123;Port=5433";

        public int AuthUser(string login, string password)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand($"SELECT agent_id FROM agents WHERE login = @login AND password = @password", conn))
                {
                    cmd.Parameters.AddWithValue("login", login);
                    cmd.Parameters.AddWithValue("password", password);

                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
    }
}
