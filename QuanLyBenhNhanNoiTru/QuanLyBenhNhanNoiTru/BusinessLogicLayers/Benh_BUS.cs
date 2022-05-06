using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBenhNhanNoiTru.DataAccessLayers;
using QuanLyBenhNhanNoiTru.DataTransferObject;

namespace QuanLyBenhNhanNoiTru.BusinessLogicLayers
{
    class Benh_BUS
    {
        public static List<Benh_DTO> LayDanhSachBenh()
        {
            return Benh_DAO.LayDanhSachBenh();
        }
    }
}
