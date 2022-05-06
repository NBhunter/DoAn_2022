using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhNhanNoiTru.DataTransferObject
{
    class BenhNhan_DTO
    {
        private string MaBenhNhan;
        public string mabenhnhan
        {
            get{ return MaBenhNhan; }
            set { MaBenhNhan = value; }
        }
        private string HoTenBenhNhan;

        private string TenBenhNhan;
        public string tenbenhnhan
        {
            get { return TenBenhNhan; }
            set { TenBenhNhan = value; }
        }
        private string NgaySinh;
        public string ngaysinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        private string GioiTinh;
        public string gioitinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        private string DiaChi;
        public string diachi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        private string DanToc;
        public string dantoc
        {
            get { return DanToc; }
            set { DanToc = value; }
        }
        private string Tuoi;
        public string tuoi
        {
            get { return Tuoi; }
            set { Tuoi = value; }
        }
    }
}
