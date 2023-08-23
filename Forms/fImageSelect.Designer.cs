namespace aptekaAprel
{
    partial class fImageSelect
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
            this.butSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butLeft90 = new System.Windows.Forms.Button();
            this.butRight90 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butSelect
            // 
            this.butSelect.Location = new System.Drawing.Point(13, 13);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(75, 23);
            this.butSelect.TabIndex = 0;
            this.butSelect.Text = "Выбрать ";
            this.butSelect.UseVisualStyleBackColor = true;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(1, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1249, 619);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // butLeft90
            // 
            this.butLeft90.Enabled = false;
            this.butLeft90.Location = new System.Drawing.Point(246, 12);
            this.butLeft90.Name = "butLeft90";
            this.butLeft90.Size = new System.Drawing.Size(161, 23);
            this.butLeft90.TabIndex = 2;
            this.butLeft90.Text = "Повернуть на лево на 90";
            this.butLeft90.UseVisualStyleBackColor = true;
            this.butLeft90.Click += new System.EventHandler(this.butLeft90_Click);
            // 
            // butRight90
            // 
            this.butRight90.Enabled = false;
            this.butRight90.Location = new System.Drawing.Point(413, 13);
            this.butRight90.Name = "butRight90";
            this.butRight90.Size = new System.Drawing.Size(167, 23);
            this.butRight90.TabIndex = 3;
            this.butRight90.Text = "Повернуть на право на 90";
            this.butRight90.UseVisualStyleBackColor = true;
            this.butRight90.Click += new System.EventHandler(this.butRight90_Click);
            // 
            // ImageSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 672);
            this.Controls.Add(this.butRight90);
            this.Controls.Add(this.butLeft90);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butSelect);
            this.Name = "ImageSelect";
            this.Text = "ImageSelect";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butLeft90;
        private System.Windows.Forms.Button butRight90;
    }
}