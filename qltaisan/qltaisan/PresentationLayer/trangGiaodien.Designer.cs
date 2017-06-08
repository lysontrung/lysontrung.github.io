namespace qltaisan
{
    partial class trangGiaodien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trangGiaodien));
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThongketaisan = new System.Windows.Forms.Button();
            this.btnThumua = new System.Windows.Forms.Button();
            this.btnLuanchuyen = new System.Windows.Forms.Button();
            this.btnTaisan = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.PowderBlue;
            this.panelTop.Controls.Add(this.logo);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.lbTimer);
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.Name = "panelTop";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lbTimer
            // 
            resources.ApplyResources(this.lbTimer, "lbTimer");
            this.lbTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTimer.ForeColor = System.Drawing.Color.Blue;
            this.lbTimer.Name = "lbTimer";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.PowderBlue;
            this.panelLeft.Controls.Add(this.btnLuanchuyen);
            this.panelLeft.Controls.Add(this.button1);
            this.panelLeft.Controls.Add(this.btnThongketaisan);
            this.panelLeft.Controls.Add(this.btnThumua);
            this.panelLeft.Controls.Add(this.btnTaisan);
            resources.ApplyResources(this.panelLeft, "panelLeft");
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThongketaisan
            // 
            this.btnThongketaisan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnThongketaisan, "btnThongketaisan");
            this.btnThongketaisan.ForeColor = System.Drawing.Color.Blue;
            this.btnThongketaisan.Name = "btnThongketaisan";
            this.btnThongketaisan.UseVisualStyleBackColor = false;
            this.btnThongketaisan.Click += new System.EventHandler(this.btnThongketaisan_Click);
            // 
            // btnThumua
            // 
            this.btnThumua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnThumua, "btnThumua");
            this.btnThumua.ForeColor = System.Drawing.Color.Blue;
            this.btnThumua.Name = "btnThumua";
            this.btnThumua.UseVisualStyleBackColor = false;
            this.btnThumua.Click += new System.EventHandler(this.btnThumua_Click);
            this.btnThumua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnThumua_MouseDown);
            this.btnThumua.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnThumua_MouseUp);
            // 
            // btnLuanchuyen
            // 
            this.btnLuanchuyen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuanchuyen.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnLuanchuyen, "btnLuanchuyen");
            this.btnLuanchuyen.ForeColor = System.Drawing.Color.Blue;
            this.btnLuanchuyen.Name = "btnLuanchuyen";
            this.btnLuanchuyen.UseVisualStyleBackColor = false;
            this.btnLuanchuyen.Click += new System.EventHandler(this.btnLuanchuyen_Click);
            this.btnLuanchuyen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLuanchuyen_MouseDown);
            this.btnLuanchuyen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLuanchuyen_MouseUp);
            // 
            // btnTaisan
            // 
            this.btnTaisan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaisan.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnTaisan, "btnTaisan");
            this.btnTaisan.ForeColor = System.Drawing.Color.Blue;
            this.btnTaisan.Name = "btnTaisan";
            this.btnTaisan.UseVisualStyleBackColor = false;
            this.btnTaisan.Click += new System.EventHandler(this.btnTaisan_Click);
            this.btnTaisan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTaisan_MouseDown);
            this.btnTaisan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTaisan_MouseUp);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.PowderBlue;
            resources.ApplyResources(this.panelContent, "panelContent");
            this.panelContent.Name = "panelContent";
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.UseVisualStyleBackColor = true;
            // 
            // trangGiaodien
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "trangGiaodien";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.trangGiaodien_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnTaisan;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnLuanchuyen;
        private System.Windows.Forms.Button btnThumua;
        private System.Windows.Forms.Button btnThongketaisan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logo;
    }
}

