namespace _18._16
{
    partial class Tree_Form
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
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printButton = new System.Windows.Forms.Button();
            this.printTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(-3, 29);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(102, 13);
            this.depthLabel.TabIndex = 0;
            this.depthLabel.Text = "Введите глубину N";
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(0, 45);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(41, 20);
            this.depthTextBox.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(0, 102);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(99, 37);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(134, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 303);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(0, 170);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(99, 39);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "Распечатать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printTextBox
            // 
            this.printTextBox.Location = new System.Drawing.Point(12, 312);
            this.printTextBox.Multiline = true;
            this.printTextBox.Name = "printTextBox";
            this.printTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.printTextBox.Size = new System.Drawing.Size(790, 260);
            this.printTextBox.TabIndex = 8;
            this.printTextBox.TextChanged += new System.EventHandler(this.printTextBox_TextChanged);
            // 
            // Tree_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 584);
            this.Controls.Add(this.printTextBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.depthLabel);
            this.Name = "Tree_Form";
            this.Text = "Tree";
            this.Load += new System.EventHandler(this.Tree_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox printTextBox;
    }
}

