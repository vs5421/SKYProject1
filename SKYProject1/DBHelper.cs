using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SKYProject1
{
   public class DBHelper
    {
        public DBHelper()
        {
            con = new SqlConnection(strCon);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
         private string strCon = "server=DESKTOP-HB10IB3;database=SkyProject;uid=sa;password=123;";
       // private string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        // private SqlConnection con = null;
        private IDbConnection con = null;
        //private SqlCommand cmd = null;
        private IDbCommand cmd = null;
        public object ExecuteScalar(string strSQL, CommandType commandType = CommandType.Text, params IDataParameter[] parameter)
        {
            object obj = null;
            try
            {

                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandType;
                this.cmd.Parameters.Clear();
                foreach (var item in parameter)
                {
                    this.cmd.Parameters.Add(item);
                }
                this.con.Open();
                obj = this.cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { this.con.Close(); }
            return obj;
        }
        public int ExecuteNonQuery(string strSQL, CommandType commandType = CommandType.Text, params IDataParameter[] parameter)
        {
            int rows = 0;
            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandType;
                this.cmd.Parameters.Clear();
                foreach (var item in parameter)
                {
                    this.cmd.Parameters.Add(item);
                }
                this.con.Open();
                rows = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { con.Close(); }

            return rows;

        }
        public IDataReader ExecuteReader(string strSQL, CommandType commandType = CommandType.Text, params IDataParameter[] parameter)
        {
            IDataReader reader = null;
            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandType;
                this.cmd.Parameters.Clear();
                foreach (var item in parameter)
                {
                    this.cmd.Parameters.Add(item);
                }
                this.con.Open();
                reader = this.cmd.ExecuteReader(CommandBehavior.CloseConnection);
                
            }
            catch (Exception e)
            {
                throw e;
            }


            return reader;

        }
    }
}
    

