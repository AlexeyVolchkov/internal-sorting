namespace ShellSort
{
    partial class MainForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbArray = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.random = new System.Windows.Forms.ToolStripMenuItem();
            this.sort = new System.Windows.Forms.ToolStripMenuItem();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Method,
            this.count});
            this.dgv.Location = new System.Drawing.Point(338, 27);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(420, 251);
            this.dgv.TabIndex = 0;
            // 
            // tbArray
            // 
            this.tbArray.Location = new System.Drawing.Point(12, 27);
            this.tbArray.Multiline = true;
            this.tbArray.Name = "tbArray";
            this.tbArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbArray.Size = new System.Drawing.Size(311, 251);
            this.tbArray.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.random,
            this.sort});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(770, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // random
            // 
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(61, 20);
            this.random.Text = "Рандом";
            this.random.Click += new System.EventHandler(this.Random_Click);
            // 
            // sort
            // 
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(90, 20);
            this.sort.Text = "Сортировать";
            this.sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Method
            // 
            this.Method.HeaderText = "Метод";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "Кол-во перестановок";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 290);
            this.Controls.Add(this.tbArray);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Сортировка Шелла";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbArray;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem random;
        private System.Windows.Forms.ToolStripMenuItem sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
    }
}

