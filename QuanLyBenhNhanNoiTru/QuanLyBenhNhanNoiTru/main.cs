using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhNhanNoiTru.view;
namespace QuanLyBenhNhanNoiTru
{
    public partial class main : Form
    {
        public string login_info;
        public main()
        {
            InitializeComponent();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (panelmenu.Visible == false)
                panelmenu.Visible = true;
            else
                panelmenu.Visible = false;
        }

        private void btnformbenhnhan_Click(object sender, EventArgs e)
        {
            BenhNhan f1 = new BenhNhan();
            this.Text = "Quản Lý Thông Tin Bệnh Viện - Thông Tin Bệnh Nhân";
            panelmain.Controls.Clear();
            panelmain.Controls.Add(f1);
            panelmenu.Visible = false;
        }

        private void btnformBenh_Click(object sender, EventArgs e)
        {
            Benh f2 = new Benh();
            this.Text = "Quản Lý Thông Tin Bệnh Viện - Thông Tin Bệnh";
            panelmain.Controls.Clear();
            panelmain.Controls.Add(f2);
            panelmenu.Visible = false;
        }

        private void btnformbenhan_Click(object sender, EventArgs e)
        {
            BenhAn f4 = new BenhAn();
            this.Text = "Quản Lý Thông Tin Bệnh Viện - Thông Tin Bệnh Án";
            panelmain.Controls.Clear();
            panelmain.Controls.Add(f4);
            panelmenu.Visible = false;
        }

        private void main_Load(object sender, EventArgs e)
        {
            BenhNhan f1 = new BenhNhan();
            this.Text = "Quản Lý Thông Tin Bệnh Viện - Thông Tin Bệnh Nhân";
            panelmain.Controls.Clear();
            panelmain.Controls.Add(f1);
            panelmenu.Visible = false;
            lbLogin.Text = login_info;
        }
    }
}
