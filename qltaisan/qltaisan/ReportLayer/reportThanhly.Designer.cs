namespace qltaisan
{
    partial class reportThanhly
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
            this.vcrThanhly = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // vcrThanhly
            // 
            this.vcrThanhly.ActiveViewIndex = -1;
            this.vcrThanhly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vcrThanhly.Cursor = System.Windows.Forms.Cursors.Default;
            this.vcrThanhly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vcrThanhly.Location = new System.Drawing.Point(0, 0);
            this.vcrThanhly.Name = "vcrThanhly";
            this.vcrThanhly.Size = new System.Drawing.Size(710, 486);
            this.vcrThanhly.TabIndex = 0;
            this.vcrThanhly.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.vcrThanhly.Load += new System.EventHandler(this.vcrThanhly_Load);
            // 
            // reportThanhly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 486);
            this.Controls.Add(this.vcrThanhly);
            this.Name = "reportThanhly";
            this.Text = "reportThanhly";
            this.Load += new System.EventHandler(this.reportThanhly_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer vcrThanhly;
    }
}