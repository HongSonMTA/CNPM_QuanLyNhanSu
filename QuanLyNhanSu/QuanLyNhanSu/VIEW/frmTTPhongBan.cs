using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.BUS;
using QuanLyNhanSu.ENTITY;
using QuanLyNhanSu.VIEW;
namespace QuanLyNhanSu
{
    public partial class frmTTPhongBan : Form
    {
        public frmTTPhongBan()
        {
            InitializeComponent();
        }

        private void frmTTPhongBan_Load(object sender, EventArgs e)
        {
            PhongbanBus busPB = new PhongbanBus();
            dgvNhanVien.DataSource = busPB.GetData1(frmphongBan.Ma);
        }
    }
}
