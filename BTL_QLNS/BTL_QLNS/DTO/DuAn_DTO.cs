using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTL_QLNS.DTO
{
    public class DuAn_DTO
    {
        String maDa;
        String tenDa;
        int sonvDa;
        String motaDa;
        public String MaDa
        {
            get { return maDa; }
            set { maDa = value; }
        }
        public String TenDa
        {
            get { return tenDa; }
            set { tenDa = value; }
        }
        public int SonvDa
        {
            get { return sonvDa; }
            set { sonvDa = value; }
        }
        public String MotaDa
        {
            get { return motaDa; }
            set { motaDa = value; }
        }
        public String selectPB(String mapb)
        {
            String tenpb;
            String sql = "select name_Pb from PHONGBAN where id_Pb='" + mapb + "'";
            tenpb = dt.ExcuteScalar(sql);
            return tenpb;
        }
    }
}
