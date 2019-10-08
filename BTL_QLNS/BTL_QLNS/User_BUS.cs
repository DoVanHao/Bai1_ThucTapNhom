using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BTL_QLNS.DAL;
using BTL_QLNS.DTO;
namespace BTL_QLNS.BUS
{
    class User_BUS
    {
        User_DTO U = new User_DTO();
        Data da = new Data();
        public DataTable getUser(String condition)
        {
            DataTable dt = null;
            String sql = "Select * from DANGNHAP where " + condition;
            dt=da.getTable(sql);
            return dt;
        }
        public void insertUser(String username, String pass, String manv)
        {
            String sql = "insert into DANGNHAP values('" + username + "','" + pass + "','" + manv + "')";
            da.ExcuteNonQuery(sql);
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
    }
}
