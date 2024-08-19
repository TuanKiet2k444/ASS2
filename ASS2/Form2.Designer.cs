namespace ASS2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThisMonthWaterMeter = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtLastMonthWaterMeter = new System.Windows.Forms.TextBox();
            this.txtConsumption = new System.Windows.Forms.TextBox();
            this.txtWaterMoney = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::ASS2.Properties.Resources.download__2_;
            this.label1.Location = new System.Drawing.Point(366, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::ASS2.Properties.Resources.download__2_;
            this.label2.Location = new System.Drawing.Point(319, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Month\'s Water Meter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::ASS2.Properties.Resources.download__2_;
            this.label3.Location = new System.Drawing.Point(318, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "This Month\'s Water Meter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::ASS2.Properties.Resources.download__2_;
            this.label4.Location = new System.Drawing.Point(356, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consumption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::ASS2.Properties.Resources.download__2_;
            this.label5.Location = new System.Drawing.Point(356, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "WaterMoney";
            // 
            // txtThisMonthWaterMeter
            // 
            this.txtThisMonthWaterMeter.Enabled = false;
            this.txtThisMonthWaterMeter.Location = new System.Drawing.Point(297, 215);
            this.txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            this.txtThisMonthWaterMeter.Size = new System.Drawing.Size(198, 22);
            this.txtThisMonthWaterMeter.TabIndex = 5;
            this.txtThisMonthWaterMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(297, 127);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(198, 22);
            this.txtCustomerName.TabIndex = 6;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastMonthWaterMeter
            // 
            this.txtLastMonthWaterMeter.Enabled = false;
            this.txtLastMonthWaterMeter.Location = new System.Drawing.Point(297, 171);
            this.txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            this.txtLastMonthWaterMeter.Size = new System.Drawing.Size(198, 22);
            this.txtLastMonthWaterMeter.TabIndex = 7;
            this.txtLastMonthWaterMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConsumption
            // 
            this.txtConsumption.Enabled = false;
            this.txtConsumption.Location = new System.Drawing.Point(297, 259);
            this.txtConsumption.Name = "txtConsumption";
            this.txtConsumption.Size = new System.Drawing.Size(198, 22);
            this.txtConsumption.TabIndex = 8;
            this.txtConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWaterMoney
            // 
            this.txtWaterMoney.Enabled = false;
            this.txtWaterMoney.Location = new System.Drawing.Point(297, 303);
            this.txtWaterMoney.Name = "txtWaterMoney";
            this.txtWaterMoney.Size = new System.Drawing.Size(198, 22);
            this.txtWaterMoney.TabIndex = 9;
            this.txtWaterMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWaterMoney.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnPay
            // 
            this.btnPay.Image = global::ASS2.Properties.Resources.download__2_;
            this.btnPay.Location = new System.Drawing.Point(547, 378);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ASS2.Properties.Resources.download__2_;
            this.btnExit.Location = new System.Drawing.Point(179, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ASS2.Properties.Resources.download__2_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtWaterMoney);
            this.Controls.Add(this.txtConsumption);
            this.Controls.Add(this.txtLastMonthWaterMeter);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtThisMonthWaterMeter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThisMonthWaterMeter;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtLastMonthWaterMeter;
        private System.Windows.Forms.TextBox txtConsumption;
        private System.Windows.Forms.TextBox txtWaterMoney;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnExit;
    }
}