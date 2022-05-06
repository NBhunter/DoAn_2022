﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhanNoiTru.DataAccessLayers
{
    class DataProvider
    {
        public static SqlConnection MoKetNoi()
        {
            string s = @"Data Source=LAPTOP-QGHVIL28\NBHUNTER;Initial Catalog=QLBN;Integrated Security=True";
            SqlConnection KetNoi = new SqlConnection(s);
            KetNoi.Open();
            return KetNoi;
        }
        public static void DongKetNoi(SqlConnection KetNoi)
        {
            KetNoi.Close();
        }
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection
      KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection
      KetNoi)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
