namespace ASS2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

      
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

      
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.Customer = new System.Windows.Forms.Label();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.txtLastMonthWaterMeter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTypeOfCustomer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThisMonthWaterMeter = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.lvWaterBill = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(12, 61);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(234, 22);
            this.txtCustomerName.TabIndex = 0;
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.BackColor = System.Drawing.SystemColors.Control;
            this.Customer.Image = global::ASS2.Properties.Resources.download__2_;
            this.Customer.Location = new System.Drawing.Point(9, 42);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(104, 16);
            this.Customer.TabIndex = 1;
            this.Customer.Text = "Customer Name";
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Location = new System.Drawing.Point(12, 221);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(234, 22);
            this.txtNumberOfPeople.TabIndex = 3;
            // 
            // txtLastMonthWaterMeter
            // 
            this.txtLastMonthWaterMeter.Location = new System.Drawing.Point(12, 301);
            this.txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            this.txtLastMonthWaterMeter.Size = new System.Drawing.Size(234, 22);
            this.txtLastMonthWaterMeter.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::ASS2.Properties.Resources.download__2_;
            this.label2.Location = new System.Drawing.Point(9, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type Of Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::ASS2.Properties.Resources.download__2_;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number Of People";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::ASS2.Properties.Resources.download__2_;
            this.label4.Location = new System.Drawing.Point(9, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Month\'s Water Meter";
            // 
            // cboTypeOfCustomer
            // 
            this.cboTypeOfCustomer.FormattingEnabled = true;
            this.cboTypeOfCustomer.Location = new System.Drawing.Point(12, 144);
            this.cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            this.cboTypeOfCustomer.Size = new System.Drawing.Size(234, 24);
            this.cboTypeOfCustomer.TabIndex = 8;
            this.cboTypeOfCustomer.SelectedIndexChanged += new System.EventHandler(this.cboTypeOfCustomer_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::ASS2.Properties.Resources.download__2_;
            this.label5.Location = new System.Drawing.Point(9, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "This Month\'s Water Meter:";
            // 
            // txtThisMonthWaterMeter
            // 
            this.txtThisMonthWaterMeter.Location = new System.Drawing.Point(12, 377);
            this.txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            this.txtThisMonthWaterMeter.Size = new System.Drawing.Size(234, 22);
            this.txtThisMonthWaterMeter.TabIndex = 10;
            // 
            // btnDone
            // 
            this.btnDone.Image = global::ASS2.Properties.Resources.download__2_;
            this.btnDone.Location = new System.Drawing.Point(171, 405);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lvWaterBill
            // 
            this.lvWaterBill.HideSelection = false;
            this.lvWaterBill.Location = new System.Drawing.Point(252, 42);
            this.lvWaterBill.Name = "lvWaterBill";
            this.lvWaterBill.Size = new System.Drawing.Size(770, 357);
            this.lvWaterBill.TabIndex = 12;
            this.lvWaterBill.UseCompatibleStateImageBehavior = false;
            this.lvWaterBill.SelectedIndexChanged += new System.EventHandler(this.lvWaterBill_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::ASS2.Properties.Resources.download__2_;
            this.btnClose.Location = new System.Drawing.Point(12, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(363, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(454, 22);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ASS2.Properties.Resources.download__2_;
            this.ClientSize = new System.Drawing.Size(1034, 465);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvWaterBill);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtThisMonthWaterMeter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTypeOfCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastMonthWaterMeter);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.TextBox txtLastMonthWaterMeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTypeOfCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThisMonthWaterMeter;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListView lvWaterBill;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

