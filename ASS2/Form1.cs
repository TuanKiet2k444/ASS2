using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ASS2
{
    public partial class Form1 : Form
    {
        public List<Invoice> invoices = new List<Invoice>();
        public const double VAT = 0.1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            // Add customer types to the combo box  
            cboTypeOfCustomer.Items.Add("Household Customer");
            cboTypeOfCustomer.Items.Add("Administrative agency, public services");
            cboTypeOfCustomer.Items.Add("Production units");
            cboTypeOfCustomer.Items.Add("Business services");
            // Setup ListView to display water bill details
            lvWaterBill.View = View.Details;
            lvWaterBill.Columns.Add("Custom Name", 200);
            lvWaterBill.Columns.Add("Last Month's Water Meter", 200);
            lvWaterBill.Columns.Add("This Month's Water Meter", 200);
            lvWaterBill.Columns.Add("Amount Of Consumption", 200);
            lvWaterBill.Columns.Add("Total Water Bill", 200);
        }

        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = cboTypeOfCustomer.Text;
            // Enable or disable the number of people textbox based on customer type
            if (customerType == "Household Customer")
            {
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
                txtNumberOfPeople.Text = "";
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // Retrieve and trim any leading/trailing spaces from the customer name input
            string customerName = txtCustomerName.Text.Trim();
            // Retrieve the selected customer type from the dropdown menu (combobox)
            string customerType = cboTypeOfCustomer.Text;
            // Initialize variables related to the number of people and water meter readings
            // These might be used later in the code for further processing
            int numberOfPeople = 0;
            double lastMonthWaterMeter = 0;
            double thisMonthWaterMeter = 0;
            // Validate that the customer name is not empty
            if (customerName == "")
            {
                // Show an error message if the customer name is empty
                MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;// Stop further processing if validation fails
            }
            // Validate that the customer type has been selected
            if (customerType == "")
            {
                // Show an error message if the customer type is not selected
                MessageBox.Show("Please select customer type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;// Stop further processing if validation fails
            } // Further logic can be implemented here after validating the inputs
            // Validate number of people for household customers
            if (customerType == "Household Customer")
            {
                if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0)
                {
                    MessageBox.Show("Please enter a valid number of people.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!double.TryParse(txtLastMonthWaterMeter.Text, out lastMonthWaterMeter) || lastMonthWaterMeter < 0)
            {
                MessageBox.Show("Please enter a valid last month's water meter reading.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtThisMonthWaterMeter.Text, out thisMonthWaterMeter) || thisMonthWaterMeter < 0)
            {
                MessageBox.Show("Please enter a valid this month's water meter reading.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (thisMonthWaterMeter < lastMonthWaterMeter)
            {
                MessageBox.Show("This month's water meter reading cannot be less than last month's reading.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var waterBill = CalculateWaterBill(customerType, numberOfPeople, lastMonthWaterMeter, thisMonthWaterMeter);

            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(lastMonthWaterMeter.ToString());
            item.SubItems.Add(thisMonthWaterMeter.ToString());
            item.SubItems.Add(waterBill.Item1.ToString());
            item.SubItems.Add(waterBill.Item2.ToString());
            lvWaterBill.Items.Add(item);

            Invoice invoice = new Invoice
            {
                CustomerName = customerName,
                LastMonthWaterMeter = lastMonthWaterMeter,
                ThisMonthWaterMeter = thisMonthWaterMeter,
                Consumption = waterBill.Item1,
                WaterMoney = waterBill.Item2,

            };
            invoices.Add(invoice);
        }

        private (double, double) CalculateWaterBill(string customerType, int numberOfPeople, double lastMonthWaterMeter, double thisMonthWaterMeter)
        {
            double consumption = thisMonthWaterMeter - lastMonthWaterMeter;
            double waterMoney = 0;

            if (customerType == "Household Customer")
            {
                double averagePerson = consumption / numberOfPeople;
                if (averagePerson < 10)
                {
                    waterMoney = consumption * 5973;
                }
                else if (averagePerson >= 10 && averagePerson < 20)
                {
                    waterMoney = consumption * 7052;
                }
                else if (averagePerson >= 20 && averagePerson < 30)
                {
                    waterMoney = consumption * 8699;
                }
                else if (averagePerson >= 30)
                {
                    waterMoney = consumption * 15929;
                }
            }
            else if (customerType == "Administrative agency, public services")
            {
                waterMoney = consumption * 9955;
            }
            else if (customerType == "Production units")
            {
                waterMoney = consumption * 11615;
            }
            else if (customerType == "Business services")
            {
                waterMoney = consumption * 22068;
            }

            waterMoney += (waterMoney * VAT);
            return (consumption, waterMoney);
        }

        private void lvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
                int index = lvWaterBill.SelectedItems[0].Index;
            Invoice invoice = invoices[index];
                    Form2 bill = new Form2(invoices[index].CustomerName, invoices[index].LastMonthWaterMeter, invoices[index].ThisMonthWaterMeter, invoices[index].Consumption, invoices[index].WaterMoney);
                    bill.Show();

        }
        public class Invoice
        {
            public string CustomerName { get; set; }
            public double LastMonthWaterMeter { get; set; }
            public double ThisMonthWaterMeter { get; set; }
            public double Consumption { get; set; }
            public double WaterMoney { get; set; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            lvWaterBill.Items.Clear();
            bool foundResult = false;

            if (search == "")
            {
                foreach (Invoice invoice in invoices)
                {

                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                    lvWaterBill.Items.Add(item);

                }
                foundResult = true;
            }
            else
            {
                foreach (Invoice invoice in invoices)
                {
                    if (invoice.CustomerName.ToLower().Contains(search))
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lvWaterBill.Items.Add(item);
                        foundResult = true;
                    }   
                }
            }
            if (!foundResult)
            {
                ListViewItem item = new ListViewItem("No results found");
                lvWaterBill.Items.Add(item);
            }
        }
    }
}


      