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
    public partial class trangThongke : Form
    {
        qltaisan data = new qltaisan();
        reportTaisan _reportTaisan;
        reportKiemke _reportKiemke;
        reportThanhly _reportThanhly;
        
        public trangThongke()
        {
            InitializeComponent();
        }
        private void loadDstaisan()
        {
            qltaisan data = new qltaisan();
            var query = (from a in data.TAISANs
                         from b in data.LOAITAISANs
                         from c in data.DONVITINHs
                         from d in data.NHAPTS
                         from e in data.CHITIETNHAPTS
                         where a.MALOAI == b.MALOAI
                         && a.MADONVITINH == c.MADONVITINH
                         && a.MATAISAN == e.MATAISAN
                         && d.MANHAPTS == e.MANHAPTS
                         select new
                         {
                             loaits = b.TENLOAI,
                             tents = a.TENTAISAN,
                             e.NHANVIEN,
                             dvtinh = c.TENDONVITINH,
                             gia = a.GIA,
                             ngaynhap = d.NGAYNHAP,
                             soluong = e.SOLUONG,            
                         }
                ).ToList();
            grvTaisan.DataSource = query;
            grvTaisan.Columns[0].HeaderText = "TÊN LOẠI";
            grvTaisan.Columns[1].HeaderText = "TÊN TÀI SẢN";
            grvTaisan.Columns[2].HeaderText = "NHÂN VIÊN NHẬP";
            grvTaisan.Columns[3].HeaderText = "ĐƠN VỊ TÍNH";
            grvTaisan.Columns[4].HeaderText = "GIÁ";
            grvTaisan.Columns[5].HeaderText = "NGÀY NHẬP";
            grvTaisan.Columns[6].HeaderText = "SỐ LƯỢNG";
        }
        private void loadDskiemke()
        {
            qltaisan data = new qltaisan();
            var query = (from a in data.KIEMKEs
                         from b in data.TAISANs
                         from c in data.TINHTRANGs
                         where a.MATINHTRANG == c.MATINHTRANG
                         && a.MATAISAN == b.MATAISAN
                         select new
                         {
                             makk = a.MAKIEMKE,
                             tents = b.TENTAISAN,
                             nguoikiem = a.NHANVIEN,
                             tinhtrang = c.TINHTRANG1,
                             ngaykiem = a.NGAYKIEMKE
                         }
                ).ToList();
            grvKiemke.DataSource = query;
            grvKiemke.Columns[0].HeaderText = "MÃ TÀI SẢN";
            grvKiemke.Columns[1].HeaderText = "TÊN TÀI SẢN";
            grvKiemke.Columns[2].HeaderText = "NGƯỜI KIỂM";
            grvKiemke.Columns[3].HeaderText = "TÌNH TRẠNG";
            grvKiemke.Columns[4].HeaderText = "NGÀY KIỂM";

        }
        private void loadDsthanhly()
        {
            qltaisan data = new qltaisan();
            var query = (from a in data.THANHLies
                         from b in data.TAISANs
                         where a.MATAISAN == b.MATAISAN
                         select new
                         {
                             matl = a.MATHANHLY,
                             tents = b.TENTAISAN,
                             soluong = a.SOLUONG,
                             giatrithanhly = a.GIATRITHANHLY
                         }
                ).ToList();
            grvThanhly.DataSource = query;
            grvThanhly.Columns[0].HeaderText = "MÃ THANH LÝ";
            grvThanhly.Columns[1].HeaderText = "TÊN TÀI SẢN";
            grvThanhly.Columns[2].HeaderText = "SỐ LƯỢNG";
            grvThanhly.Columns[3].HeaderText = "THANH LÝ";
        }

        private void trangThongke_Load(object sender, EventArgs e)
        {
            loadDskiemke();
            loadDstaisan();
            loadDsthanhly();
        }

        private void grvTaisan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvThanhly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIntaisan_Click(object sender, EventArgs e)
        {
            _reportTaisan = new reportTaisan();
            _reportTaisan.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnInkiemke_Click(object sender, EventArgs e)
        {
            _reportKiemke = new reportKiemke();
            _reportKiemke.Show();
        }

        private void btnInthanhly_Click(object sender, EventArgs e)
        {
            _reportThanhly = new reportThanhly();
            _reportThanhly.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
