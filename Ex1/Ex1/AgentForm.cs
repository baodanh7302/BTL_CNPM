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
    public partial class AgentForm : Form
    {
        public AgentForm()
        {
            InitializeComponent();
        }

        private void AgentForm_Load(object sender, EventArgs e)
        {
            LoadAgentData();
        }

        private void LoadAgentData()
        {
            agentData.Rows.Clear();

            // Connect to the SQL database
            string connectionString = @"Data Source=LAPTOP-T0EB0HS3\SQLEXPRESS;Initial Catalog=Ex1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    agentData.Columns.Add("AgentID", "Agent ID");
                    agentData.Columns.Add("AgentName", "Agent Name");
                    agentData.Columns.Add("Address", "Agent Address");

                    agentData.Columns["AgentID"].Width = 100;
                    agentData.Columns["AgentName"].Width = 200;
                    agentData.Columns["Address"].Width = 150;

                    // Retrieve products data from database
                    string query = "SELECT AgentID, AgentName, Address FROM Agent";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Add retrieved products data to DataGridView
                    while (reader.Read())
                    {
                        int agentID = Convert.ToInt32(reader["AgentID"]);
                        string agentName = reader["AgentName"].ToString();
                        string address = reader["Address"].ToString();
                        agentData.Rows.Add(agentID, agentName, address);
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

        private void agentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected agent's data from the DataGridView
                DataGridViewRow row = agentData.Rows[e.RowIndex];
                int agentID = Convert.ToInt32(row.Cells["AgentID"].Value);
                string agentName = row.Cells["AgentName"].Value.ToString();
                string address = row.Cells["Address"].Value.ToString();

                // Display the selected agent's data in input textboxes
                agentIDtxt.Text = agentID.ToString();
                agentNametxt.Text = agentName;
                agentAddresstxt.Text = address;
            }
        }

        private void addAgentButton_Click(object sender, EventArgs e)
        {
            string agentID = agentIDtxt.Text;
            string agentName = agentNametxt.Text;
            string address = agentAddresstxt.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(agentID) || string.IsNullOrWhiteSpace(agentName) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Agent ID, Agent Name, and Address are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert agentID to int
            if (!int.TryParse(agentID, out int agentIDInt))
            {
                MessageBox.Show("Agent ID must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connect to the SQL database
            string connectionString = @"Data Source=LAPTOP-T0EB0HS3\SQLEXPRESS;Initial Catalog=Ex1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insert new agent into the database
                    string query = "INSERT INTO Agent (AgentID, AgentName, Address) VALUES (@AgentID, @AgentName, @Address)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AgentID", agentIDInt);
                    command.Parameters.AddWithValue("@AgentName", agentName);
                    command.Parameters.AddWithValue("@Address", address);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Agent added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh the DataGridView to display the newly added agent
                        LoadAgentData();

                        agentIDtxt.Clear();
                        agentNametxt.Clear();
                        agentAddresstxt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add agent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

