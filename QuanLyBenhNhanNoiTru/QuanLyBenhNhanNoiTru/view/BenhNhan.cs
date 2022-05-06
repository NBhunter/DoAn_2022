using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhNhanNoiTru.DataAccessLayers;
using QuanLyBenhNhanNoiTru.DataTransferObject;
using QuanLyBenhNhanNoiTru.BusinessLogicLayers;

namespace QuanLyBenhNhanNoiTru.view
{
    public partial class BenhNhan : UserControl
    {
        public BenhNhan()
        {
            InitializeComponent();
        }

        private void BenhNhan_Load(object sender, EventArgs e)
        {
            HienThiLenDaTa();
        }
        private void HienThiLenDaTa()
        {
            List<BenhNhan_DTO> lstbenhnhan = BenhNhan_BUS.LayDanhSach();
            dgvDanhSachBN.DataSource = lstbenhnhan;
            //bhyt

            //danh sach ben an
        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            List<BenhNhan_DTO> lstbenhnhan = BenhNhan_BUS.TimBenhNhan(txtTimTen.Text);
            dgvDanhSachBN.DataSource = lstbenhnhan;
        }
    }
}
