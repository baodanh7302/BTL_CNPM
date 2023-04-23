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
    public partial class OrderDetailForm : Form
    {
        public OrderDetailForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            LoadOrderDetailData();
        }

        private void LoadOrderDetailData()
        {
            // Clear existing data in DataGridView
            orderDetailData.Rows.Clear();

            // Establish a connection to the SQL database
            string connectionString = @"Data Source=LAPTOP-T0EB0HS3\SQLEXPRESS;Initial Catalog=Ex1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    orderDetailData.Columns.Add("ID", "ID");
                    orderDetailData.Columns.Add("OrderID", "Order ID");
                    orderDetailData.Columns.Add("ItemID", "Product ID");
                    orderDetailData.Columns.Add("Quantity", "Quantity");
                    orderDetailData.Columns.Add("UnitAmount", "Unit Amount");

                    orderDetailData.Columns["ID"].Width = 100;
                    orderDetailData.Columns["OrderID"].Width = 200;
                    orderDetailData.Columns["ItemID"].Width = 150;
                    orderDetailData.Columns["Quantity"].Width = 200;
                    orderDetailData.Columns["UnitAmount"].Width = 150;

                    // Create SqlCommand object
                    using (SqlCommand command = new SqlCommand("SELECT * FROM OrderDetail", connection))
                    {
                        // Execute the SqlCommand and fetch data using SqlDataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Loop through the SqlDataReader and populate DataGridView with data
                            while (reader.Read())
                            {
                                // Extract data from SqlDataReader
                                int id = Convert.ToInt32(reader["ID"]);
                                int orderID = Convert.ToInt32(reader["OrderID"]);
                                int itemID = Convert.ToInt32(reader["ItemID"]);
                                int quantity = Convert.ToInt32(reader["Quantity"]);
                                decimal unitAmount = Convert.ToDecimal(reader["UnitAmount"]);

                                // Add data to DataGridView
                                orderDetailData.Rows.Add(id, orderID, itemID, quantity, unitAmount);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception, e.g., log or display error message
                    MessageBox.Show("Error loading order detail data: " + ex.Message);
                }
                finally
                {
                    // Ensure connection is closed
                    connection.Close();
                }
            }
        }

        private void addOrderDetail_Click(object sender, EventArgs e)
        {
            // Get input data from user
            int id = Convert.ToInt32(orderDetailIDtxt.Text);
            int orderID = Convert.ToInt32(orderIDtxt.Text);
            int itemID = Convert.ToInt32(itemIDtxt.Text);
            int quantity = Convert.ToInt32(quanlitytxt.Text);
            decimal unitAmount = Convert.ToDecimal(unitAmounttxt.Text);

            // Establish a connection to the SQL database
            string connectionString = @"Data Source=LAPTOP-T0EB0HS3\SQLEXPRESS;Initial Catalog=Ex1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create SqlCommand object with INSERT query to add new data to OrderDetail table
                using (SqlCommand command = new SqlCommand("INSERT INTO OrderDetail (ID, OrderID, ItemID, Quantity, UnitAmount) VALUES (@ID, @OrderID, @ItemID, @Quantity, @UnitAmount)", connection))
                {
                    // Add parameters to the SqlCommand to prevent SQL injection
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    command.Parameters.AddWithValue("@ItemID", itemID);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@UnitAmount", unitAmount);

                    // Execute the SqlCommand to insert new data to OrderDetail table
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order detail added successfully.");
                        // Clear input fields
                        orderDetailIDtxt.Clear();
                        orderIDtxt.Clear();
                        itemIDtxt.Clear();
                        quanlitytxt.Clear();
                        unitAmounttxt.Clear();

                        // Refresh DataGridView
                        LoadOrderDetailData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add order detail.");
                    }
                }

                // Ensure connection is closed
                connection.Close();
            }
        }


        private void orderDetailData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row from the DataGridView
                DataGridViewRow row = orderDetailData.Rows[e.RowIndex];

                // Retrieve data from the cells based on column index
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                int orderID = Convert.ToInt32(row.Cells["OrderID"].Value);
                int itemID = Convert.ToInt32(row.Cells["ItemID"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal unitAmount = Convert.ToDecimal(row.Cells["UnitAmount"].Value);

                // Display the retrieved data in input textboxes
                orderDetailIDtxt.Text = id.ToString();
                orderIDtxt.Text = orderID.ToString();
                itemIDtxt.Text = itemID.ToString();
                quanlitytxt.Text = quantity.ToString();
                unitAmounttxt.Text = unitAmount.ToString("0.00");
            }
        }
    }
}
