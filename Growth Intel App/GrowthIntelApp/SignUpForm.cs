using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp4
{
    public partial class SignUpForm : Form
    {

        OracleConnection conn;

        public SignUpForm()
        {
            InitializeComponent();
        }

        public void DB_connect()
        {
            String oradb = "Data Source=XE;User ID=SYSTEM;Password=<PASSWORD>";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if(textBox3.Text.Equals(textBox2.Text))
            {
                DB_connect();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = conn,
                    CommandText = "insert into doctor values('" + textBox1.Text + "','" + Login.ComputeSha256Hash(textBox2.Text) + "')",
                    CommandType = CommandType.Text
                };
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account successfully created",  "Created");
                conn.Close();
            }
            else
            {
                String title = "Error!";
                MessageBox.Show("Passwords do not match",title);
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
