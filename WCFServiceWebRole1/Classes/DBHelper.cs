using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.WindowsAzure;
using System.Data;


namespace CanvasserPortalWebApplication.Classes
{
    public class DBHelper
    {
        #region Variables


        string connectionString = null;
        SqlConnection sqlConnection = null;
        SqlDataAdapter sqlDataAdapter = null;
        SqlCommand sqlCommand = null;
        #endregion
        



        public DBHelper()
        {
            #if DEBUG
                        var connection = CloudConfigurationManager.GetSetting("ConnectionQA");
            #else
                      var connection = CloudConfigurationManager.GetSetting("Connection");
            #endif
                        this.connectionString = connection.ToString();
            this.sqlConnection = new SqlConnection(this.connectionString);
            this.sqlCommand = new SqlCommand();
            this.sqlCommand.Connection = this.sqlConnection;
            this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
        }

        public void AddStoredProcedureParameter(string paramName, SqlDbType paramType, object value)
        {
            try
            {
            this.sqlCommand.Parameters.Add(parameterName: paramName, sqlDbType: paramType);
            this.sqlCommand.Parameters[paramName].Value = value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State != ConnectionState.Closed)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public void deleteStoredProcedurePrameters()
        {
            try
            {
            this.sqlCommand.Parameters.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State != ConnectionState.Closed)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public DataSet getDataSet(string procedureName, string tableName)
        {
            try
            {
                this.sqlCommand.CommandText = procedureName;
                this.sqlCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                this.sqlDataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State != ConnectionState.Closed)
                {
                    this.sqlConnection.Close();
                }
            }

        }

        public void executeNonQuery(string procedureName)
        {
            try
            {
                this.sqlCommand.CommandText = procedureName;
                this.sqlCommand.CommandType = CommandType.StoredProcedure;
                this.sqlConnection.Open();
                this.sqlCommand.ExecuteNonQuery();
                this.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.sqlConnection != null & this.sqlConnection.State != ConnectionState.Closed)
                {
                    this.sqlConnection.Close();
                }
            }
        }

    }
}