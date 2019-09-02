using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTL_QLNS
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }
        private void frm_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Quanlynhanvien frmnv = new Quanlynhanvien();
            frmnv.Show();
            this.Hide();
        }

    }
}
