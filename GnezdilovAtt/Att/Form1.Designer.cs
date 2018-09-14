namespace Att
{
    partial class Att
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CreateList = new System.Windows.Forms.Button();
            this.ColElements = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteLastNegElement = new System.Windows.Forms.Button();
            this.ReadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 250);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 68);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 250);
            this.textBox2.TabIndex = 1;
            // 
            // CreateList
            // 
            this.CreateList.Location = new System.Drawing.Point(123, 68);
            this.CreateList.Name = "CreateList";
            this.CreateList.Size = new System.Drawing.Size(250, 23);
            this.CreateList.TabIndex = 2;
            this.CreateList.Text = "Создать список";
            this.CreateList.UseVisualStyleBackColor = true;
            this.CreateList.Click += new System.EventHandler(this.CreateList_Click);
            // 
            // ColElements
            // 
            this.ColElements.Location = new System.Drawing.Point(123, 97);
            this.ColElements.Name = "ColElements";
            this.ColElements.Size = new System.Drawing.Size(250, 45);
            this.ColElements.TabIndex = 3;
            this.ColElements.Text = "Колличество отрицательных элементов, для каждого числа";
            this.ColElements.UseVisualStyleBackColor = true;
            this.ColElements.Click += new System.EventHandler(this.ColElements_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Заполнить очередь случайными числами";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 68);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(30, 250);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "asd";
            // 
            // DeleteLastNegElement
            // 
            this.DeleteLastNegElement.Location = new System.Drawing.Point(123, 205);
            this.DeleteLastNegElement.Name = "DeleteLastNegElement";
            this.DeleteLastNegElement.Size = new System.Drawing.Size(250, 42);
            this.DeleteLastNegElement.TabIndex = 7;
            this.DeleteLastNegElement.Text = "Удалить последний отрицательный элемент очереди";
            this.DeleteLastNegElement.UseVisualStyleBackColor = true;
            this.DeleteLastNegElement.Click += new System.EventHandler(this.DeleteLastNegElement_Click);
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(123, 253);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(250, 34);
            this.ReadFile.TabIndex = 8;
            this.ReadFile.Text = "Чтение из файла";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Att
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 382);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.DeleteLastNegElement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ColElements);
            this.Controls.Add(this.CreateList);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Att";
            this.Text = "Att";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CreateList;
        private System.Windows.Forms.Button ColElements;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteLastNegElement;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

