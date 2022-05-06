using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhanNoiTru.DataTransferObject
{
    class Login_DTO
    {
        private string TaiKhoan;
        public string taikhoan
        {
            get { return TaiKhoan; }
            set { TaiKhoan = value; }
        }
        private string MatKhau;
        public string matkhau
        {
            get { return MatKhau; }
            set { MatKhau = value; }
        }
        private string Loaitaikhoan;
        public string loaitaikhoan
        {
            get { return Loaitaikhoan; }
            set { Loaitaikhoan = value; }
        }
        private string Tennguoidung;
        public string tennguoidung
        {
            get { return Tennguoidung; }
            set { Tennguoidung = value; }
        }
    }
}
