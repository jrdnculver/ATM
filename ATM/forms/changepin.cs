using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class changepin : Form
    {
        public static changepin PinChange = new changepin();

        public static StringBuilder pinAccessOne = new StringBuilder();

        public static int selected { get; set; }
        public changepin()
        {
            InitializeComponent();
            PinChange = this;
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            string number = "1";
            primary.change.assignNumber(number);
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            string number = "2";
            primary.change.assignNumber(number);
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            string number = "3";
            primary.change.assignNumber(number);
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            string number = "4";
            primary.change.assignNumber(number);
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            string number = "5";
            primary.change.assignNumber(number);
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            string number = "6";
            primary.change.assignNumber(number);
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            string number = "7";
            primary.change.assignNumber(number);
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            string number = "8";
            primary.change.assignNumber(number);
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            string number = "9";
            primary.change.assignNumber(number);
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            string number = "0";
            primary.change.assignNumber(number);
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            primary.change.getPins();

            primary.account.checkValidAccount();

            primary.change.getAccountNumber();

            this.Hide();

            primary.Primary.Show();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            primary.change.pinClear();

            primary.pinpad.stringClear();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            primary.Primary.Show();
        }
    }
}
