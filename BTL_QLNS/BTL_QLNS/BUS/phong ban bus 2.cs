﻿using System;
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
        Data dt = new Data();
        public DataTable getPHONGBAN()
        {
            DataTable da = null;
            String sql = "Select * from PHONGBAN ";
            da = dt.getTable(sql);
            return da;
        }
        public void insertPB(String maPB, String tenPB, int sonv, String mota)
        {
            String sql = " insert into PHONGBAN values('" + maPB + "',N'" + tenPB + "','" + sonv + "',N'" + mota + "')";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Thêm thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm thất bại !");
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable Search(String condi)
        {
            DataTable da = null;
            String sql = "Select * from PHONGBAN where id_Pb like N'%" + condi + "%' OR name_PB like N'%" + condi + "%'";
            da = dt.getTable(sql);
            return da;
        }
    }
}
