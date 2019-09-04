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
        public String selectPB(String mapb)
        {
            String tenpb;
            String sql = "select name_Pb from PHONGBAN where id_Pb='" + mapb + "'";
            tenpb = dt.ExcuteScalar(sql);
            return tenpb;
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
