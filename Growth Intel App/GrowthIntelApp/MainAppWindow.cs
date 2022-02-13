using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp4
{
    public partial class MainAppWindow : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da,da1;
        DataSet ds,ds1;
        DataTable dt,dt1;
        int gender;

        public MainAppWindow()
        {
            InitializeComponent();
        }
        public void DB_connect()
        {
            String oradb = "Data Source=XE;User ID=SYSTEM;Password=<PASSWORD>";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void MainAppWindowLoad(object sender, EventArgs e)
        {
            DB_connect();
            comm = new OracleCommand
            {
                CommandText = "select agemos from statage where sex=1 union select age from wtageinf where sex=1",
                CommandType = CommandType.Text
            };
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_statage");
            dt = ds.Tables["Tbl_statage"];
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "agemos";


            comm = new OracleCommand
            {
                CommandText = "select len from wtleninf where sex=1",
                CommandType = CommandType.Text
            };
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_statage");
            dt = ds.Tables["Tbl_statage"];
           
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "len";

            comm = new OracleCommand
            {
                CommandText = "select height from wtstat where sex=1",
                CommandType = CommandType.Text
            };
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_statage");
            dt = ds.Tables["Tbl_statage"];
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "height";
            comm = new OracleCommand
            {
                CommandText = "select chid from register",
                CommandType = CommandType.Text
            };
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_register");
            dt = ds.Tables["Tbl_register"];
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "chid";

            conn.Close();
            //this.Dispose();
        }

        private void MainAppWindow_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DB_connect();

            comm = new OracleCommand("vaccupdate", conn)
            {
                Connection = conn
            };
            try
            {
                OracleParameter o1 = new OracleParameter
                {
                    DbType = DbType.Int32,
                    Value = Int32.Parse(comboBox4.Text),
                    Direction = ParameterDirection.Input
                }, o2 = new OracleParameter
                {
                    DbType = DbType.Int32,
                    Value = Int32.Parse(comboBox5.Text),
                    Direction = ParameterDirection.Input
                }, o3 = new OracleParameter
                {
                    DbType = DbType.Int32,
                    Value = Int32.Parse(comboBox6.Text),
                    Direction = ParameterDirection.Input
                }, o4 = new OracleParameter
                {
                    DbType = DbType.Int32,
                    Value = Int32.Parse(comboBox7.Text),
                    Direction = ParameterDirection.Input
                }, o5 = new OracleParameter
                {
                    DbType = DbType.Int32,
                    Value = Int32.Parse(comboBox8.Text),
                    Direction = ParameterDirection.Input
                }, o6 = new OracleParameter
                {
                    DbType = DbType.Int32,
                    Value = Int32.Parse(comboBox9.Text),
                    Direction = ParameterDirection.Input
                }, o7 = new OracleParameter
                {
                    DbType = DbType.Int32,
                    Value = Int32.Parse(comboBox10.Text),
                    Direction = ParameterDirection.Input
                }, o8 = new OracleParameter
                {
                    DbType = DbType.Int32,
                    Value = Int32.Parse(comboBox11.Text),
                    Direction = ParameterDirection.Input
                };

                comm.Parameters.Add(o1);
                //comm.Parameters.Add(age);
                comm.Parameters.Add(o2);
                comm.Parameters.Add(o3);
                comm.Parameters.Add(o4);
                comm.Parameters.Add(o5);
                comm.Parameters.Add(o6);
                comm.Parameters.Add(o7);
                comm.Parameters.Add(o8);
                comm.CommandText = "vaccupdate";
                comm.CommandType = CommandType.StoredProcedure;
                comm.ExecuteNonQuery();
                MessageBox.Show("Database has been updated");

            }catch(Exception exception)
            {
                MessageBox.Show("Invalid Input", "Error!");
                Debug.WriteLine(exception.Message);
            }

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TabChange(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            DB_connect();
            comm = new OracleCommand("calcZScore", conn)
            {
                Connection = conn
            };

            //Output Parameters
            OracleParameter o1 = new OracleParameter(), o2 = new OracleParameter(), o3 = new OracleParameter(), o4 = new OracleParameter(), o5 = new OracleParameter(), o6 = new OracleParameter(), o7 = new OracleParameter(),exc=new OracleParameter();
            
            //Input Parameters
            OracleParameter sex=new OracleParameter(),len=new OracleParameter(),stat=new OracleParameter(),weight=new OracleParameter(),age = new OracleParameter(),hc=new OracleParameter(),height=new OracleParameter();
            try
            {
                age.DbType = DbType.Decimal;
                age.Value = Decimal.Parse(comboBox1.Text);
                age.Direction = ParameterDirection.Input;

                len.DbType = DbType.Decimal;
                len.Value = Decimal.Parse(comboBox2.Text);
                len.Direction = ParameterDirection.Input;

                height.DbType = DbType.Decimal;
                height.Value = Decimal.Parse(comboBox3.Text);
                height.Direction = ParameterDirection.Input;

                weight.DbType = DbType.Decimal;
                weight.Value = Decimal.Parse(textBox1.Text);
                weight.Direction = ParameterDirection.Input;

                hc.DbType = DbType.Decimal;
                hc.Value = Decimal.Parse(textBox2.Text);
                hc.Direction = ParameterDirection.Input;

                stat.DbType = DbType.Decimal;
                stat.Value = Decimal.Parse(textBox3.Text);
                stat.Direction = ParameterDirection.Input;

                sex.DbType = DbType.Int32;
                sex.Value = gender;
                sex.Direction = ParameterDirection.Input;

                o1.DbType = DbType.Decimal;
                o1.Direction = ParameterDirection.Output;

                o2.DbType = DbType.Decimal;
                o2.Direction = ParameterDirection.Output;

                o3.DbType = DbType.Decimal;
                o3.Direction = ParameterDirection.Output;

                o4.DbType = DbType.Decimal;
                o4.Direction = ParameterDirection.Output;

                o5.DbType = DbType.Decimal;
                o5.Direction = ParameterDirection.Output;

                o6.DbType = DbType.Decimal;
                o6.Direction = ParameterDirection.Output;

                o7.DbType = DbType.Decimal;
                o7.Direction = ParameterDirection.Output;

                exc.DbType = DbType.Int32;
                exc.Direction = ParameterDirection.Output;

                comm.Parameters.Add(sex);
                comm.Parameters.Add(age);
                comm.Parameters.Add(height);
                comm.Parameters.Add(weight);
                comm.Parameters.Add(len);
                comm.Parameters.Add(hc);
                comm.Parameters.Add(stat);
                comm.Parameters.Add(o1);
                comm.Parameters.Add(o2);
                comm.Parameters.Add(o3);
                comm.Parameters.Add(o4);
                comm.Parameters.Add(o5);
                comm.Parameters.Add(o6);
                comm.Parameters.Add(o7);
                comm.Parameters.Add(exc);

                comm.CommandText = "calcZScore";
                comm.CommandType = CommandType.StoredProcedure;
                comm.ExecuteNonQuery();

                if (comm.Parameters[14].Value.ToString().Equals("-1"))
                    MessageBox.Show("Data entered is inconsistent with the static tables","Error!");
                else
                {
                    MessageBox.Show("a:" + comm.Parameters[7].Value.ToString() + " b:" + comm.Parameters[8].Value.ToString() + " c:" + comm.Parameters[9].Value.ToString() + " d:" + comm.Parameters[10].Value.ToString() + " e:" + comm.Parameters[11].Value.ToString() + " f:" + comm.Parameters[12].Value.ToString() + " g:" + comm.Parameters[13].Value.ToString());

                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "select zscore from zvspercentile";
                    cmd.CommandType = CommandType.Text;
                    da = new OracleDataAdapter(cmd.CommandText, conn);
                    da.Fill(ds, "Tbl_zscore");
                    dt = ds.Tables["Tbl_zscore"];

                    float percent1 = -1, percent2 = -1, percent3 = -1, percent4 = -1, percent5 = -1, percent6 = -1, percent7 = -1;
                    for (int j = 7; j <= 13; j++)
                    {
                        float min = float.MaxValue, min_zscore = float.MaxValue, min_percent = float.MaxValue;
                        float y = float.Parse(comm.Parameters[j].Value.ToString());
                        int t = (int)(y * 1000);
                        y /= 1000;
                        // MessageBox.Show("y: " + y);

                        if (y == 100)
                            continue;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            float x = float.Parse(dt.Rows[i][0].ToString());
                            //MessageBox.Show(x.ToString());
                            if (Math.Abs(x - y) < min)
                            {
                                min = Math.Abs(x - y);
                                min_zscore = x;
                            }
                        }
                        //MessageBox.Show("min_zscore" + min_zscore);
                        OracleCommand cmdSub = new OracleCommand
                        {
                            CommandText = "select percent from zvspercentile where zscore=" + min_zscore.ToString(),
                            CommandType = CommandType.Text
                        };
                        ds1 = new DataSet();
                        da1 = new OracleDataAdapter(cmdSub.CommandText, conn);
                        da1.Fill(ds1, "min_percent");
                        dt1 = ds1.Tables["min_percent"];
                        min_percent = float.Parse(dt1.Rows[0][0].ToString());

                        //MessageBox.Show(j + " " + min_percent);
                        if (j == 7)
                            percent1 = min_percent;
                        else if (j == 8)
                            percent2 = min_percent;
                        else if (j == 9)
                            percent3 = min_percent;
                        else if (j == 10)
                            percent4 = min_percent;
                        else if (j == 11)
                            percent5 = min_percent;
                        else if (j == 12)
                            percent6 = min_percent;
                        else if (j == 13)
                            percent7 = min_percent;

                    }
                    String temp = "";
                    if (percent1 != -1)
                        temp += percent1.ToString() + " ";
                    if (percent2 != -1)
                        temp += percent2.ToString() + " ";
                    if (percent3 != -1)
                        temp += percent3.ToString() + " ";
                    if (percent4 != -1)
                        temp += percent4.ToString() + " ";
                    if (percent5 != -1)
                        temp += percent5.ToString() + " ";
                    if (percent6 != -1)
                        temp += percent6.ToString() + " ";
                    if (percent7 != -1)
                        temp += percent7.ToString() + " ";

                    MessageBox.Show(temp);

                    System.Collections.ArrayList abnormalities = new System.Collections.ArrayList();
                    abnormalities.Add(new StringValue("Sample abnormality"));
                    if (percent7 < 2 || percent5 < 5)
                        abnormalities.Add(new StringValue("Short Stature"));
                    if (percent7< 2)
                        abnormalities.Add(new StringValue("Low weight-for-length"));
                    if (percent7 > 98)
                        abnormalities.Add(new StringValue("High weight-forlength"));
                    if (percent6 > 95)
                        abnormalities.Add(new StringValue("Obesity"));
                    if (percent6 > 85 && percent6 <= 95)
                        abnormalities.Add(new StringValue("Overweight"));
                    if (percent6 < 5)
                        abnormalities.Add(new StringValue("Underweight"));

                    System.Collections.ArrayList list = new System.Collections.ArrayList();
                    // if (percent1 != -1)
                    list.Add(percent1);
                    // if (percent2 != -1)
                    list.Add(percent2);
                    //if (percent3 != -1)
                    list.Add(percent3);
                    //if (percent4 != -1)
                    list.Add(percent4);
                    //if (percent5 != -1)
                    list.Add(percent5);
                    //if (percent6 != -1)
                    list.Add(percent6);
                    //if (percent7 != -1)
                    list.Add(percent7);
                    GeneratedReport f = new GeneratedReport(list, abnormalities);
                    f.Show();

                    conn.Close();
                }
            }catch(Exception ef)
            {
                Debug.WriteLine(ef.Message);
                MessageBox.Show("Something went wrong! Make sure you've entered all the details","Error!");
            }

        }

        private void RadioButtonForMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = 1;
        }

        private void RadioButtonForFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = 2;
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
    public class StringValue
    {
        public StringValue(string s)
        {
            _value = s;
        }
        public string Value { get { return _value; } set { _value = value; } }
        string _value;
    }
}
