namespace qltaisan
{
    partial class reportKiemke
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
            this.vcrKiemke = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // vcrKiemke
            // 
            this.vcrKiemke.ActiveViewIndex = -1;
            this.vcrKiemke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vcrKiemke.Cursor = System.Windows.Forms.Cursors.Default;
            this.vcrKiemke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vcrKiemke.Location = new System.Drawing.Point(0, 0);
            this.vcrKiemke.Name = "vcrKiemke";
            this.vcrKiemke.Size = new System.Drawing.Size(769, 433);
            this.vcrKiemke.TabIndex = 0;
            this.vcrKiemke.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.vcrKiemke.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // reportKiemke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 433);
            this.Controls.Add(this.vcrKiemke);
            this.Name = "reportKiemke";
            this.Text = "reportKiemke";
            this.Load += new System.EventHandler(this.reportKiemke_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer vcrKiemke;

    }
}