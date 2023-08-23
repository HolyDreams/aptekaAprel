namespace aptekaAprel
{
    partial class CustomDataGridView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.VirtualMode = true;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.MultiSelect = false;
            this.ReadOnly = true;

            this.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomDataGridView_CellClick);
            this.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.CustomDataGridView_ColumnDisplayIndexChanged);
            this.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomDataGridView_ColumnHeaderMouseClick);
            this.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.CustomDataGridView_ColumnWidthChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomDataGridView_KeyPress);
        }

        #endregion
    }
}
