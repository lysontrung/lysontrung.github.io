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
    public partial class trangThanhly : Form
    {
        qltaisan data = new qltaisan();
        public trangThanhly()
        {
            InitializeComponent();
        }
        private void loadDs()
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
            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].HeaderText = "MÃ THANH LÝ";
            dataGridView1.Columns[1].HeaderText = "TÊN TÀI SẢN";
            dataGridView1.Columns[2].HeaderText = "SỐ LƯỢNG";
            dataGridView1.Columns[3].HeaderText = "THANH LÝ(TRIỆU)";
            if (dataGridView1.RowCount > 0)
            {
                lbMatl.DataBindings.Clear();
                lbMatl.DataBindings.Add("text", dataGridView1.DataSource, "matl");
                cbTaisan.DataBindings.Clear();
                cbTaisan.DataBindings.Add("text", dataGridView1.DataSource, "tents");
                soluong.DataBindings.Clear();
                soluong.DataBindings.Add("text", dataGridView1.DataSource, "soluong");
                thanhly.DataBindings.Clear();
                thanhly.DataBindings.Add("text", dataGridView1.DataSource, "giatrithanhly");
            }
        }
        private void loadDstaisan()
        {
            qltaisan data = new qltaisan();
            cbTaisan.DataSource = data.TAISANs.Select(ts => new
            {
                ten = ts.TENTAISAN,
                id = ts.MATAISAN,
            }).ToList();
            cbTaisan.DisplayMember = "ten";
            cbTaisan.ValueMember = "id";
            if (cbTaisan.Items.Count > 0)
                cbTaisan.SelectedIndex = 0;
        }
        private void trangThanhly_Load(object sender, EventArgs e)
        {
            loadDs();
            loadDstaisan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn có muốn thêm?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                data = new qltaisan();
                THANHLY tl = new THANHLY();
                tl.MATAISAN = Int32.Parse(cbTaisan.SelectedValue.ToString());
                tl.SOLUONG = soluong.Value.ToString();
                tl.GIATRITHANHLY = thanhly.Value.ToString();
                try
                {
                    data.THANHLies.Add(tl);
                    data.SaveChanges();
                    loadDs();
                    MessageBox.Show(this, "Thêm thành công !!!");
                }
                catch
                {
                    MessageBox.Show(this, "Thêm thất bại !!!");
                }
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            data = new qltaisan();
            if (MessageBox.Show(this, "bạn có muốn sửa" + lbMatl.Text + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int matl = Int32.Parse(lbMatl.Text);
                    THANHLY tl = data.THANHLies.Single(_tl => _tl.MATHANHLY.Equals(matl));
                    tl.MATAISAN = Int32.Parse(cbTaisan.SelectedValue.ToString());
                    tl.SOLUONG = soluong.Value.ToString();
                    tl.GIATRITHANHLY = thanhly.Value.ToString();
                    data.SaveChanges();
                    loadDs();
                    MessageBox.Show(this, "Cập nhật thành công !!!");
                }
                catch
                {
                    MessageBox.Show(this, "Cập nhật thất bại !!!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            data = new qltaisan();
            if (MessageBox.Show(this, "bạn có muốn xóa" + lbMatl.Text + " này không ?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int matl = Int32.Parse(lbMatl.Text);
                    THANHLY tl = data.THANHLies.Single(_tl => _tl.MATHANHLY.Equals(matl));
                    data.THANHLies.Remove(tl);
                    data.SaveChanges();
                    loadDs();
                    MessageBox.Show(this, "Xóa thành công");
                }
                catch
                {
                    MessageBox.Show(this, "Xóa thất bại");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDs();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            qltaisan data = new qltaisan();
            var query = (from a in data.THANHLies
                         from b in data.TAISANs
                         where a.MATAISAN == b.MATAISAN
                         && b.TENTAISAN ==  txtTimkiem.Text.Trim()
                         select new
                         {
                             matl = a.MATHANHLY,
                             tents = b.TENTAISAN,
                             soluong = a.SOLUONG,
                             giatrithanhly = a.GIATRITHANHLY
                         }
                ).ToList();
            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].HeaderText = "MÃ THANH LÝ";
            dataGridView1.Columns[1].HeaderText = "TÊN TÀI SẢN";
            dataGridView1.Columns[2].HeaderText = "SỐ LƯỢNG";
            dataGridView1.Columns[3].HeaderText = "THANH LÝ(TRIỆU)";
            if (dataGridView1.RowCount > 0)
            {
                lbMatl.DataBindings.Clear();
                lbMatl.DataBindings.Add("text", dataGridView1.DataSource, "matl");
                cbTaisan.DataBindings.Clear();
                cbTaisan.DataBindings.Add("text", dataGridView1.DataSource, "tents");
                soluong.DataBindings.Clear();
                soluong.DataBindings.Add("text", dataGridView1.DataSource, "soluong");
                thanhly.DataBindings.Clear();
                thanhly.DataBindings.Add("text", dataGridView1.DataSource, "giatrithanhly");
            }
        }
    }
}
