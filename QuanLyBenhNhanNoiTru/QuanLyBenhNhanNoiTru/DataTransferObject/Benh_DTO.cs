using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhanNoiTru.DataTransferObject
{
    class Benh_DTO
    {
        private string MaBenh;
        public string mabenh
        {
            get { return MaBenh; }
            set { MaBenh = value; }
        }

        private string TenBenh;
        public string tenbenh 
        {
            get { return TenBenh; }
            set { TenBenh = value; }
        }
        private string MoTa;
        public string mota
        {
            get { return MoTa; }
            set { MoTa = value; }
        }
    }
}
