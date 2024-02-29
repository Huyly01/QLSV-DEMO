using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class SVDal
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public SVDal()
        {
            dc = new DataConnection();
        }
        public DataTable getAllSinhVien()
        {
            string sql = "SELECT * FROM TTSV";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertSinhVien(TTSV sv)
        {
            string sql = "INSERT INTO TTSV(MASV, TENSV, KHOA, LOP, DIACHI) VALUES (@MASV, @TENSV, @KHOA, @LOP, @DIACHI)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = sv.MASV;
                cmd.Parameters.Add("@TENSV", SqlDbType.NVarChar).Value = sv.TENSV;
                cmd.Parameters.Add("@KHOA", SqlDbType.NVarChar).Value = sv.KHOA;
                cmd.Parameters.Add("@LOP", SqlDbType.NVarChar).Value = sv.LOP;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = sv.DIACHI;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdateSinhVien(TTSV sv)
        {
            string sql = "UPDATE INTO TTSV(MASV = @MASV, TENSV = @TENSV, KHOA = @KHOA, LOP = @LOP, DIACHI= @DIACHI WHERE ID = @ID) ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = sv.ID;
                cmd.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = sv.MASV;
                cmd.Parameters.Add("@TENSV", SqlDbType.NVarChar).Value = sv.TENSV;
                cmd.Parameters.Add("@KHOA", SqlDbType.NVarChar).Value = sv.KHOA;
                cmd.Parameters.Add("@LOP", SqlDbType.NVarChar).Value = sv.LOP;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = sv.DIACHI;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteSV(TTSV sv)
        {
            string sql = "DETELE TTSV WHERE ID = @ID) ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = sv.ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }

}