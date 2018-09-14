namespace Sort
{
    partial class SortForm
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(12, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(87, 35);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "начать";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Enabled = false;
            this.PrevBtn.Location = new System.Drawing.Point(12, 381);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(118, 46);
            this.PrevBtn.TabIndex = 1;
            this.PrevBtn.Text = "предыдущий";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Enabled = false;
            this.NextBtn.Location = new System.Drawing.Point(1106, 381);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(118, 46);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "следующий";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Type
            // 
            this.Type.DisplayMember = "0";
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "3*K+1",
            "2*K+1",
            "Фибоначи"});
            this.Type.Location = new System.Drawing.Point(105, 18);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 24);
            this.Type.TabIndex = 4;
            this.Type.Tag = "";
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 439);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "SortForm";
            this.Text = "SortForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SortForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.ComboBox Type;
    }
}

