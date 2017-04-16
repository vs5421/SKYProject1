using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SKYProject1
{
     public  class DBHelper
    {
        public DBHelper()
        {
            con = new SqlConnection(strCon);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        private string strCon = @"server=DESKTOP-CBE5RT7;database=SkyProject;uid=sa;password=123";
        private SqlConnection con = null;
        private SqlCommand cmd = null;

        public object ExecuteScalar(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            object obj = null;
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

        public int ExecuteNonQuery(string strSQL, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            int rows = 0;
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
    }
}
