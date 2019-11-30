using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading;

namespace DAL
{
    public class ConnectionManager //sealed
    {
        private const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TradingCompany;Integrated Security=True";

        //
        private static volatile ConnectionManager instance = null;
        //
        private string connectionString;
        private IDictionary<int, SqlConnection> connections;

        private ConnectionManager(string connectionString)
        {
            this.connectionString = connectionString;
            connections = new Dictionary<int, SqlConnection>();
        }

        public ConnectionManager()
        {
            this.connectionString = CONNECTION_STRING;
            connections = new Dictionary<int, SqlConnection>();
        }

        public static ConnectionManager Get()
        {
            return Get(null);
        }

        public static ConnectionManager Get(string connectionString)
        {
            if (instance == null)
            {
                lock (typeof(ConnectionManager))
                {
                    if (instance == null)
                    {
                        if (connectionString == null)
                        {
                            connectionString = CONNECTION_STRING;
                        }
                        instance = new ConnectionManager(connectionString);
                    }
                }
            }
            return instance;
        }

        public static void CloseConnections()
        {
            SqlConnection connection;
            foreach (KeyValuePair<int, SqlConnection> kvp in Get().connections)
            {
                connection = Get().connections[kvp.Key];
                if ((connection != null) && (connection.State == ConnectionState.Open))
                {
                    connection.Close();
                }
                Get().connections.Add(kvp.Key, null);
            }
        }

        public SqlConnection GetConnection()
        {
            //MySqlConnection connection = connections[Thread.CurrentThread.ManagedThreadId];
            SqlConnection connection;
            connections.TryGetValue(Thread.CurrentThread.ManagedThreadId, out connection);
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                connections.Add(Thread.CurrentThread.ManagedThreadId, connection);
            }
            return connection;
        }

        //public static string GetDefaultConnectionString()
        //{
        //    return GetLocalConnectionString();
        //}

        //public static string GetLocalConnectionString()
        //{
        //    return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TradingCompany;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //}
    }
}