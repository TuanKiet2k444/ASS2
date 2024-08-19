using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASS2
{
    public partial class Form2 : Form
    {
        string CustomerName;
        double LastMonthWaterMeter;
        double ThisMonthWaterMeter;
        double Consumption;
        double WaterMoney;
        public Form2(string customerName, double lastMonthWaterMeter, double thisMonthWaterMeter, double consumption, double waterMoney)
        {
            InitializeComponent();
            this.CustomerName = customerName;
            this.LastMonthWaterMeter = lastMonthWaterMeter;
            this.ThisMonthWaterMeter = thisMonthWaterMeter;
            this.Consumption = consumption;
            this.WaterMoney = waterMoney;

            txtCustomerName.Text = customerName;
            txtLastMonthWaterMeter.Text = lastMonthWaterMeter.ToString();
            txtThisMonthWaterMeter.Text = thisMonthWaterMeter.ToString();
            txtConsumption.Text = consumption.ToString();
            txtWaterMoney.Text = waterMoney.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment success");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
