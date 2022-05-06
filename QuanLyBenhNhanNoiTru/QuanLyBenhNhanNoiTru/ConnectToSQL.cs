using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyBenhNhanNoiTru
{
    internal class ConnectToSQL
    {
        #region Availible
        private SqlConnection Conn;
        private SqlCommand _cmd;
        private string StrCon = null;
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public SqlConnection Connection
        {
            get { return Conn; }
        }

        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        #endregion
        #region Contrustor
        public ConnectToSQL()
        {
            StrCon = @"Data Source=DESKTOP-55LGLQF\NBhunter;Initial Catalog=QLBN;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
        }
        #endregion

        #region Methods
        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = Conn;
            try
            {
                this.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                this.CloseConn();
            }
            return dt;
        }
        public bool SetData(string sql)
        {
            _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = Conn;
            try
            {
                this.OpenConn();
                CMD.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                this.CloseConn();
            }
            return false;
        }
        public DataTable TimKiem(string sql, string ChuoiTimKiem)
        {
            OpenConn();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("Ma", SqlDbType.NVarChar)).Value = ChuoiTimKiem;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConn();
            return dt;



        }
        #endregion
    }
}