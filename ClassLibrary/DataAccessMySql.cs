using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataAccessMySql
    {
        /*public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();    
            }
        }*/

        public DataRowCollection Query(string query, string connectionString, Action<MySqlParameterCollection> args = null)
        {

            using (var dbCon = new MySqlConnection(connectionString))
            using (var dbCmd = new MySqlCommand(query, dbCon))
            {
                if (args != null)
                    args(dbCmd.Parameters);

                dbCon.Open();
                var da = new MySqlDataAdapter(dbCmd);
                var dt = new DataTable();
                da.Fill(dt);

                return dt.Rows;
            }
        }

        public static int Update(string statement, string connectionString, Action<MySqlParameterCollection> args = null)
        {
            var dbConnStr = connectionString;

            using (var dbCon = new MySqlConnection(dbConnStr))
            using (var dbCmd = new MySqlCommand(statement, dbCon))
            {
                if (args != null)
                    args(dbCmd.Parameters);

                dbCon.Open();
                var numRowsAffected = dbCmd.ExecuteNonQuery();

                return numRowsAffected;
            }
        }

        public static int Delete(string statement, string connectionString, Action<MySqlParameterCollection> args = null)
        {
            var dbConnStr = connectionString;

            using (var dbCon = new MySqlConnection(dbConnStr))
            using (var dbCmd = new MySqlCommand(statement, dbCon))
            {
                if (args != null)
                    args(dbCmd.Parameters);

                dbCon.Open();
                var numRowsAffected = dbCmd.ExecuteNonQuery();

                return numRowsAffected;
            }
        }

        public static long Insert(string statement, string connectionString, Action<MySqlParameterCollection> args = null)
        {
            var dbConnStr = connectionString;

            using (var dbCon = new MySqlConnection(dbConnStr))
            using (var dbCmd = new MySqlCommand(statement, dbCon))
            {
                if (args != null)
                    args(dbCmd.Parameters);

                dbCon.Open();
                var numRowsAffected = dbCmd.ExecuteNonQuery();

                return dbCmd.LastInsertedId;
            }
        }
    }
}
