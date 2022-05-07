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
    class BenhNhan_DAO
    {
        static SqlConnection con;
        public static List<BenhNhan_DTO> LayDanhSachBN()
        {
            string sTruyVan = "select * from thongtinbenhnhan";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BenhNhan_DTO> lstBenhNhan = new List<BenhNhan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BenhNhan_DTO bn = new BenhNhan_DTO();
                bn.mabenhnhan = dt.Rows[i]["mabn"].ToString();
                bn.tenbenhnhan = dt.Rows[i]["hobenhnhan"].ToString();
                bn.gioitinh = dt.Rows[i]["gioitinh"].ToString();
                bn.ngaysinh = dt.Rows[i]["ngaysinhbenhnhan"].ToString();
                bn.diachi = dt.Rows[i]["diachi"].ToString();
                bn.tuoi = dt.Rows[i]["tuoi"].ToString();
                bn.dantoc = dt.Rows[i]["dantoc"].ToString();
                bn.sdt = dt.Rows[i]["sdt"].ToString();
                lstBenhNhan.Add(bn);
            }
            return lstBenhNhan;
        }
        public static List<BenhNhan_DTO> TimBenhNhan(string ten)
        {
            string sTruyVan = string.Format(@"select * From thongtinbenhnhan where hobenhnhan like N'% {0}'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BenhNhan_DTO> lstbenhnhan = new List<BenhNhan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BenhNhan_DTO bn = new BenhNhan_DTO();
                bn.mabenhnhan = dt.Rows[i]["mabn"].ToString();
                bn.tenbenhnhan = dt.Rows[i]["hobenhnhan"].ToString();
                bn.gioitinh = dt.Rows[i]["gioitinh"].ToString();
                bn.ngaysinh = dt.Rows[i]["ngaysinhbenhnhan"].ToString();
                bn.diachi = dt.Rows[i]["diachi"].ToString();
                bn.tuoi = dt.Rows[i]["tuoi"].ToString();
                bn.dantoc = dt.Rows[i]["dantoc"].ToString();
                lstbenhnhan.Add(bn);
            }
            return lstbenhnhan;
        }
     //   public static ThemBenhNhan(string TenBN, string gioitinh, string tuoi, string ngaysinh, string diachi)
    }
}
