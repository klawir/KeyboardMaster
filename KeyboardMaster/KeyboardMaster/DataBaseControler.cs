using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KeyboardMaster.Sql;

namespace KeyboardMaster
{
    public class DataBaseControler
    {
        private static SqlConnection _connection;
        private static SqlCommand _sqlCommand;
        private static string _querySql;
        private static string _connectionString;

        public static float ConnectionTimeout { get; private set; }
        public static bool Connected { get; private set; }

        public static void Initialize()
        {
            _connection = new SqlConnection(_connectionString);
            _connectionString = string.Empty;
        }

        public static void InitializeConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static bool CanConnectToDatabase()
        {
            _connection = new SqlConnection(_connectionString);
            ConnectionTimeout = _connection.ConnectionTimeout;

            try
            {
                using (_connection = new SqlConnection(_connectionString))
                {
                    _connection.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to data base");
                _connection.Close();
                Connected = false;

                return false;
            }

            _connection.Close();
            Connected = true;

            return true;
        }

        public static bool IsServerAddressEmpty()
        {
            bool noEnteredServerAddress = string.IsNullOrEmpty(_connectionString);

            if (noEnteredServerAddress)
            {
                return true;
            }

            return false;
        }

        internal static List<PlayerData> LoadScores()
        {
            List<PlayerData> playerData = new List<PlayerData>();
            
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            _querySql = "Select Player,Value " +
                "from Scores " +
                "order by Value DESC";

            _sqlCommand = new SqlCommand(_querySql, _connection);

            SqlDataReader oReader;
            SqlDataAdapter adapter;

            using (oReader = _sqlCommand.ExecuteReader())
            {
                while (oReader.Read())
                {
                    adapter = new SqlDataAdapter();

                    playerData.Add(new PlayerData(
                    oReader["Player"].ToString(),
                    oReader["Value"].ToString()
                    ));
                }

                _connection.Close();
            }
            
            return playerData;
        }

        public static void SaveScores(TextBox textBox, Label scoreValueLabel)
        {
            _querySql = "INSERT INTO Scores " +
                "(Player, Value) " +
                "values (@Player, @Value)";

            _connection.Open();
            _sqlCommand = new SqlCommand(_querySql, _connection);
            _sqlCommand.Parameters.Add("@Player", SqlDbType.VarChar);
            _sqlCommand.Parameters["@Player"].Value = textBox.Text;
            _sqlCommand.Parameters.Add("@Value", SqlDbType.Int);
            _sqlCommand.Parameters["@Value"].Value = int.Parse(scoreValueLabel.Text);
            _sqlCommand.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
