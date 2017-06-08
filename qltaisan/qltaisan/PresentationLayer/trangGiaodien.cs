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
    public partial class trangGiaodien : Form
    {
        trangTaisan _trangTaisan;
        trangKiemke _trangKiemke;
        trangThanhly _trangThanhly;
        trangNhaptaisan _trangNhaptaisan;
        trangThongke _trangThongke;
       
        public trangGiaodien()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult relt = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (relt == DialogResult.Yes)
                Application.Exit();
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate()
            {
                lbTimer.Text = DateTime.Now.ToString("T");
            }));
        }
        private void trangGiaodien_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void btnTaisan_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            _trangTaisan = new trangTaisan();
            _trangTaisan.MdiParent = this;
            panelContent.Controls.Add(_trangTaisan);
            _trangTaisan.Show();
        }

       
        private void btnLuanchuyen_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            _trangKiemke = new trangKiemke();
            _trangKiemke.MdiParent = this;
            panelContent.Controls.Add(_trangKiemke);
            _trangKiemke.Show();
        }

        private void btnTaisan_MouseUp(object sender, MouseEventArgs e)
        {
            btnTaisan.BackColor = SystemColors.ActiveCaption;
        }

        private void btnTaisan_MouseDown(object sender, MouseEventArgs e)
        {
            btnTaisan.BackColor = SystemColors.Highlight;
        }

        private void btnLuanchuyen_MouseUp(object sender, MouseEventArgs e)
        {
            btnLuanchuyen.BackColor = SystemColors.ActiveCaption;
        }

        private void btnLuanchuyen_MouseDown(object sender, MouseEventArgs e)
        {
            btnLuanchuyen.BackColor = SystemColors.Highlight;
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThumua_MouseUp(object sender, MouseEventArgs e)
        {
            btnThumua.BackColor = SystemColors.ActiveCaption;
        }

        private void btnThumua_MouseDown(object sender, MouseEventArgs e)
        {
            btnThumua.BackColor = SystemColors.Highlight;
        }

        private void btnThumua_Click(object sender, EventArgs e)
        {
             panelContent.Controls.Clear();
             _trangThanhly = new trangThanhly();
             _trangThanhly.MdiParent = this;
             panelContent.Controls.Add(_trangThanhly);
            _trangThanhly.Show();
        }

        private void btnThongketaisan_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            _trangNhaptaisan = new trangNhaptaisan();
            _trangNhaptaisan.MdiParent = this;
            panelContent.Controls.Add(_trangNhaptaisan);
            _trangNhaptaisan.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            _trangThongke = new trangThongke();
            _trangThongke.MdiParent = this;
            panelContent.Controls.Add(_trangThongke);
            _trangThongke.Show();
        }
    }
}
