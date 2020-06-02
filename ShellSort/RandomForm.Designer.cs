namespace ShellSort
{
    partial class RandomForm
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
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.lbCount = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(12, 36);
            this.nudMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMin.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(243, 20);
            this.nudMin.TabIndex = 0;
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(9, 20);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(55, 13);
            this.lbMin.TabIndex = 1;
            this.lbMin.Text = "Минимум";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(9, 62);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(61, 13);
            this.lbMax.TabIndex = 3;
            this.lbMax.Text = "Максимум";
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(12, 78);
            this.nudMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(243, 20);
            this.nudMax.TabIndex = 2;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(9, 101);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(66, 13);
            this.lbCount.TabIndex = 5;
            this.lbCount.Text = "Количество";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(12, 118);
            this.nudCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(243, 20);
            this.nudCount.TabIndex = 4;
            this.nudCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(12, 144);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(112, 44);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "ОК";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(142, 144);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(113, 44);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // RandomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 207);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.nudMin);
            this.Name = "RandomForm";
            this.Text = "Рандом";
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}