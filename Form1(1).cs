using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Home_Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int weeks = int.Parse(textBox1.Text);
            int months = int.Parse(textBox2.Text);
            int years = int.Parse(textBox3.Text);

            label4.Text = "Количество дней: " + ((weeks * 7) + (months * 30) + (years * 360));
        }
    }
}
