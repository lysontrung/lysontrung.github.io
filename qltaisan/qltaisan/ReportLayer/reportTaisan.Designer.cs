namespace qltaisan
{
    partial class reportTaisan
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
            this.vrpTaisan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // vrpTaisan
            // 
            this.vrpTaisan.ActiveViewIndex = -1;
            this.vrpTaisan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vrpTaisan.Cursor = System.Windows.Forms.Cursors.Default;
            this.vrpTaisan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vrpTaisan.Location = new System.Drawing.Point(0, 0);
            this.vrpTaisan.Name = "vrpTaisan";
            this.vrpTaisan.Size = new System.Drawing.Size(867, 382);
            this.vrpTaisan.TabIndex = 0;
            this.vrpTaisan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.vrpTaisan.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // reportTaisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 382);
            this.Controls.Add(this.vrpTaisan);
            this.Name = "reportTaisan";
            this.Text = "reportTaisan";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer vrpTaisan;
    }
}