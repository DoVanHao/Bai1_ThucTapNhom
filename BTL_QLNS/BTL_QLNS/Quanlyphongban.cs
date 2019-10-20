using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTL_QLNS.BUS;
namespace BTL_QLNS
{
    public partial class Quanlyphongban : Form
    {
        public Quanlyphongban()
        {
            InitializeComponent();
        }
        PhongBan_BUS pbb = new PhongBan_BUS();
        private void btnExit_Click(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            anHinhChinh frch = new ManHinhChinh();
            frch.Show(dt);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPhongban.DataSource = pbb.Search(txtSearch.Text);

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int sonv=0;
            if (txtMaPB.Text.Trim() == "")
                MessageBox.Show("Mã phòng ban không được để trống !");
            else if (txtTenPB.Text.Trim() == "")
                MessageBox.Show("Tên phòng ban không được để trống !");
            else
                pbb.insertPB(txtMaPB.Text,txtTenPB.Text,sonv,txtMota.Text);
            Quanlyphongban_Load(sender, e);
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSPX.Rows.Count; i++)
            {
                if (dgvSPX.Rows[i].Cells[0].Value == dgvSP.Rows[dgvSP.SelectedRows[0].Index].Cells[0].Value)
                {
                    MessageBox.Show("Sản phẩm đã được chọn !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (dgvSP.SelectedRows.Count > 0)
            {
                dgvSPX.Rows.AddRange(new DataGridViewRow());
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[0].Value = dgvSP.Rows[dgvSP.SelectedRows[0].Index].Cells[0].Value;
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[1].Value = numericUpDownSL.Value;
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[2].Value = numericUpDownGN.Value;
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[3].Value = int.Parse(numericUpDownSL.Value.ToString()) * long.Parse(numericUpDownGN.Value.ToString());
            }
        }
		        private void btnThemSP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSPX.Rows.Count; i++)
            {
                if (dgvSPX.Rows[i].Cells[0].Value == dgvSP.Rows[dgvSP.SelectedRows[0].Index].Cells[0].Value)
                {
                    MessageBox.Show("Sản phẩm đã được chọn !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (dgvSP.SelectedRows.Count > 0)
            {
                dgvSPX.Rows.AddRange(new DataGridViewRow());
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[0].Value = dgvSP.Rows[dgvSP.SelectedRows[0].Index].Cells[0].Value;
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[1].Value = numericUpDownSL.Value;
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[2].Value = numericUpDownGN.Value;
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[3].Value = int.Parse(numericUpDownSL.Value.ToString()) * long.Parse(numericUpDownGN.Value.ToString());
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
		
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text.Trim() == "")
                MessageBox.Show("Mã phòng ban không được để trống !");
            else if (txtTenPB.Text.Trim() == "")
                MessageBox.Show("Tên phòng ban không được để trống !");
            else
            {
                try
                {
                    pbb.updatePB(txtMaPB.Text, txtTenPB.Text, int.Parse(txtSoNV.Text), txtMota.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Số nhân viên phải là kiểu số nguyên !"+ex.Message);
                }
            }
            Quanlyphongban_Load(sender, e);
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
        private void dgvPhongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaPB.Text = dgvPhongban.Rows[index].Cells[0].Value.ToString();
                txtTenPB.Text = dgvPhongban.Rows[index].Cells[1].Value.ToString();
                txtSoNV.Text = dgvPhongban.Rows[index].Cells[2].Value.ToString();
                txtMota.Text = dgvPhongban.Rows[index].Cells[3].Value.ToString();
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }
        private void Quanlyphongban_Load(object sender, EventArgs e)
        {
            dgvPhongban.DataSource=pbb.getPHONGBAN();
        }
    }
}
