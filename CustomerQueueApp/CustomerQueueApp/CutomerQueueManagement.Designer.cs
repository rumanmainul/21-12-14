namespace CustomerQueueApp
{
    partial class CutomerQueueManagement
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
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerQueListBox = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dequeueComplaignTextBox = new System.Windows.Forms.TextBox();
            this.dequeueCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addComplaignTextBox = new System.Windows.Forms.TextBox();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer Name";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complaign";
            this.columnHeader3.Width = 100;
            // 
            // customerQueListBox
            // 
            this.customerQueListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.customerQueListBox.GridLines = true;
            this.customerQueListBox.Location = new System.Drawing.Point(31, 303);
            this.customerQueListBox.Name = "customerQueListBox";
            this.customerQueListBox.Size = new System.Drawing.Size(822, 212);
            this.customerQueListBox.TabIndex = 4;
            this.customerQueListBox.UseCompatibleStateImageBehavior = false;
            this.customerQueListBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 127;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Dequeue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DequeueButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Enqueue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EnqueueButton_Click);
            // 
            // dequeueComplaignTextBox
            // 
            this.dequeueComplaignTextBox.Location = new System.Drawing.Point(602, 127);
            this.dequeueComplaignTextBox.Name = "dequeueComplaignTextBox";
            this.dequeueComplaignTextBox.Size = new System.Drawing.Size(203, 20);
            this.dequeueComplaignTextBox.TabIndex = 10;
            // 
            // dequeueCustomerNameTextBox
            // 
            this.dequeueCustomerNameTextBox.Location = new System.Drawing.Point(602, 92);
            this.dequeueCustomerNameTextBox.Name = "dequeueCustomerNameTextBox";
            this.dequeueCustomerNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.dequeueCustomerNameTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Complaign";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customer Name";
            // 
            // addComplaignTextBox
            // 
            this.addComplaignTextBox.Location = new System.Drawing.Point(151, 100);
            this.addComplaignTextBox.Name = "addComplaignTextBox";
            this.addComplaignTextBox.Size = new System.Drawing.Size(203, 20);
            this.addComplaignTextBox.TabIndex = 12;
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(602, 56);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(144, 20);
            this.serialTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Complaign";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serial No";
            // 
            // addCustomerNameTextBox
            // 
            this.addCustomerNameTextBox.Location = new System.Drawing.Point(151, 64);
            this.addCustomerNameTextBox.Name = "addCustomerNameTextBox";
            this.addCustomerNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.addCustomerNameTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(484, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 179);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue Customer";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(54, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 174);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer";
            // 
            // CutomerQueueManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 551);
            this.Controls.Add(this.customerQueListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dequeueComplaignTextBox);
            this.Controls.Add(this.dequeueCustomerNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addComplaignTextBox);
            this.Controls.Add(this.serialTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addCustomerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CutomerQueueManagement";
            this.Text = "CutomerQueueManagement";
            this.Load += new System.EventHandler(this.CutomerQueueManagement_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView customerQueListBox;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dequeueComplaignTextBox;
        private System.Windows.Forms.TextBox dequeueCustomerNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addComplaignTextBox;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addCustomerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

