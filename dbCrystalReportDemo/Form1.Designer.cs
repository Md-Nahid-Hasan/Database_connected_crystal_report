namespace dbCrystalReportDemo
{
    partial class Form1
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
            this.crvViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvViewer
            // 
            this.crvViewer.ActiveViewIndex = -1;
            this.crvViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvViewer.Location = new System.Drawing.Point(0, 0);
            this.crvViewer.Name = "crvViewer";
            this.crvViewer.Size = new System.Drawing.Size(858, 432);
            this.crvViewer.TabIndex = 0;
            this.crvViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvViewer.Load += new System.EventHandler(this.crvViewer_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 432);
            this.Controls.Add(this.crvViewer);
            this.Name = "Form1";
            this.Text = "crystalReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvViewer;
    }
}

