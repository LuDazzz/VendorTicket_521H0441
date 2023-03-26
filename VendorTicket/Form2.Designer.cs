namespace VendorTicket
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gbQR = new System.Windows.Forms.GroupBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.gbCre = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbQR.SuspendLayout();
            this.gbCre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(648, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Issue";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 42);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(362, 33);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(228, 27);
            this.txtPrice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(260, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose payment method";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(219, 136);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 32);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "QR";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(508, 136);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(137, 32);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "Credit card";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // gbQR
            // 
            this.gbQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbQR.Controls.Add(this.btnGet);
            this.gbQR.Controls.Add(this.label5);
            this.gbQR.Controls.Add(this.cbMethod);
            this.gbQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbQR.Location = new System.Drawing.Point(193, 174);
            this.gbQR.Name = "gbQR";
            this.gbQR.Size = new System.Drawing.Size(178, 211);
            this.gbQR.TabIndex = 13;
            this.gbQR.TabStop = false;
            this.gbQR.Text = "For QR";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(43, 163);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(94, 29);
            this.btnGet.TabIndex = 19;
            this.btnGet.Text = "Get QR";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Choose method";
            // 
            // cbMethod
            // 
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "Momo",
            "VNPay",
            "ZaloPay"});
            this.cbMethod.Location = new System.Drawing.Point(26, 106);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(126, 28);
            this.cbMethod.TabIndex = 17;
            // 
            // gbCre
            // 
            this.gbCre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbCre.Controls.Add(this.textBox1);
            this.gbCre.Controls.Add(this.label3);
            this.gbCre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCre.Location = new System.Drawing.Point(495, 174);
            this.gbCre.Name = "gbCre";
            this.gbCre.Size = new System.Drawing.Size(178, 211);
            this.gbCre.TabIndex = 14;
            this.gbCre.TabStop = false;
            this.gbCre.Text = "For credit card";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter PIN";
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(27, 222);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(125, 123);
            this.picQR.TabIndex = 15;
            this.picQR.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "QR here";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(808, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.gbCre);
            this.Controls.Add(this.gbQR);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Vendor Ticket";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbQR.ResumeLayout(false);
            this.gbQR.PerformLayout();
            this.gbCre.ResumeLayout(false);
            this.gbCre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button btnBack;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox gbQR;
        private GroupBox gbCre;
        private Label label5;
        private ComboBox cbMethod;
        private TextBox textBox1;
        private Label label3;
        private PictureBox picQR;
        private Label label4;
        private Button btnGet;
    }
}