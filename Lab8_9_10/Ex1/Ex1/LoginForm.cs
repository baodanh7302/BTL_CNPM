namespace Ex1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = UserNameInput.Text;
            string password = PasswordInput.Text;

            if (IsValidUser(username, password))
            {
                
                this.Hide();
                    
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool IsValidUser(string username, string password)
        {
    
            return (username == "admin" && password == "password");
        }
    }
}