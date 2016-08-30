using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Okienko : Form
    {

        int count = 0;
        bool done = false;
        bool fizzrequired = false;
        bool buzzrequired = false;


        public Okienko()
        {
            InitializeComponent();
        }

        public void IncreaseCount()
        {
            count++;
            buzzrequired = ((count % 3 == 0) || (("" + count).Contains("3")));
            fizzrequired = ((count % 7 == 0) || (("" + count).Contains("7")));
        }
        public void Error()
        {
            done = true;
            label1.Text = "Oops!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (done) return;
            if (!fizzrequired || buzzrequired)
            {
                Error();
                return;
            }
            label1.Text = "Fizz";
            IncreaseCount();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (done) return;
            if (fizzrequired || buzzrequired)
            {
                Error();
                return;
            }
            label1.Text = count.ToString();
            IncreaseCount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (done) return;
            if (fizzrequired || !buzzrequired)
            {
                Error();
                return;
            }
            label1.Text = "Buzz";
            IncreaseCount();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (done) return;
            if (!fizzrequired || !buzzrequired)
            {
                Error();
                return;
            }
            label1.Text ="FizzBuzz";
            IncreaseCount();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count = 0;
            done = false;
            IncreaseCount();
            label1.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
