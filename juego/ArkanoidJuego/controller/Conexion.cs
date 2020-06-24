using System;
using System.Data;
using Npgsql;

namespace ArkanoidJuego.controller
{
    public static class Conexion
    {
        private static string host = "127.0.0.1:50582",
            database = "NAVE",
            userId = "postgres",
            password = "123456";

        private static string sConnection =
            string.Format("Server= {0};Port=5432; User Id={1};Password={2};Database={3};", host, userId, password,
                database);
        // $"sslmode=Require; Trust Server Certificate=true";

        public static DataTable ExecuteQuery(string query)//representa una tabla de la base
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
            connection.Open();
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            
            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)//metodo executequery
        {
            Console.WriteLine(sConnection);
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}