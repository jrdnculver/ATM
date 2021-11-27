using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ATM
{
    public class ChangePin
    {
        public string AccountNumber { get; set; }
        public int ExistingPin { get; set; }
        public int NewPin { get; set; }

        public void getPins()
        {
            try
            {
                string pinn = changepin.PinChange.newPinTxt.Text;

                Regex four = new Regex("^\\d\\d\\d\\d$");
                Regex isNumbers = new Regex("^\\d+$");

                if (isNumbers.IsMatch(pinn)){

                    if (four.IsMatch(pinn))
                    {
                        NewPin = int.Parse(pinn);

                        primary.db.savePin();

                        primary.Primary.userStatusLbl.Text = "Pin Change Successful";

                    }
                    else 
                    {
                        throw new ATMException("This Number Must Be Four Digits");
                    }
                }
                else
                {
                    throw new ATMException("This Must Be A Four Digit Number");
                }
            }
            catch(ATMException ex)
            {
                primary.Primary.userStatusLbl.Text = ex.Message;
            }
        }

        public void getAccountNumber()
        {
            try
            {
                AccountNumber = primary.userAccount.AccountNumber;

                if (AccountNumber == string.Empty)
                {
                    throw new ATMException("This Account Number is Null");
                }
            }
            catch
            {
                ;////////////////////////////////////////////////////////////
            }
            
        }

        public void assignNumber(string number)
        {
            changepin.pinAccessOne = primary.pinpad.assignButton(changepin.pinAccessOne,number);
            changepin.PinChange.newPinTxt.Text = changepin.pinAccessOne.ToString();
        }

        public void pinClear()
        {
            pin.Pin.pinTxtBox.Text = changepin.PinChange.newPinTxt.Text = "";
        }

        public void pinClears()
        {
            pin.Pin.pinTxtBox.Text = pin.Pin.userStatusLbl.Text = string.Empty;
        }
    }
}
