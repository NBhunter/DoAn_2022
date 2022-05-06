using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBenhNhanNoiTru.DataTransferObject;

namespace QuanLyBenhNhanNoiTru.DataAccessLayers
{
    class Benh_DAO
    {
        static SqlConnection con;
        public static List<Benh_DTO> LayDanhSachBenh()
        {
            string sTruyVan = "select * from benh";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Benh_DTO> lstBenh = new List<Benh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Benh_DTO benh = new Benh_DTO();
                benh.mabenh = dt.Rows[i]["mabenh"].ToString();
                benh.tenbenh = dt.Rows[i]["tenbenh"].ToString();
                benh.mota = dt.Rows[i]["mota"].ToString();
                
                lstBenh.Add(benh);
            }
            return lstBenh;
        }
    }
}
