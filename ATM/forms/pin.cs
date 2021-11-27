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
    public partial class pin : Form
    {
        public static pin Pin = new pin();

        public static StringBuilder EnterPin = new StringBuilder();

        public pin()
        {
            InitializeComponent();
            Pin = this;
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            string number = "1";
            StringBuilder pass = EnterPin;
            EnterPin = primary.pinpad.assignButton(pass, number);
            pinTxtBox.Text = EnterPin.ToString();
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            string number = "2";
            StringBuilder pass = EnterPin;
            EnterPin = primary.pinpad.assignButton(pass, number);
            pinTxtBox.Text = EnterPin.ToString();
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            string number = "3";
            StringBuilder pass = EnterPin;
            EnterPin = primary.pinpad.assignButton(pass, number);
            pinTxtBox.Text = EnterPin.ToString();
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            string number = "4";
            StringBuilder pass = EnterPin;
            EnterPin = primary.pinpad.assignButton(pass, number);
            pinTxtBox.Text = EnterPin.ToString();
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            string number = "5";
            StringBuilder pass = EnterPin;
            EnterPin = primary.pinpad.assignButton(pass, number);
            pinTxtBox.Text = EnterPin.ToString();
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            string number = "6";
            StringBuilder pass = EnterPin;
            EnterPin = primary.pinpad.assignButton(pass, number);
            pinTxtBox.Text = EnterPin.ToString();
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            string number = "7";
            StringBuilder pass = EnterPin;
            EnterPin = primary.pinpad.assignButton(pass, number);
            pinTxtBox.Text = EnterPin.ToString();
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            string number = "8";
            StringBuilder pass = EnterPin;
            EnterPin = primary.pinpad.assignButton(pass, number);
            pinTxtBox.Text = EnterPin.ToString();
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            string number = "9";
            StringBuilder pass = EnterPin;
            EnterPin = primary.pinpad.assignButton(pass, number);
            pinTxtBox.Text = EnterPin.ToString();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            string number = "0";
            StringBuilder pass = EnterPin;
            EnterPin = primary.pinpad.assignButton(pass, number);
            pinTxtBox.Text = EnterPin.ToString();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            primary.account.getPin();

            EnterPin.Clear();
        }

        private void menuBtn_Click_1(object sender, EventArgs e)
        {
            primary.Primary.Show();

            primary.change.pinClears();

            this.Hide();
        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            primary.change.pinClears();

            EnterPin.Clear();
        }
    }
}
