using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class KeyPad
    {

        public void initializeKeyPad(keypad form)
        {
            form.numberAmount = new StringBuilder();

            form.numberAmount.Append($"{0}");

            decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

            form.depositTxt.Text = moneyValue.ToString("C");
        }
        public void pressOne(keypad form)
        {
            if (!form.calcUsed)
            {
                form.numberAmount.Clear();

                form.numberAmount.Append($"{1}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");

                form.calcUsed = true;
            }
            else
            {
                form.numberAmount.Append($"{1}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");
            }
        }

        public void pressTwo(keypad form)
        {
            if (!form.calcUsed)
            {
                form.numberAmount.Clear();

                form.numberAmount.Append($"{2}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");

                form.calcUsed = true;
            }
            else
            {
                form.numberAmount.Append($"{2}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");
            }
        }

        public void pressThree(keypad form)
        {
            if (!form.calcUsed)
            {
                form.numberAmount.Clear();

                form.numberAmount.Append($"{3}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");

                form.calcUsed = true;
            }
            else
            {
                form.numberAmount.Append($"{3}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");
            }
        }

        public void pressFour(keypad form)
        {
            if (!form.calcUsed)
            {
                form.numberAmount.Clear();

                form.numberAmount.Append($"{4}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");

                form.calcUsed = true;
            }
            else
            {
                form.numberAmount.Append($"{4}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");
            }
        }

        public void pressFive(keypad form)
        {
            if (!form.calcUsed)
            {
                form.numberAmount.Clear();

                form.numberAmount.Append($"{5}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");

                form.calcUsed = true;
            }
            else
            {
                form.numberAmount.Append($"{5}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");
            }
        }

        public void pressSix(keypad form)
        {
            if (!form.calcUsed)
            {
                form.numberAmount.Clear();

                form.numberAmount.Append($"{6}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");

                form.calcUsed = true;
            }
            else
            {
                form.numberAmount.Append($"{6}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");
            }
        }

        public void pressSeven(keypad form)
        {
            if (!form.calcUsed)
            {
                form.numberAmount.Clear();

                form.numberAmount.Append($"{7}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");

                form.calcUsed = true;
            }
            else
            {
                form.numberAmount.Append($"{7}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");
            }
        }

        public void pressEight(keypad form)
        {
            if (!form.calcUsed)
            {
                form.numberAmount.Clear();

                form.numberAmount.Append($"{8}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");

                form.calcUsed = true;
            }
            else
            {
                form.numberAmount.Append($"{8}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");
            }
        }

        public void pressNine(keypad form)
        {
            if (!form.calcUsed)
            {
                form.numberAmount.Clear();

                form.numberAmount.Append($"{9}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");

                form.calcUsed = true;
            }
            else
            {
                form.numberAmount.Append($"{9}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");
            }
        }

        public void pressZero(keypad form)
        {
            if (!form.calcUsed)
            {
                form.numberAmount.Clear();

                form.numberAmount.Append($"{0}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");

                form.calcUsed = true;
            }
            else
            {
                form.numberAmount.Append($"{0}");

                decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

                form.depositTxt.Text = moneyValue.ToString("C");
            }
        }


        public void pressClear(keypad form)
        {
            form.calcUsed = false;

            form.numberAmount.Clear();

            form.numberAmount.Append($"{0}");

            decimal moneyValue = decimal.Parse(form.numberAmount.ToString());

            form.depositTxt.Text = moneyValue.ToString("C");
        }

        public decimal pressEnter(keypad form)
        {
            decimal dollar = decimal.Parse(form.numberAmount.ToString());

            return dollar;
        }
    }
}
