
namespace calculatorDereza
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNumerator1 = new System.Windows.Forms.TextBox();
            this.textDenominator1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textAnsNumerator = new System.Windows.Forms.TextBox();
            this.textAnsDenominator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вводите только правильные дроби, иначе будет \"Ошибка\"";
            // 
            // textNumerator1
            // 
            this.textNumerator1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNumerator1.Location = new System.Drawing.Point(90, 39);
            this.textNumerator1.Name = "textNumerator1";
            this.textNumerator1.Size = new System.Drawing.Size(45, 29);
            this.textNumerator1.TabIndex = 1;
            this.textNumerator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDenominator1
            // 
            this.textDenominator1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDenominator1.Location = new System.Drawing.Point(90, 69);
            this.textDenominator1.Name = "textDenominator1";
            this.textDenominator1.Size = new System.Drawing.Size(45, 29);
            this.textDenominator1.TabIndex = 2;
            this.textDenominator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(155, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textAnsNumerator
            // 
            this.textAnsNumerator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAnsNumerator.Location = new System.Drawing.Point(215, 39);
            this.textAnsNumerator.Name = "textAnsNumerator";
            this.textAnsNumerator.ReadOnly = true;
            this.textAnsNumerator.Size = new System.Drawing.Size(66, 29);
            this.textAnsNumerator.TabIndex = 4;
            this.textAnsNumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textAnsDenominator
            // 
            this.textAnsDenominator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAnsDenominator.Location = new System.Drawing.Point(215, 69);
            this.textAnsDenominator.Name = "textAnsDenominator";
            this.textAnsDenominator.ReadOnly = true;
            this.textAnsDenominator.Size = new System.Drawing.Size(66, 29);
            this.textAnsDenominator.TabIndex = 5;
            this.textAnsDenominator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 115);
            this.Controls.Add(this.textAnsDenominator);
            this.Controls.Add(this.textAnsNumerator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDenominator1);
            this.Controls.Add(this.textNumerator1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сокращение дроби";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumerator1;
        private System.Windows.Forms.TextBox textDenominator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textAnsNumerator;
        private System.Windows.Forms.TextBox textAnsDenominator;
    }
}