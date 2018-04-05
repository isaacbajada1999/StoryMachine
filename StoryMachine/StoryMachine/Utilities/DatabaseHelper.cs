using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace StoryMachine.Utilities
{
    class DatabaseHelper
    {
        public NpgsqlConnection conn;

        public DatabaseHelper()
        {
            conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; " +
                        "Password=postgres;Database=Assignment;Search Path=public");
            conn.Open();
        }

        public Int64 Count(string tableName)
        {
            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand($"SELECT COUNT(*) FROM \"{tableName}\"", conn);

            // Execute the query and obtain the value of the first column of the first row
            Int64 count = (Int64)command.ExecuteScalar();

            return count;
        }

        public void CloseConnection()
        {
            conn.Close();
        }
    }
}
