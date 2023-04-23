using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ex1
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(itemIDtxt.Text);
            string productName = itemNametxt.Text;
            string productSize = itemSizetxt.Text;

            // Connect to the SQL database
            string connectionString = @"Data Source=LAPTOP-T0EB0HS3\SQLEXPRESS;Initial Catalog=Ex1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insert the new product data into the database
                    string query = "INSERT INTO Item (ItemID, ItemName, Size) VALUES (@ItemId, @ItemName, @Size)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ItemId", productId);
                    command.Parameters.AddWithValue("@ItemName", productName);
                    command.Parameters.AddWithValue("@Size", productSize);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product added successfully.");
                        LoadProductsData(); // Refresh the products data in the DataGridView

                        itemIDtxt.Clear();
                        itemNametxt.Clear();
                        itemSizetxt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product.");
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProductsData();
            filterSizeProduct.Items.Add("Choose the size for filter");
            filterSizeProduct.Items.Add("Small");
            filterSizeProduct.Items.Add("Medium");
            filterSizeProduct.Items.Add("Large");
            filterSizeProduct.SelectedIndex = 0;
        }

        private void LoadProductsData()
        {
            productData.Rows.Clear();

            // Connect to the SQL database
            string connectionString = @"Data Source=LAPTOP-T0EB0HS3\SQLEXPRESS;Initial Catalog=Ex1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    productData.Columns.Add("ProductID", "Product ID");
                    productData.Columns.Add("ProductName", "Product Name");
                    productData.Columns.Add("ProductSize", "Product Size");

                    productData.Columns["ProductID"].Width = 100;
                    productData.Columns["ProductName"].Width = 200;
                    productData.Columns["ProductSize"].Width = 150;

                    // Retrieve products data from database
                    string query = "SELECT ItemID, ItemName, Size FROM Item";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Add retrieved products data to DataGridView
                    while (reader.Read())
                    {
                        int productId = Convert.ToInt32(reader["ItemID"]);
                        string productName = reader["ItemName"].ToString();
                        string productSize = reader["Size"].ToString();
                        productData.Rows.Add(productId, productName, productSize);
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

        private void filterSizeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterSize = filterSizeProduct.SelectedItem.ToString(); // Get the selected filter size

            // Connect to the SQL database
            string connectionString = @"Data Source=LAPTOP-T0EB0HS3\SQLEXPRESS;Initial Catalog=Ex1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Retrieve filtered products data from database
                    string query = "";
                    if (filterSize == "Choose the size for filter")
                    {
                        // Show all data without filter
                        query = "SELECT ItemID, ItemName, Size FROM Item";
                    }
                    else
                    {
                        // Filter by selected size
                        query = "SELECT ItemID, ItemName, Size FROM Item WHERE Size = @FilterSize";
                    }

                    SqlCommand command = new SqlCommand(query, connection);

                    if (filterSize != "Choose the size for filter")
                    {
                        command.Parameters.AddWithValue("@FilterSize", filterSize); // Use the selected filter size as parameter value
                    }

                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing rows in DataGridView
                    productData.Rows.Clear();

                    // Add retrieved filtered products data to DataGridView
                    while (reader.Read())
                    {
                        int productId = Convert.ToInt32(reader["ItemID"]);
                        string productName = reader["ItemName"].ToString();
                        string productSize = reader["Size"].ToString();
                        productData.Rows.Add(productId, productName, productSize);
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

        private void productData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check for valid cell click
            {
                DataGridViewRow selectedRow = productData.Rows[e.RowIndex];
                itemIDtxt.Text = selectedRow.Cells["ProductID"].Value.ToString();
                itemNametxt.Text = selectedRow.Cells["ProductName"].Value.ToString();
                itemSizetxt.Text = selectedRow.Cells["ProductSize"].Value.ToString();
            }
        }
    }
}
