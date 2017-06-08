namespace qltaisan
{
    partial class trangThongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trangThongke));
            this.grvTaisan = new System.Windows.Forms.DataGridView();
            this.grvKiemke = new System.Windows.Forms.DataGridView();
            this.grvThanhly = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIntaisan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInkiemke = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInthanhly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvTaisan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKiemke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThanhly)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvTaisan
            // 
            this.grvTaisan.AllowUserToOrderColumns = true;
            this.grvTaisan.AllowUserToResizeRows = false;
            this.grvTaisan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvTaisan.BackgroundColor = System.Drawing.Color.White;
            this.grvTaisan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvTaisan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvTaisan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.grvTaisan, "grvTaisan");
            this.grvTaisan.Name = "grvTaisan";
            this.grvTaisan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTaisan_CellContentClick);
            // 
            // grvKiemke
            // 
            this.grvKiemke.AllowUserToOrderColumns = true;
            this.grvKiemke.AllowUserToResizeRows = false;
            this.grvKiemke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvKiemke.BackgroundColor = System.Drawing.Color.White;
            this.grvKiemke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvKiemke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvKiemke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.grvKiemke, "grvKiemke");
            this.grvKiemke.Name = "grvKiemke";
            // 
            // grvThanhly
            // 
            this.grvThanhly.AllowUserToOrderColumns = true;
            this.grvThanhly.AllowUserToResizeRows = false;
            this.grvThanhly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvThanhly.BackgroundColor = System.Drawing.Color.White;
            this.grvThanhly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvThanhly.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvThanhly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.grvThanhly, "grvThanhly");
            this.grvThanhly.Name = "grvThanhly";
            this.grvThanhly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvThanhly_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIntaisan);
            this.groupBox1.Controls.Add(this.grvTaisan);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnIntaisan
            // 
            this.btnIntaisan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnIntaisan, "btnIntaisan");
            this.btnIntaisan.ForeColor = System.Drawing.Color.White;
            this.btnIntaisan.Name = "btnIntaisan";
            this.btnIntaisan.UseVisualStyleBackColor = false;
            this.btnIntaisan.Click += new System.EventHandler(this.btnIntaisan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInthanhly);
            this.groupBox2.Controls.Add(this.grvThanhly);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnInkiemke
            // 
            this.btnInkiemke.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnInkiemke, "btnInkiemke");
            this.btnInkiemke.ForeColor = System.Drawing.Color.White;
            this.btnInkiemke.Name = "btnInkiemke";
            this.btnInkiemke.UseVisualStyleBackColor = false;
            this.btnInkiemke.Click += new System.EventHandler(this.btnInkiemke_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grvKiemke);
            this.groupBox3.Controls.Add(this.btnInkiemke);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnInthanhly
            // 
            this.btnInthanhly.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnInthanhly, "btnInthanhly");
            this.btnInthanhly.ForeColor = System.Drawing.Color.White;
            this.btnInthanhly.Name = "btnInthanhly";
            this.btnInthanhly.UseVisualStyleBackColor = false;
            this.btnInthanhly.Click += new System.EventHandler(this.btnInthanhly_Click);
            // 
            // trangThongke
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "trangThongke";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.trangThongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTaisan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKiemke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThanhly)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvTaisan;
        private System.Windows.Forms.DataGridView grvKiemke;
        private System.Windows.Forms.DataGridView grvThanhly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIntaisan;
        private System.Windows.Forms.Button btnInkiemke;
        private System.Windows.Forms.Button btnInthanhly;
    }
}