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

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("INSERT INTO " + childTableName + "(" + childColumnNames + ")" + "VALUES(" + childParams + ")", Connection);
      
            foreach(string column in getColNames())
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

        public static Boolean updateSong(Panel panel)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(ConfigurationManager.AppSettings["updateChild"], Connection);

            foreach (string column in getColNames())
            {
                TextBox textBox = (TextBox)panel.Controls[column];
                cmd.Parameters.AddWithValue("@" + column, textBox.Text);
            }

            adapter.UpdateCommand = cmd;
            int result = adapter.UpdateCommand.ExecuteNonQuery();

            if (result >= 1) return true;
            return false;
        }

        public static Boolean deleteSong(Panel panel)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(ConfigurationManager.AppSettings["deleteChild"], Connection);

            foreach (string column in getColNames())
            {
                TextBox textBox = (TextBox)panel.Controls[column];
                cmd.Parameters.AddWithValue("@" + column, textBox.Text);
            }
            adapter.DeleteCommand = cmd;
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
