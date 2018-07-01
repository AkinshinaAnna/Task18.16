namespace _17._1
{
    partial class Interpreter_form
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
            this.Result_button = new System.Windows.Forms.Button();
            this.Expression_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Result_button
            // 
            this.Result_button.Location = new System.Drawing.Point(111, 119);
            this.Result_button.Name = "Result_button";
            this.Result_button.Size = new System.Drawing.Size(75, 23);
            this.Result_button.TabIndex = 0;
            this.Result_button.Text = "Вычислить";
            this.Result_button.UseVisualStyleBackColor = true;
            this.Result_button.Click += new System.EventHandler(this.Result_button_Click);
            // 
            // Expression_textBox
            // 
            this.Expression_textBox.Location = new System.Drawing.Point(12, 65);
            this.Expression_textBox.Name = "Expression_textBox";
            this.Expression_textBox.Size = new System.Drawing.Size(260, 20);
            this.Expression_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите выражение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат:";
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Location = new System.Drawing.Point(151, 176);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(0, 13);
            this.Result_label.TabIndex = 4;
            // 
            // Interpreter_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Result_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Expression_textBox);
            this.Controls.Add(this.Result_button);
            this.Name = "Interpreter_form";
            this.Text = "Interpreter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Result_button;
        private System.Windows.Forms.TextBox Expression_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Result_label;
    }
}

