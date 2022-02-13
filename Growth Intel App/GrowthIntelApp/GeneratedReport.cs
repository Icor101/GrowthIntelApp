using System;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class GeneratedReport : Form
    {
        private readonly ArrayList arrList;
        private readonly ArrayList abnormalities1;

        public GeneratedReport(ArrayList list,ArrayList abnormalities)
        {
            arrList = list;
            abnormalities1 = abnormalities;
            InitializeComponent();
            this.chart1.Series["Percentile"].Points.AddXY("Weight-For-Age", (float)arrList[0] == -1 ? (float)arrList[0] + 1 : arrList[0]);
            this.chart1.Series["Percentile"].Points.AddXY("Length-For-Age", (float)arrList[1] == -1 ? (float)arrList[1] + 1 : arrList[1]);
            this.chart1.Series["Percentile"].Points.AddXY("HC-For-Age", (float)arrList[2] == -1 ? (float)arrList[2] + 1 : arrList[2]);
            this.chart1.Series["Percentile"].Points.AddXY("Weight-For-Stature", (float)arrList[3] == -1 ? (float)arrList[3] + 1 : arrList[3]);
            this.chart1.Series["Percentile"].Points.AddXY("Stature-For-Age", (float)arrList[4] == -1 ? (float)arrList[4] + 1 : arrList[4]);
            this.chart1.Series["Percentile"].Points.AddXY("BMI-For-Age", (float)arrList[5] == -1 ? (float)arrList[5] + 1 : arrList[5]);
            this.chart1.Series["Percentile"].Points.AddXY("Weight-For-Length", (float)arrList[6] == -1 ? (float)arrList[6] + 1 : arrList[6]);
            this.chart1.Series["Normal"].Points.AddXY("", 70);
            this.chart1.Series["Normal"].Points.AddXY("", 85);
            this.chart1.Series["Normal"].Points.AddXY("", 70);
            this.chart1.Series["Normal"].Points.AddXY("", 77);
            this.chart1.Series["Normal"].Points.AddXY("", 55);
            this.chart1.Series["Normal"].Points.AddXY("", 70);
            this.chart1.Series["Normal"].Points.AddXY("", 81);

            dataGridView1.DataSource = abnormalities1;
            if(abnormalities1.Count>0)
                dataGridView1.Columns[0].HeaderText = "Abnormalities";
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
