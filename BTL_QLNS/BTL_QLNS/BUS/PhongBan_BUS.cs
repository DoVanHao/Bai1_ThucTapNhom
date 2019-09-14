using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTL_QLNS.DAL;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_QLNS.BUS
{
    class PhongBan_BUS
    {
        Data da = new Data();
        public DataTable getPHONGBAN()
        {
            DataTable dt = null;
            String sql = "Select * from dbo.PHONGBAN ";
            dt = da.getTable(sql);
            return dt;
        }
        public void insertPB(String maPB, String tenPB, int sonv, String mota)
        {
            String sql = " insert into dbo.PHONGBAN values('" + maPB + "',N'" + tenPB + "','" + sonv + "',N'" + mota + "')";
            try
            {
                da.ExcuteNonQuery(sql);
                MessageBox.Show("Thêm thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm thất bại !");
                MessageBox.Show(ex.Message);
            }
        }
        public void updatePB(String maPB, String tenPB, int sonv, String mota)
        {
            String sql = "UPDATE PHONGBAN set name_PB=N'" + tenPB + "',sonv_Pb='" + sonv + "',mota_Pb=N'" + mota + "' where id_Pb='" + maPB + "'";
            try
            {
                da.ExcuteNonQuery(sql);
                MessageBox.Show("Sửa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không sửa được ! Vui lòng thử lại");
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }
          public DataTable Search(String condi)
        {
            DataTable da = null;
            String sql = "Select * from dbo.PHONGBAN where id_Pb like N'%" + condi + "%' OR name_PB like N'%" + condi + "%'";
            dt = da.getTable(sql);      
            return da;
        }
        public DataTable Search(String condi)
        {
            DataTable da = null;
            String sql = "Select * from dbo.PHONGBAN where id_Pb like N'    %" + condi + "%' OR name_PB like N'%" + condi + "%'";
            dt = da.getTable(sql);
            return da;
        }
            
    }
}
