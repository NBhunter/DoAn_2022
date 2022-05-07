using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhNhanNoiTru.DataAccessLayers;
using QuanLyBenhNhanNoiTru.DataTransferObject;
using QuanLyBenhNhanNoiTru.BusinessLogicLayers;
using System.Threading;


namespace QuanLyBenhNhanNoiTru
{
    public partial class frm_Login : Form
    {
        string fileSPath = @"D:\study\LTQL\DoAn_2022\QuanLyBenhNhanNoiTru\filelog.txt";
        main f1 = new main();
        static SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        public frm_Login()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void btnLogin_Click(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            string str;
            
            string Kiemtra = ("select * from dangnhap where taikhoan= N'" + txttk.Text + "' and matkhau= N'" + txtmk.Text + "'");
            con = DataProvider.MoKetNoi();
            dt = DataProvider.TruyVanLayDuLieu(Kiemtra, con);
            pgLoad.Visible = true;
            timer1.Start();
            for(int i =0; i < 1; i++)
            {
                Thread.Sleep(10000);
            }
            if (dt.Rows.Count >0  )
            {
                
                
                
            }
            else
            {
                MessageBox.Show("thông tin đăng nhập sai");
            }
            //

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            pgLoad.Visible = false;

            txtmk.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgLoad.PerformStep();
            
            if (pgLoad.Value == 100)
            {
                timer1.Stop();
                pgLoad.Value = 0;
                f1.login_info = "Xin Chào: ";
                f1.login_info += dt.Rows[0][3].ToString();
                f1.login_info += "(" + dt.Rows[0][2].ToString() + ")";

                f1.ShowDialog();
                this.Hide();
                
                
                
            }
        }

        /*private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton1.Checked)
            {
                //Hides Textbox password
                txtmk.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;


                checkButton1.Appearance.BackColor = Color.FromArgb(242, 106, 0);
                checkButton1.Appearance.BackColor2 = Color.FromArgb(242, 106, 0);
                checkButton1.Appearance.GetImage = 
            }
            else
            {
                txtmk.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                //eckButton1.BackColor = Color.DodgerBlue;

                checkButton1.Appearance.BackColor = Color.FromArgb(242, 106, 0);
                checkButton1.Appearance.BackColor2 = Color.FromArgb(242, 106, 0);

            }
        }*/

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtmk.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            
            
            simpleButton1.Hide();
            simpleButton2.Show();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtmk.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            simpleButton2.Hide();
            simpleButton1.Show();
        }
    }
}
