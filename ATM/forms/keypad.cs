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
    public partial class keypad : Form
    {
        public static keypad Transfer = new keypad();

        public StringBuilder numberAmount;

        public bool calcUsed { get; set; } = false;

        public keypad()
        {
            InitializeComponent();

            var form = this;

            primary.keypad.initializeKeyPad(form);

        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            primary.keypad.pressOne(form);
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            primary.keypad.pressTwo(form);
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            primary.keypad.pressThree(form);
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            primary.keypad.pressFour(form);
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            primary.keypad.pressFive(form);
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            primary.keypad.pressSix(form);
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            primary.keypad.pressSeven(form);
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            primary.keypad.pressEight(form);
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            primary.keypad.pressNine(form);
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            primary.keypad.pressZero(form);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            primary.keypad.pressClear(form);
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            var form = Transfer;

            decimal dollar = primary.keypad.pressEnter(form);
            
            primary.transfer.performTransaction(dollar);

            primary.keypad.pressClear(form);

            this.Hide();

            primary.Primary.Show();
        }
    }
}
