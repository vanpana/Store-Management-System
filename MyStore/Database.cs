using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Windows.Forms;

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
                string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
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

        public static DataSet GetParent()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            adapter.SelectCommand = new SqlCommand(ConfigurationManager.AppSettings["selectParent"], Connection);
            adapter.Fill(dataSet);

            return dataSet;
        }

        public static DataSet GetChildByParentID(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            
            adapter.SelectCommand = new SqlCommand(ConfigurationManager.AppSettings["selectChildByParentID"] + id, Connection); ;
            adapter.Fill(dataSet);

            return dataSet;
        }

        public static Boolean addChild(Panel panel)
        {
            // TODO: Get next id
            string childTableName = ConfigurationManager.AppSettings["childTableName"];
            string childColumnNames = ConfigurationManager.AppSettings["childColNames"];
            string childParams = ConfigurationManager.AppSettings["childColParams"];
            List<String> columnNamesList = getColNames();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("INSERT INTO " + childTableName + "(" + childColumnNames + ")" + "VALUES(" + childParams + ")", Connection);
      
            foreach(string column in columnNamesList)
            {
                TextBox textBox = (TextBox)panel.Controls[column];
                cmd.Parameters.AddWithValue("@" + column, textBox.Text);
            }

            adapter.InsertCommand = cmd;
            int result = adapter.InsertCommand.ExecuteNonQuery();

            if (result >= 1) return true;
            return false;
        }

        public static List<string> getColNames()
        {
            return new List<string>(ConfigurationManager.AppSettings["childColNames"].Split(','));
        }

        public static Boolean updateSong(int songID, string name, int albumID, int price, string genre)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = new SqlCommand("UPDATE Songs set name = @name, albumID = @album_id, price = @price, genre = @genre " +
                "where songID = @song_id", Connection);

            adapter.UpdateCommand.Parameters.AddWithValue("@name", name);
            adapter.UpdateCommand.Parameters.AddWithValue("@album_id", albumID);
            adapter.UpdateCommand.Parameters.AddWithValue("@price", price);
            adapter.UpdateCommand.Parameters.AddWithValue("@genre", genre);
            adapter.UpdateCommand.Parameters.AddWithValue("@song_id", songID);

            int result = adapter.UpdateCommand.ExecuteNonQuery();

            if (result >= 1) return true;
            return false;
        }

        public static Boolean deleteSong(int songID)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = new SqlCommand("DELETE FROM Songs where songID = @song_id", Connection);

            adapter.DeleteCommand.Parameters.AddWithValue("@song_id", songID);

            int result = adapter.DeleteCommand.ExecuteNonQuery();

            if (result >= 1) return true;
            return false;
        }

        public static int getNextID()
        {
            string getId = ("SELECT top 1 songID from Songs order by songID desc");
            SqlCommand cmd1 = new SqlCommand(getId, Connection);
            int i = Convert.ToInt32(cmd1.ExecuteScalar());
            return i + 1;
        }
    }
}
