using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KeyboardMaster
{
    internal class DataBaseControler
    {
        private static SqlConnection _connection;
        private static SqlCommand _sqlCommand;
        private static string _querySql;
        private static string _connectionString;

        public static void Initialize()
        {
            _connectionString = string.Empty;
        }

        public static void InitializeConnection(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new SqlConnection(connectionString);
        }

        public static List<PlayerData> LoadScores()
        {
            List<PlayerData> playerData = new List<PlayerData>();
            bool hasEnteredServerAddress = string.IsNullOrEmpty(_connectionString);

            if (hasEnteredServerAddress)
            {
                MessageBox.Show("No connected to a data base");
                return playerData;
            }

            _querySql = "Select Player,Value from Scores";
            _sqlCommand = new SqlCommand(_querySql, _connection);
            _connection.Open();

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
