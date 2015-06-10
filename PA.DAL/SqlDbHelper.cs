using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace PA.DAL
{
    
    class SqlDbHelper
    {
        private const string CONN_STRING = ConfigurationManager.
                ConnectionStrings["performanceDbConnectionString"].ToString();

        public SqlDbHelper()
        {
            
        }

        /// <summary>
        /// Method to execute CRUD operation for parameterless commands
        /// </summary>
        /// <param name="commandText"> sql query/storedprocedures for SqlCommand Text property</param>
        /// <param name="commandType">How the sql text is to be interpreted. Example 'Text'</param>
        /// <returns>DataTable consisting the result of the executed command</returns>
        internal static DataTable  ExecuteSelectCommand(string commandText, CommandType commandType)
        {
            DataTable dt = null;

            using(SqlConnection sqlConn=new SqlConnection(CONN_STRING))
            {
                using(SqlCommand sqlCmd=sqlConn.CreateCommand())
                {
                    sqlCmd.CommandText = commandText;
                    sqlCmd.CommandType = commandType;

                    try
                    {
                        if (sqlConn.State == ConnectionState.Closed)
                            sqlConn.Open();

                        using(SqlDataAdapter sqlDa=new SqlDataAdapter(sqlCmd))
                        {
                            dt = new DataTable();
                            sqlDa.Fill(dt);
                        }
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                }
            }

            return dt;
        }

        /// <summary>
        /// Method to execute CRUD operations with parameterized queries.
        /// </summary>
        /// <param name="commandText">The sql query/storedprocedures for SqlCommand</param>
        /// <param name="commandType">What type is the commandText? E.g Text, stored procedure.</param>
        /// <param name="sqlPara">Array of parameters of type SqlParameter</param>
        /// <returns>DataTable retrieved after executing the query.</returns>
        internal static DataTable ExecuteParameterizedSelectCommand(string commandText, CommandType commandType,
            SqlParameter[] sqlPara)
        {
            DataTable dt = null;

            using(SqlConnection sqlConn=new SqlConnection(CONN_STRING))
            {
                using(SqlCommand sqlCmd=sqlConn.CreateCommand())
                {
                    sqlCmd.CommandText = commandText;
                    sqlCmd.CommandType = commandType;
                    sqlCmd.Parameters.AddRange(sqlPara);

                    try
                    {
                        if (sqlConn.State == ConnectionState.Closed)
                            sqlConn.Open();

                        using(SqlDataAdapter sqlDa=new SqlDataAdapter(sqlCmd))
                        {
                            dt = new DataTable();
                            sqlDa.Fill(dt);
                        }
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Method to execute the CRUD Operations with parameters
        /// </summary>
        /// <param name="commandText">The sql query/storedprocedures to execute</param>
        /// <param name="commandType">The type of commandtext e.g. text, stored procedure</param>
        /// <param name="sqlPara">Array of paramters</param>
        /// <returns>bool - no of affected rows > 0 is true else false</returns>
        internal static bool ExecuteNonQuery(string commandText, CommandType commandType,
            SqlParameter[] sqlPara)
        {
            int nRecordsAffected = 0;

            using(SqlConnection sqlConn=new SqlConnection(CONN_STRING))
            {
                using(SqlCommand sqlCmd=sqlConn.CreateCommand())
                {
                    sqlCmd.CommandText = commandText;
                    sqlCmd.CommandType = commandType;
                    sqlCmd.Parameters.AddRange(sqlPara);

                    if (sqlConn.State == ConnectionState.Closed)
                        sqlConn.Open();

                    nRecordsAffected = sqlCmd.ExecuteNonQuery();
                }
            }

            return (nRecordsAffected>0);
        }
    }
}
