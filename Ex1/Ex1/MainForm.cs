using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void AgentButton_Click(object sender, EventArgs e)
        {
            AgentForm agentForm = new AgentForm();
            agentForm.ShowDialog();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderDetailForm_Click(object sender, EventArgs e)
        {
            OrderDetailForm orderDetailForm = new OrderDetailForm();
            orderDetailForm.ShowDialog();
        }
    }
}
