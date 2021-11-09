
namespace calculatorDereza
{
    partial class Form2
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
            this.textNumerator1 = new System.Windows.Forms.TextBox();
            this.textDenominator1 = new System.Windows.Forms.TextBox();
            this.textNumerator2 = new System.Windows.Forms.TextBox();
            this.textDenominator2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textAns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textNumerator1
            // 
            this.textNumerator1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNumerator1.Location = new System.Drawing.Point(47, 42);
            this.textNumerator1.Name = "textNumerator1";
            this.textNumerator1.Size = new System.Drawing.Size(45, 29);
            this.textNumerator1.TabIndex = 0;
            this.textNumerator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDenominator1
            // 
            this.textDenominator1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDenominator1.Location = new System.Drawing.Point(47, 72);
            this.textDenominator1.Name = "textDenominator1";
            this.textDenominator1.Size = new System.Drawing.Size(45, 29);
            this.textDenominator1.TabIndex = 1;
            this.textDenominator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNumerator2
            // 
            this.textNumerator2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNumerator2.Location = new System.Drawing.Point(157, 42);
            this.textNumerator2.Name = "textNumerator2";
            this.textNumerator2.Size = new System.Drawing.Size(45, 29);
            this.textNumerator2.TabIndex = 2;
            this.textNumerator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDenominator2
            // 
            this.textDenominator2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDenominator2.Location = new System.Drawing.Point(157, 72);
            this.textDenominator2.Name = "textDenominator2";
            this.textDenominator2.Size = new System.Drawing.Size(45, 29);
            this.textDenominator2.TabIndex = 3;
            this.textDenominator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(214, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textAns
            // 
            this.textAns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAns.Location = new System.Drawing.Point(270, 42);
            this.textAns.Name = "textAns";
            this.textAns.ReadOnly = true;
            this.textAns.Size = new System.Drawing.Size(66, 29);
            this.textAns.TabIndex = 6;
            this.textAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вводите только правильные дроби, иначе будет \"Ошибка\"";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(109, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(270, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(66, 29);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 114);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAns);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDenominator2);
            this.Controls.Add(this.textNumerator2);
            this.Controls.Add(this.textDenominator1);
            this.Controls.Add(this.textNumerator1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumerator1;
        private System.Windows.Forms.TextBox textDenominator1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textDenominator2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textAns;
        private System.Windows.Forms.TextBox textNumerator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}