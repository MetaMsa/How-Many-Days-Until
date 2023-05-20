using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace How_many_days_until
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CALCULATE_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime TheDay = dateTimePicker1.Value;

            TimeSpan ts = TheDay - today;
            textBox1.Text = ts.Days.ToString() + "DAYS";
        }
    }
}
