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
    public partial class Form1 : Form
    {
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DB_connect()
        {
            String oradb = "Data Source=DESKTOP-05556ET;User ID=SYSTEM;Password=iAmIronMan";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_connect();
            OracleCommand cmd = new OracleCommand("checkUserAndPswd",conn);
            cmd.Connection = conn;

            OracleParameter user = new OracleParameter(), pswd = new OracleParameter(), flag = new OracleParameter();
            user.DbType = DbType.String;
            user.Value = textBox1.Text;
            user.Direction = ParameterDirection.Input;

            pswd.DbType = DbType.String;
            pswd.Value = textBox2.Text;
            pswd.Direction = ParameterDirection.Input;

            flag.DbType = DbType.String;
            flag.Value = "true";
            flag.Direction = ParameterDirection.InputOutput;

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
                    Form3 f = new Form3();
                    f.Show();
                    conn.Close();
                }
                this.Hide();
            }catch(Exception ef)
            {
                String title = "Error!";
                MessageBox.Show("Invalid Input",title);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpForm sf = new SignUpForm();
            this.Hide();
            sf.Show();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
