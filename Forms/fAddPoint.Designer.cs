namespace aptekaAprel
{
    partial class fAddPoint
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
            this.labelX = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.TextBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(13, 13);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(118, 18);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "Координата X";
            // 
            // textX
            // 
            this.textX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textX.Location = new System.Drawing.Point(16, 45);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(240, 24);
            this.textX.TabIndex = 1;
            this.textX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textX_KeyPress);
            // 
            // textY
            // 
            this.textY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textY.Location = new System.Drawing.Point(262, 45);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(240, 24);
            this.textY.TabIndex = 3;
            this.textY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textX_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(259, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Координата Y";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textName.Location = new System.Drawing.Point(16, 115);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(486, 24);
            this.textName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // textDesc
            // 
            this.textDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textDesc.Location = new System.Drawing.Point(16, 184);
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(486, 24);
            this.textDesc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Примечание";
            // 
            // butAccept
            // 
            this.butAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.butAccept.Location = new System.Drawing.Point(190, 248);
            this.butAccept.Name = "butAccept";
            this.butAccept.Size = new System.Drawing.Size(134, 33);
            this.butAccept.TabIndex = 8;
            this.butAccept.Text = "Добавить";
            this.butAccept.UseVisualStyleBackColor = true;
            this.butAccept.Click += new System.EventHandler(this.butAccept_Click);
            // 
            // fAddPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 296);
            this.Controls.Add(this.butAccept);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.labelX);
            this.Name = "fAddPoint";
            this.Text = "fAddPoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butAccept;
    }
}