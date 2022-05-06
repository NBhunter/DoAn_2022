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
    class BHYT_DAO
    {
        static SqlConnection con;
        public static List<BHYT_DTO> LayDanhSachBH()
        {
            string sTruyVan = "select * from BHYT";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BHYT_DTO> listBHYT = new List<BHYT_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

            }

            return listBHYT;
        }
    }
}