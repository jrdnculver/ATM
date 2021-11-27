using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class transfer : Form
    {
        public static transfer Money = new transfer();
        public transfer()
        {
            InitializeComponent();
            Money = this;
        }

        private void tenButton_Click(object sender, EventArgs e)
        {
            decimal dollar = 10;

            primary.transfer.performTransaction(dollar);

            this.Hide();

            primary.Primary.Show();
        }

        private void twentyBtn_Click(object sender, EventArgs e)
        {
            decimal dollar = 20;

            primary.transfer.performTransaction(dollar);

            this.Hide();

            primary.Primary.Show();
        }

        private void thirtyBtn_Click(object sender, EventArgs e)
        {
            decimal dollar = 30;

            primary.transfer.performTransaction(dollar);

            this.Hide();

            primary.Primary.Show();
        }

        private void fourtyBtn_Click(object sender, EventArgs e)
        {
            decimal dollar = 40;

            primary.transfer.performTransaction(dollar);

            this.Hide();

            primary.Primary.Show();
        }

        private void fiftyBtn_Click(object sender, EventArgs e)
        {
            decimal dollar = 50;

            primary.transfer.performTransaction(dollar);

            this.Hide();

            primary.Primary.Show();
        }

        private void hundredBtn_Click(object sender, EventArgs e)
        {
            decimal dollar = 100;

            primary.transfer.performTransaction(dollar);

            this.Hide();

            primary.Primary.Show();
        }

        private void twoHundredBtn_Click(object sender, EventArgs e)
        {
            decimal dollar = 200;

            primary.transfer.performTransaction(dollar);

            this.Hide();

            primary.Primary.Show();
        }

        private void otherBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            keypad.Transfer.Show();
        }
    }
}
