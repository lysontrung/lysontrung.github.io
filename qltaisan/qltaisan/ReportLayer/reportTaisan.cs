using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qltaisan
{
    public partial class reportTaisan : Form
    {
        qltaisan data = new qltaisan();
        public reportTaisan()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            data = new qltaisan();
            var query = (from a in data.TAISANs
                         from b in data.LOAITAISANs
                         from c in data.DONVITINHs
                         from d in data.NHAPTS
                         from f in data.CHITIETNHAPTS
                         where a.MALOAI == b.MALOAI
                         && a.MADONVITINH == c.MADONVITINH
                         && a.MATAISAN == f.MATAISAN
                         && d.MANHAPTS == f.MANHAPTS
                         select new
                         {
                             TENLOAI = b.TENLOAI,
                             TENTAISAN = a.TENTAISAN,
                             NHANVIEN = f.NHANVIEN,
                             TENDONVITINH = c.TENDONVITINH,
                             GIA = a.GIA,
                             NGAYNHAP = d.NGAYNHAP,
                             SOLUONG = f.SOLUONG,
                         }
                ).ToList();
            dataReportTaisan dataRp = new dataReportTaisan();
            dataRp.SetDataSource(query);
            this.vrpTaisan.ReportSource = dataRp;
        }
    }
}
