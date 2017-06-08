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
    public partial class reportThanhly : Form
    {
        qltaisan data = new qltaisan();
        public reportThanhly()
        {
            InitializeComponent();
        }

        private void reportThanhly_Load(object sender, EventArgs e)
        {
            data = new qltaisan();
            var query = (from a in data.TAISANs
                         from b in data.LOAITAISANs
                         from c in data.THANHLies                      
                         where c.MATAISAN == a.MATAISAN
                         && a.MALOAI == b.MALOAI
                         select new
                         {
                             MATHANHLY = c.MATHANHLY,
                             TENLOAI = b.TENLOAI,
                             TENTAISAN = a.TENTAISAN,
                             SOLUONG = c.SOLUONG,
                             GIATRITHANHLY = c.GIATRITHANHLY,
                         }
                ).ToList();
            dataReportThanhly dataRp = new dataReportThanhly();
            dataRp.SetDataSource(query);
            this.vcrThanhly.ReportSource = dataRp;
        }

        private void vcrThanhly_Load(object sender, EventArgs e)
        {

        }
    }
}
