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
    public partial class Benh : UserControl
    {
        public Benh()
        {
            InitializeComponent();
        }

        private void Benh_Load(object sender, EventArgs e)
        {
            Loadttbenh();
        }
        private void Loadttbenh()
        {
            List<Benh_DTO> lstbenh = Benh_BUS.LayDanhSachBenh();

            dgvBenh.DataSource = lstbenh;
            dgvBenh.Columns["mota"].Width = 1300;
            
        }
    }
}
