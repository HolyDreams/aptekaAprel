namespace aptekaAprel
{
    partial class FilterTable
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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.butAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textSearch.Location = new System.Drawing.Point(12, 48);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(427, 27);
            this.textSearch.TabIndex = 0;
            // 
            // butAccept
            // 
            this.butAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.butAccept.Location = new System.Drawing.Point(228, 86);
            this.butAccept.Name = "butAccept";
            this.butAccept.Size = new System.Drawing.Size(111, 31);
            this.butAccept.TabIndex = 1;
            this.butAccept.Text = "Применить";
            this.butAccept.UseVisualStyleBackColor = true;
            this.butAccept.Click += new System.EventHandler(this.butAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите данные";
            // 
            // butCancel
            // 
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.butCancel.Location = new System.Drawing.Point(345, 86);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(94, 31);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // FilterTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 121);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butAccept);
            this.Controls.Add(this.textSearch);
            this.Name = "FilterTable";
            this.Text = "Фильтрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCancel;
    }
}