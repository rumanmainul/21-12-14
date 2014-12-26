using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueApp
{
    public partial class CutomerQueueManagement : Form
    {
        public CutomerQueueManagement()
        {
            InitializeComponent();
        }

      

        private void EnqueueButton_Click(object sender, EventArgs e)
        {
           
            string connectionString = @"Data Source=(local)\sqlexpress; Database=CutomerQueueDB; Integrated Security=true";
            SqlConnection Connection = new SqlConnection(connectionString);
            Connection.Open();
            Customer aCustomer = new Customer();

            aCustomer.customerName = addCustomerNameTextBox.Text;
            aCustomer.customerComplaign = addComplaignTextBox.Text;
            aCustomer.status = 1;
            string sqlQuery = "insert into tCustomerQue values('"+aCustomer.customerName+"', '"+aCustomer.customerComplaign+"', '"+aCustomer.status+"')";
            SqlCommand command = new SqlCommand(sqlQuery, Connection);
            int rowEffected = command.ExecuteNonQuery();
            if (rowEffected>0)
            {
                MessageBox.Show("Add Success");
            }
            Connection.Close();
            LoadCustomerQueue(Connection);
           
        }

        private void LoadCustomerQueue(SqlConnection Connection)
        {
           Connection.Open();
           List<Customer> customers = new List<Customer>();
           Customer aCustomer = new Customer();
           string sqlQuery = "SELECT * FROM tCustomerQue";
           SqlCommand command = new SqlCommand(sqlQuery, Connection);
           SqlDataReader aReader = command.ExecuteReader();
            ListViewItem lvi = new ListViewItem();
            string[] stuStrings = new string[4];
            customerQueListBox.Items.Clear();
            while (aReader.Read())
            {
                aCustomer.serial = Convert.ToInt32(aReader["Serial"]);
                aCustomer.customerName = aReader["Name"].ToString();
                aCustomer.customerComplaign = aReader["CustomerComplaign"].ToString();
                int status = Convert.ToInt32(aReader["Staus"]);
                if (status == 1)
                {
                    aCustomer.tStatus = "Served ON";
                }
                stuStrings[0] = aCustomer.serial.ToString();
                stuStrings[1] = aCustomer.customerName;
                stuStrings[2] = aCustomer.customerComplaign;
                stuStrings[3] = aCustomer.tStatus;
                lvi = new ListViewItem(stuStrings);
                customerQueListBox.Items.Add(lvi);
            }
        }

        private void CutomerQueueManagement_Activated(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\sqlexpress; Database=CutomerQueueDB; Integrated Security=true";
            SqlConnection Connection = new SqlConnection(connectionString);
            LoadCustomerQueue(Connection);
        }

        private void DequeueButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local)\sqlexpress; Database=CutomerQueueDB; Integrated Security=true";
            SqlConnection Connection = new SqlConnection(connectionString);
            Connection.Open();
            Customer aCustomer = new Customer();
            string sqlQuery = "SELECT MIN(Serial) FROM tCustomerQue where Staus =1";
            SqlCommand command = new SqlCommand(sqlQuery, Connection);
            SqlDataReader aReader = command.ExecuteReader();
            aReader.Read();
            int noOfServedCustomer = Convert.ToInt32(aReader[0]);
            Connection.Close();
            Connection.Open();
            string sqlQueryto = "SELECT * FROM tCustomerQue WHERE Serial = '" + noOfServedCustomer + "'";
            SqlCommand commandSelect = new SqlCommand(sqlQueryto, Connection);
            SqlDataReader aCustomerReader = commandSelect.ExecuteReader();
            while (aCustomerReader.Read())
            {
                serialTextBox.Text = aCustomerReader["Serial"].ToString();
                dequeueCustomerNameTextBox.Text = aCustomerReader["Name"].ToString();
                dequeueComplaignTextBox.Text = aCustomerReader["CustomerComplaign"].ToString();
            }
            UpdateCustomerStatus(noOfServedCustomer);
        }

        private void UpdateCustomerStatus(int noOfServedCustomer)
        {
            string connectionString = @"Data Source=(local)\sqlexpress; Database=CutomerQueueDB; Integrated Security=true";
            SqlConnection Connection = new SqlConnection(connectionString);
            Connection.Open();
            string sqlQueryUpdate = "Update tCustomerQue set Staus = 0 where Serial = '" + noOfServedCustomer + "'";
        }
    }
}
