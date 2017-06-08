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
    public partial class reportKiemke : Form
    {
        qltaisan data = new qltaisan();
        public reportKiemke()
        {
            InitializeComponent();
        }

        private void reportKiemke_Load(object sender, EventArgs e)
        {
            data = new qltaisan();
            var query = (from a in data.TAISANs
                         from b in data.LOAITAISANs
                         from c in data.KIEMKEs
                         from d in data.TINHTRANGs
                         where a.MALOAI == b.MALOAI
                         && c.MATAISAN == a.MATAISAN
                         && c.MATINHTRANG == d.MATINHTRANG
                         select new
                         {
                             MAKIEMKE = c.MAKIEMKE,
                             TENLOAI = b.TENLOAI,
                             TENTAISAN = a.TENTAISAN,
                             NHANVIEN = c.NHANVIEN,
                             TINHTRANG = d.TINHTRANG1,
                             NGAYKIEMKE = c.NGAYKIEMKE,
                         }
                ).ToList();
            dataReportKiemke dataRp = new dataReportKiemke();
            dataRp.SetDataSource(query);
            this.vcrKiemke.ReportSource = dataRp;
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
