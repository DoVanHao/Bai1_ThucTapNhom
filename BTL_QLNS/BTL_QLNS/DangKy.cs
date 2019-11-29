﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTL_QLNS.BUS;
using System.Data.SqlClient;
namespace BTL_QLNS
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }



        private void btnDangky_Click(object sender, EventArgs e)
        {
            User_BUS ub = new User_BUS();
            try
            {
                if (txtNhaplai.Text == txtMatkhau.Text)
                {
                    ub.insertUser(txtTaikhoan.Text, txtMatkhau.Text, txtMaNv.Text);
                    MessageBox.Show("Đăng ký tài khoản thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng !");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn nhập sai cú pháp !");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
            }

        }
        private void btnDangky_Click_double(object sender, EventArgs e)
        {
            User_BUS ub = new User_BUS();
            try
            {
                if (txtNhaplai.Text == txtMatkhau.Text)
                {
                    ub.insertUser(txtTaikhoan.Text, txtMatkhau.Text, txtMaNv.Text);
                    MessageBox.Show("Đăng ký tài khoản thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng !");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn nhập sai cú pháp !");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
            }

        }

private void btnDangky_Click(object sender, EventArgs e)
        {
            User_BUS ub = new User_BUS();
            try
            {
                if (txtNhaplai.Text == txtMatkhau.Text)
                {
                    ub.insertUser(txtTaikhoan.Text, txtMatkhau.Text, txtMaNv.Text);
                    MessageBox.Show("Đăng ký tài khoản thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng !");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn nhập sai cú pháp !");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
            }

        }
		
		// them
		private void DangKy_Loadform(object sender, EventArgs e)
        {

        }
    }
}
