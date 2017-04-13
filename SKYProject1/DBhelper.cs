using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace SKYProject1
{
    public class DBhelper
    {
        public DBhelper()
        {
            con = new SqlConnection(strCon);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        IDbConnection con = null;
        IDbCommand cmd = null;
        public int ExecuteNonQuery(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] param)
        {
            int rows = 0;
            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandType;
                this.cmd.Parameters.Clear();
                foreach (var item in param)
                {
                    this.cmd.Parameters.Add(item);
                }
                this.con.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.con.Close();
            }
            return rows;
        }
        public IDataReader SqlDataReader(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] param)
        {
            IDataReader reader = null;
            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandType;
                this.cmd.Parameters.Clear();
                foreach (var item in param)
                {
                    this.cmd.Parameters.Add(item);
                }
                this.con.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                throw;
            }
            return reader;
        }

        public Task<IDataReader> ExecuteReaderAsync(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] param)
        {
            return Task<IDataReader>.Run(() =>
            {
                return SqlDataReader(strSQL, commandType, param);
            });
        }

        public Task<int> ExecuteNonQueryAsync(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] param)
        {
            return Task<int>.Run(() =>
            {
                return ExecuteNonQuery(strSQL, commandType, param);
            });
        }

    }
}
