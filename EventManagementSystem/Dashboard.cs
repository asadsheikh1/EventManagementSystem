using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            PackageForm packageForm = new PackageForm();
            packageForm.Show();
        }

        private void btnEventModule_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            TransportForm transportForm = new TransportForm();
            transportForm.Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.Show();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.Show();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm();
            foodForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFoodDeals_Click(object sender, EventArgs e)
        {
            FoodDeals foodDeals = new FoodDeals();
            foodDeals.Show();
        }
    }
}
