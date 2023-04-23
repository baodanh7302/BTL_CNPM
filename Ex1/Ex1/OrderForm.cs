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

namespace Ex1
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            orderData.Rows.Clear();

            // Connect to the SQL database
            string connectionString = @"Data Source=LAPTOP-T0EB0HS3\SQLEXPRESS;Initial Catalog=Ex1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    orderData.Columns.Add("OrderID", "Order ID");
                    orderData.Columns.Add("OrderDate", "Order Date");
                    orderData.Columns.Add("AgentID", "Agent ID");

                    orderData.Columns["OrderID"].Width = 100;
                    orderData.Columns["OrderDate"].Width = 200;
                    orderData.Columns["AgentID"].Width = 150;

                    // Retrieve products data from database
                    string query = "SELECT OrderID, OrderDate, AgentID FROM Order_Data";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Add retrieved products data to DataGridView
                    while (reader.Read())
                    {
                        int orderID = Convert.ToInt32(reader["OrderID"]);
                        string orderDate = reader["OrderDate"].ToString();
                        string agentID = reader["AgentID"].ToString();
                        orderData.Rows.Add(orderID, orderDate, agentID);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        private void addOrderButton_Click(object sender, EventArgs e)
        {
            int orderID;
            DateTime orderDate;
            int agentID;

            // Validate input
            if (!int.TryParse(orderIDtxt.Text, out orderID) || orderID <= 0)
            {
                MessageBox.Show("Invalid Order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(orderDatetxt.Text, out orderDate))
            {
                MessageBox.Show("Invalid Order Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(agentIDtxt.Text, out agentID) || agentID <= 0)
            {
                MessageBox.Show("Invalid Agent ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connect to the SQL database
            string connectionString = @"Data Source=LAPTOP-T0EB0HS3\SQLEXPRESS;Initial Catalog=Ex1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insert new order into the database
                    string query = "INSERT INTO Order_Data (OrderID, OrderDate, AgentID) VALUES (@OrderID, @OrderDate, @AgentID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    command.Parameters.AddWithValue("@OrderDate", orderDate);
                    command.Parameters.AddWithValue("@AgentID", agentID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh the DataGridView to display the newly added order
                        LoadOrderData();

                        orderIDtxt.Clear();
                        agentIDtxt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < orderData.Rows.Count)
            {
                DataGridViewRow row = orderData.Rows[e.RowIndex];

                // Retrieve the data from the selected row
                int orderID = Convert.ToInt32(row.Cells["OrderID"].Value);
                DateTime orderDate = Convert.ToDateTime(row.Cells["OrderDate"].Value);
                int agentID = Convert.ToInt32(row.Cells["AgentID"].Value);

                // Update the text boxes with the selected order data
                orderIDtxt.Text = orderID.ToString();
                orderDatetxt.Text = orderDate.ToString("yyyy-MM-dd");
                agentIDtxt.Text = agentID.ToString();
            }
        }


    }
}
