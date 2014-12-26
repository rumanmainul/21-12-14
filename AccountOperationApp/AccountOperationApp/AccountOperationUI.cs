using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountOperationUI : Form
    {
        public AccountOperationUI()
        {
            InitializeComponent();
        }
        Customer aCustomer = new Customer();
        private void createButton_Click(object sender, EventArgs e)
        {
            
            aCustomer.customerName = customerNameTextBox.Text;
            aCustomer.accountNumber = accountNumberTextBox.Text;
            MessageBox.Show("Account Create");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
           int amount = Convert.ToInt32(balanceTextBox.Text);
           aCustomer.DoDeposit(amount);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string alertForCustomer = aCustomer.customerName + ", your account number is " + aCustomer.accountNumber +
                                      "and balance is" + aCustomer.balance;
            MessageBox.Show(alertForCustomer);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(balanceTextBox.Text);
            aCustomer.DoWithdraw(amount);
        }
    }
}
