using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBenhNhanNoiTru.DataAccessLayers;
using QuanLyBenhNhanNoiTru.DataTransferObject;

namespace QuanLyBenhNhanNoiTru.BusinessLogicLayers
{
    class BHYT_BUS
    {
        public static List<BHYT_DTO> LayDanhSach(string mabenhnhan)
        {
            return BHYT_DAO.LayDanhSachBH(mabenhnhan);
        }
    }
}
