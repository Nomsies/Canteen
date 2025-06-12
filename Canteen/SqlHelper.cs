using Npgsql;
using System.Data;
//using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Collections.Generic;

namespace Canteen
{
    public class SqlHelper
    {
        private static readonly string connString = ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString;

        public DataTable ReadToTable(string query)
        {
            DataTable table = new DataTable();
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();

                NpgsqlCommand comm = new NpgsqlCommand(query, conn);;

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(comm);
                adapter.Fill(table);
            }
            catch { }

            return table;
        }

        public T ReadData<T>(string query) where T : class, new()
        {
            T result = new T();

            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand(query, conn);

            var reader = comm.ExecuteReader();

            for (int i=0; i < reader.FieldCount; i++)
            {
                var property = typeof(T).GetProperty(reader.GetName(i));

                property.SetValue(result, property);
            }

            comm.Dispose();
            conn.Close();

            return result;
        }

        public List<T> ReadAllData<T>(string query) where T : class, new()
        {
            List<T> result = new List<T>();
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();

                NpgsqlCommand comm = new NpgsqlCommand(query, conn);

                var reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    T item = new T();
                    
                    for (int i=0; i < reader.FieldCount; i++)
                    {
                        var properties = typeof(T).GetProperty(reader.GetName(i));

                        //if (properties != null && reader[i] != DBNull.Value)
                        //    properties.SetValue(item, reader[i]);
                        properties.SetValue(item, reader[i]);
                    }
                    
                    result.Add(item);
                }

                comm.Dispose();
                conn.Close();
            }
            catch { }

            return result;
        }

        public bool EditData(string query)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();

                NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                int index = comm.ExecuteNonQuery();

                comm.Dispose();
                conn.Close();

                return index > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
