﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL_QLNS.DAL;
namespace BTL_QLNS.BUS
{
    class NhanVien_BUS
    {
        Data dt = new Data();
        public DataTable getNhanvien()
        {
            DataTable da = null;
            String sql = "Select * from NhanVien ";
            da = dt.getTable(sql);
            return da;
            da.fill();
        }
       

        public void insertNV(String manv, String tennv, String ngaysinh, String diachi, int luong, String mapb, String mada)
        {
            String sql = " insert into NHANVIEN values('" + manv + "',N'" + tennv + "','" + ngaysinh + "',N'" + diachi + "','" + luong + "',N'" + mapb + "',N'" + mada + "')";
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
        public void updateNV(String manv, String tennv, String ngaysinh, String diachi, int luong, String mapb, String mada)
        {
            String sql = "UPDATE NHANVIEN set name_Nv=N'" + tennv + "',ngaysinh_Nv='" + ngaysinh + "',diachi_Nv=N'" + diachi + "',luong_Nv='" + luong + "',id_Pb='" + mapb + "',id_Da='" + mada + "' where id_Nv='" + manv + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Sửa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa thất bại !");
                MessageBox.Show(ex.Message);
            }
        }
       
        public DataTable Search(String condi)
        {
            DataTable da = null;
            String sql = "Select * from NhanVien where id_Nv like N'%" + condi + "%' OR name_Nv like N'%" + condi + "%'";
            da = dt.getTable(sql);
            return da;
        }
        public String selectPB(String mapb)
        {
            String tenpb;
            String sql = "select name_Pb from PHONGBAN where id_Pb='" + mapb + "'";
            tenpb = dt.ExcuteScalar(sql);
            return tenpb;

            DataTable da = null;
            String tenpb = "Select * from DUAN where id_DA like N'%" + condi + "%' OR name_DA like N'%" + condi + "%'";
            da = dt.getTable(sql);

        }

        public String selectDA(String mada)
        {
            String tenda;
            String sql = "select name_Da from DUAN where id_Da='" + mada + "'";
            tenda = dt.ExcuteScalar(sql);
            return tenda;
        }
		        public void updatePB(String maPB, String tenPB, int sonv, String mota)
        {
            String sql = "UPDATE PHONGBAN set name_PB=N'" + tenPB + "',sonv_Pb='" + sonv + "',mota_Pb=N'" + mota + "' where id_Pb='" + maPB + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Sửa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa thất bại !");
                MessageBox.Show(ex.Message);
            }
        }
        public void deletePB(String maPB)
        {
            String sql = "delete PHONGBAN where id_Pb='" + maPB + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Xóa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi CSDL !" + ex.Message);

            }
        }
    }
}
