using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Npgsql.Schema;
using StoryMachine.DatabaseModels;

namespace StoryMachine.Utilities
{
    class DatabaseHelper
    {
        public NpgsqlConnection conn = null;

        public static DatabaseHelper Current = new DatabaseHelper();

        private DatabaseHelper()
        {
            OpenConnection();
        }

        public void OpenConnection()
        {
            conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; " +
                        "Password=postgres;Database=Assignment;Search Path=public");
            conn.Open();
        }

        public string SelectValue(string selectStatement)
        {
            return SelectValues(selectStatement).SingleOrDefault();
        }

        public List<string> SelectValues(string selectStatement)
        {
            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand(selectStatement, conn);
            List<string> values = new List<string>();
            using (NpgsqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    values.Add(dataReader.GetString(0));
                }
            }
            return values;
        }

        public List<Dictionary<string, string>> SelectColumns(string selectStatement)
        {
            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand(selectStatement, conn);
            List<Dictionary<string, string>> values = new List<Dictionary<string, string>>();
            using (NpgsqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Dictionary<string, string> rowInformation = new Dictionary<string, string>();
                    IReadOnlyCollection<NpgsqlDbColumn> columns = dataReader.GetColumnSchema();
                    foreach(NpgsqlDbColumn column in columns)
                    {
                        string columnName = column.ColumnName;
                        string value = dataReader.GetString((int)column.ColumnOrdinal);
                        rowInformation[columnName] = value;
                    }
                    values.Add(rowInformation);
                }
            }
            return values;
        }


        public int Insert(string insertStatement)
        {
            NpgsqlCommand command = new NpgsqlCommand(insertStatement, conn);
            return command.ExecuteNonQuery();
        }
        
        public Int64 Count(string tableName)
        {

            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand($"SELECT COUNT(*) FROM \"{tableName.ToLower()}\"", conn);
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
