using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SKYProject1
{
    public class DBHelp
    {
        public DBHelp()
        {
            con = new SqlConnection(strCon);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        private string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        public object ExecuteScalar(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            object obj = null;
            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandType;
                cmd.Parameters.Clear();
                foreach (var item in parameters)
                {
                    this.cmd.Parameters.Add(item);
                }

                this.con.Open();
                obj = this.cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.con.Close();
            }

            return obj;
        }

        public async Task<object> ExecuteScalarAsnyc(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            return await Task<object>.Run(() => {
                return ExecuteScalar(strSQL, commandType, parameters);
            });
        }

        public int ExecuteNonQuery(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            int rows = 0;
            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandType;
                cmd.Parameters.Clear();
                foreach (var item in parameters)
                {
                    this.cmd.Parameters.Add(item);
                }
                this.con.Open();
                rows = this.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.con.Close();
            }

            return rows;
        }
        public async Task<int> ExecuteNonQueryAsync(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            return await Task<int>.Run(
                () => { return ExecuteNonQuery(strSQL, commandType, parameters); }
                );
        }

        public SqlDataReader ExecuteReader(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            SqlDataReader reader = null;
            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandType;
                this.cmd.Parameters.Clear();
                foreach (var item in parameters)
                {
                    this.cmd.Parameters.Add(item);
                }
                this.con.Open();
                reader = this.cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reader;
        }
        public async Task<SqlDataReader> ExecuteReaderAsync(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            return await Task<SqlDataAdapter>.Run(
                () => { return ExecuteReader(strSQL, commandType, parameters); }
                );
        }
    }
}

