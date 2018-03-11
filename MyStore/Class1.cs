using System;
using System.Data;
using System.Data.SqlClient;
namespace MyStore
{
    public static class DatabaseUtil
    {
        private static SqlConnection _connection;

        public static SqlConnection Connection
        {
            get
            {
                // If connection was already established, return the connection
                if (_connection != null && _connection.State == ConnectionState.Open) return _connection;

                // Get the connection to the database
                string connectionString = "Server=DESKTOP-J00KO0M\\SQLEXPRESS; Database=MyStore; Integrated Security=True;";
                _connection = new SqlConnection(connectionString);
                try
                {
                    _connection.Open();
                }
                catch (Exception ex)
                {
                    Console.Write("Exception occured: " + ex.Message);
                    return null;
                }

                return _connection;
            }
        }

        public static DataSet GetAllAlbums()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            adapter.SelectCommand = new SqlCommand("SELECT * FROM Albums", Connection);
            adapter.Fill(dataSet);

            return dataSet;
        }

        public static DataSet GetSongsFromAlbum(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            
            adapter.SelectCommand = new SqlCommand("SELECT * FROM Songs WHERE albumID = " + id, Connection); ;
            adapter.Fill(dataSet);

            return dataSet;
        }
    }
}
