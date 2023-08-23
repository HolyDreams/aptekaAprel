namespace aptekaAprel
{
    partial class fMaps
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
            this.butAddPoint = new System.Windows.Forms.Button();
            this.butAddCircle = new System.Windows.Forms.Button();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.SuspendLayout();
            // 
            // butAddPoint
            // 
            this.butAddPoint.Location = new System.Drawing.Point(13, 13);
            this.butAddPoint.Name = "butAddPoint";
            this.butAddPoint.Size = new System.Drawing.Size(123, 29);
            this.butAddPoint.TabIndex = 0;
            this.butAddPoint.Text = "Добавить точку";
            this.butAddPoint.UseVisualStyleBackColor = true;
            this.butAddPoint.Click += new System.EventHandler(this.butAddPoint_Click);
            // 
            // butAddCircle
            // 
            this.butAddCircle.Location = new System.Drawing.Point(142, 13);
            this.butAddCircle.Name = "butAddCircle";
            this.butAddCircle.Size = new System.Drawing.Size(123, 29);
            this.butAddCircle.TabIndex = 1;
            this.butAddCircle.Text = "Добавить круг";
            this.butAddCircle.UseVisualStyleBackColor = true;
            this.butAddCircle.Click += new System.EventHandler(this.butAddCircle_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(1, 48);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1413, 734);
            this.chromiumWebBrowser1.TabIndex = 2;
            // 
            // fMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 779);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.butAddCircle);
            this.Controls.Add(this.butAddPoint);
            this.Name = "fMaps";
            this.Text = "fMaps";
            this.Load += new System.EventHandler(this.fMaps_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAddPoint;
        private System.Windows.Forms.Button butAddCircle;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
    }
}