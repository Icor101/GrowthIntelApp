using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        ArrayList List1,abnormalities1;
        public Form2(ArrayList list,ArrayList abnormalities)
        {
            List1 = list;
            abnormalities1 = abnormalities;
            InitializeComponent();
            this.chart1.Series["Percentile"].Points.AddXY("Weight-For-Age", (float)List1[0] == -1 ? (float)List1[0] + 1 : List1[0]);
            this.chart1.Series["Percentile"].Points.AddXY("Length-For-Age", (float)List1[1] == -1 ? (float)List1[1] + 1 : List1[1]);
            this.chart1.Series["Percentile"].Points.AddXY("HC-For-Age", (float)List1[2] == -1 ? (float)List1[2] + 1 : List1[2]);
            this.chart1.Series["Percentile"].Points.AddXY("Weight-For-Stature", (float)List1[3] == -1 ? (float)List1[3] + 1 : List1[3]);
            this.chart1.Series["Percentile"].Points.AddXY("Stature-For-Age", (float)List1[4] == -1 ? (float)List1[4] + 1 : List1[4]);
            this.chart1.Series["Percentile"].Points.AddXY("BMI-For-Age", (float)List1[5] == -1 ? (float)List1[5] + 1 : List1[5]);
            this.chart1.Series["Percentile"].Points.AddXY("Weight-For-Length", (float)List1[6] == -1 ? (float)List1[6] + 1 : List1[6]);
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
