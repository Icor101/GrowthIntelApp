using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

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
            String oradb = "Data Source=DESKTOP-05556ET;User ID=SYSTEM;Password=iAmIronMan";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text.Equals(textBox2.Text))
            {
                DB_connect();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into doctor values('" + textBox1.Text + "','" + textBox2.Text + "')";
                cmd.CommandType = CommandType.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
