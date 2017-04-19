using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueeFormApp
{
    public partial class Form1 : Form
    {
        Queue<Customer> customers = new Queue<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void enqueeButton_Click(object sender, EventArgs e)
        {

            int id1 = customers.Count;
            Customer newCustomer = new Customer(id1 + 1, inputNameTextBox.Text, inputComplainTextBox.Text);
            customers.Enqueue(newCustomer);
            inputComplainTextBox.Clear();
            inputNameTextBox.Clear();
            if (customerListView.Items.Count == 0)
            {
                ListViewItem x=new ListViewItem();
                x.Text = newCustomer.Serial.ToString();
               x.SubItems.Add(newCustomer.Name);
                x.SubItems.Add(newCustomer.Complain);
                customerListView.Items.Add(x);

            }
            else
            {
                ListViewItem x1 = new ListViewItem();
                x1.Text = newCustomer.Serial.ToString();
                x1.SubItems.Add(newCustomer.Name);
                x1.SubItems.Add(newCustomer.Complain);
                customerListView.Items.Add(x1);
            }
            MessageBox.Show(newCustomer.Name + "'s serial number is " + newCustomer.Serial);
        }

        private void dequeeButton_Click(object sender, EventArgs e)
        {
            Customer nCustomer = customers.Dequeue();
            outputSerialTextBox.Text = nCustomer.Serial.ToString();
            outputNameTextBox.Text = nCustomer.Name;
            outputComplainTextBox.Text = nCustomer.Complain;
            customerListView.Items.RemoveAt(0);
        }
    }
}
