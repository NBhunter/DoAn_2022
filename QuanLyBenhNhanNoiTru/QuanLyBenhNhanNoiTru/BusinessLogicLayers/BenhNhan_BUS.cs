using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBenhNhanNoiTru.DataAccessLayers;
using QuanLyBenhNhanNoiTru.DataTransferObject;

namespace QuanLyBenhNhanNoiTru.BusinessLogicLayers
{
    class BenhNhan_BUS
    {
        public static List<BenhNhan_DTO> LayDanhSach()
        {
            return BenhNhan_DAO.LayDanhSachBN();
        }
        public static List<BenhNhan_DTO> TimBenhNhan(string ten)
        {
            return BenhNhan_DAO.TimBenhNhan(ten);
        }
    }
}
