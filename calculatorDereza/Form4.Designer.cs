
namespace calculatorDereza
{
    partial class Form4
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
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textDen1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textDen2 = new System.Windows.Forms.TextBox();
            this.textSign = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNum1
            // 
            this.textNum1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNum1.Location = new System.Drawing.Point(85, 39);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(45, 29);
            this.textNum1.TabIndex = 0;
            this.textNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDen1
            // 
            this.textDen1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDen1.Location = new System.Drawing.Point(85, 69);
            this.textDen1.Name = "textDen1";
            this.textDen1.Size = new System.Drawing.Size(45, 29);
            this.textDen1.TabIndex = 1;
            this.textDen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNum2
            // 
            this.textNum2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNum2.Location = new System.Drawing.Point(236, 39);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(45, 29);
            this.textNum2.TabIndex = 2;
            this.textNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDen2
            // 
            this.textDen2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDen2.Location = new System.Drawing.Point(236, 69);
            this.textDen2.Name = "textDen2";
            this.textDen2.Size = new System.Drawing.Size(45, 29);
            this.textDen2.TabIndex = 3;
            this.textDen2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSign
            // 
            this.textSign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSign.Location = new System.Drawing.Point(150, 53);
            this.textSign.Name = "textSign";
            this.textSign.ReadOnly = true;
            this.textSign.Size = new System.Drawing.Size(66, 29);
            this.textSign.TabIndex = 4;
            this.textSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вводите только правильные дроби, иначе будет \"Ошибка\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сравнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 155);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSign);
            this.Controls.Add(this.textDen2);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textDen1);
            this.Controls.Add(this.textNum1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сравнение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textDen1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textDen2;
        private System.Windows.Forms.TextBox textSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.Button button1;
    }
}