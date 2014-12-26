namespace CalculatorApp
{
    partial class Form1
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
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Substract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Devide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(102, 40);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(174, 20);
            this.firstNumberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Number:";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(22, 174);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(102, 72);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(174, 20);
            this.secondNumberTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(102, 100);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(174, 20);
            this.resultTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Result:";
            // 
            // Substract
            // 
            this.Substract.Location = new System.Drawing.Point(102, 174);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(75, 23);
            this.Substract.TabIndex = 2;
            this.Substract.Text = "Substract";
            this.Substract.UseVisualStyleBackColor = true;
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(183, 174);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 2;
            this.Multiply.Text = "Multiply";
            this.Multiply.UseVisualStyleBackColor = true;
            // 
            // Devide
            // 
            this.Devide.Location = new System.Drawing.Point(264, 174);
            this.Devide.Name = "Devide";
            this.Devide.Size = new System.Drawing.Size(75, 23);
            this.Devide.TabIndex = 2;
            this.Devide.Text = "Devide";
            this.Devide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 288);
            this.Controls.Add(this.Devide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Substract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Devide;
    }
}

