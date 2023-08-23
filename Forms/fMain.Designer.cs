using aptekaAprel;

namespace aptekaAprel
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.gridView = new aptekaAprel.CustomDataGridView();
            this.butImage = new System.Windows.Forms.Button();
            this.butDiscord = new System.Windows.Forms.Button();
            this.butMap = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowDrop = true;
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToOrderColumns = true;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoGenerateColumns = false;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.gridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridView.Location = new System.Drawing.Point(2, 45);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.Size = new System.Drawing.Size(796, 476);
            this.gridView.TabIndex = 0;
            this.gridView.VirtualMode = true;
            // 
            // butImage
            // 
            this.butImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.butImage.Location = new System.Drawing.Point(2, 5);
            this.butImage.Name = "butImage";
            this.butImage.Size = new System.Drawing.Size(119, 34);
            this.butImage.TabIndex = 1;
            this.butImage.Text = "Изображение";
            this.butImage.UseVisualStyleBackColor = true;
            this.butImage.Click += new System.EventHandler(this.butImage_Click);
            // 
            // butDiscord
            // 
            this.butDiscord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.butDiscord.Location = new System.Drawing.Point(252, 5);
            this.butDiscord.Name = "butDiscord";
            this.butDiscord.Size = new System.Drawing.Size(266, 34);
            this.butDiscord.TabIndex = 2;
            this.butDiscord.Text = "Отправить изоброжение в дискорд";
            this.butDiscord.UseVisualStyleBackColor = true;
            this.butDiscord.Click += new System.EventHandler(this.butDiscord_Click);
            // 
            // butMap
            // 
            this.butMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.butMap.Location = new System.Drawing.Point(127, 5);
            this.butMap.Name = "butMap";
            this.butMap.Size = new System.Drawing.Size(119, 34);
            this.butMap.TabIndex = 3;
            this.butMap.Text = "Яндекс карты";
            this.butMap.UseVisualStyleBackColor = true;
            this.butMap.Click += new System.EventHandler(this.butMap_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.butMap);
            this.Controls.Add(this.butDiscord);
            this.Controls.Add(this.butImage);
            this.Controls.Add(this.gridView);
            this.Name = "Form1";
            this.Text = "АптекаАпрель";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butImage;
        private System.Windows.Forms.Button butDiscord;
        private System.Windows.Forms.Button butMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private CustomDataGridView gridView;
    }
}

