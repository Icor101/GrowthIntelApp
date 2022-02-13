using System;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp4
{
    public partial class Login : Form
    {
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        OracleConnection conn;

        public Login()
        {
            InitializeComponent();
        }

        public void DB_connect()
        {
            String oradb = "Data Source=XE;User ID=SYSTEM;Password=<PASSWORD>";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            DB_connect();
            OracleCommand cmd = new OracleCommand("checkUserAndPswd", conn)
            {
                Connection = conn
            };
            OracleParameter user = new OracleParameter
            {
                DbType = DbType.String,
                Value = textBox1.Text,
                Direction = ParameterDirection.Input
            }, pswd = new OracleParameter
            {
                DbType = DbType.String,
                Direction = ParameterDirection.Input
            }, flag = new OracleParameter
            {
                DbType = DbType.String,
                Value = "true",
                Direction = ParameterDirection.InputOutput
            };
            pswd.Value = ComputeSha256Hash(textBox2.Text);
            cmd.Parameters.Add(user);
            cmd.Parameters.Add(pswd);
            cmd.Parameters.Add(flag);

            cmd.CommandText = "checkUserAndPswd";
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();
                if (cmd.Parameters[2].Value.ToString().Equals("true"))
                {
                    MainAppWindow f = new MainAppWindow();
                    f.Show();
                    conn.Close();
                }
                this.Hide();
            }catch(Exception exception)
            {
                Debug.WriteLine(exception.Message);
                String title = "Error!";
                MessageBox.Show("Invalid Input",title);
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm sf = new SignUpForm();
            this.Hide();
            sf.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
