using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ATM
{
    public class Accounts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public int AccountPin { get; set; }
        public decimal AccountBalance { get; set; }

        public void getNames()
        {
            primary.Primary.userStatusLbl.Text = "Enter Information";

            try
            {
                primary.userAccount.FirstName = capitalize(primary.Primary.firstNameTxtBox.Text.Trim());

                primary.userAccount.LastName = capitalize(primary.Primary.lastNameTxtBox.Text.Trim());

                if (primary.userAccount.FirstName == String.Empty)
                {
                    throw new ATMException("Enter Your First Name");
                }
                else if (primary.userAccount.LastName == string.Empty)
                {
                    throw new ATMException("Enter Your Last Name");
                }
                else
                {
                    primary.Primary.Hide();

                    primary.account.clearPrimary();

                    pin.Pin.Show();
                }
            }
            catch(ATMException ex)
            {
                primary.Primary.userStatusLbl.Text = ex.Message;
            }
  
        }

        public void getPin()
        {
            string pinn;

            pinn = pin.Pin.pinTxtBox.Text;

            Regex four = new Regex("^\\d\\d\\d\\d$");
            Regex isNumbers = new Regex("^\\d+$");

            try
            {
                if (isNumbers.IsMatch(pinn))
                {
                    if (four.IsMatch(pinn))
                    {
                        primary.userAccount.AccountPin = int.Parse(pin.Pin.pinTxtBox.Text);

                        bool isValid = primary.account.checkValidAccount();

                        if (isValid)
                        {
                            sortPathway();
                        }
                        else
                        {
                            primary.Primary.userStatusLbl.Text = "Invalid Name or Pin";

                            pin.Pin.Hide();

                            primary.change.pinClears();

                            primary.Primary.Show();
                        }
                    }
                    else
                    {
                        throw new ATMException("Pin Must Be Four Digits");
                    }
                }
                else
                {
                    throw new ATMException("Pin Must Be A Number");
                }
            }
            catch(ATMException ex)
            {
                pin.Pin.userStatusLbl.Text = ex.Message;
            }
        }

        public bool checkValidAccount()
        {
            bool isFound = false;
            foreach (Accounts account in Database.ActiveAccounts)
            {
                bool firstName = primary.userAccount.FirstName == account.FirstName;
                bool lastName = primary.userAccount.LastName == account.LastName;
                bool accountPin = primary.userAccount.AccountPin == account.AccountPin;

                if (firstName && lastName && accountPin)
                {
                    primary.userAccount.AccountNumber = account.AccountNumber;
                    primary.userAccount.AccountBalance = account.AccountBalance;
                    return isFound = true;
                }
                else
                {
                    continue;
                }
            }
            return isFound;
        }

        public void sortPathway()
        {
            switch (primary.pathway)
            {
                case 1:
                    bool isFound = primary.account.checkValidAccount();

                    primary.account.accountSummaryFound(isFound);

                    primary.Primary.Show();

                    break;
                case 2:
                    transfer.Money.Show();

                    break;
                case 3:
                    keypad.Transfer.Show();

                    break;
                case 4:
                    changepin.PinChange.Show();

                    break;
                default:
                    ;
                    break;
            }

            pin.Pin.Hide();

            primary.change.pinClear();

            primary.change.pinClears();
        }

        public void accountSummaryFound(bool isFound)
        {
            if (isFound == true)
            {
                stringBuiltSummary("*****ACCOUNT SUMMARY*****");
            }
            else
            {
                primary.Primary.userStatusLbl.Text = "Account Access Denied";
            }
        }

        public void transactionSummary(bool isFound)
        {
            if (isFound == true && primary.pathway == 2)
            {
                stringBuilt("*****WITHDRAW*****");
            }
            else if (isFound == true && primary.pathway == 3)
            {
                stringBuilt("*****DEPOSIT*****");
            }
            else
            {
                primary.Primary.userStatusLbl.Text = "Account Access Denied";
            }
        }

        public void clearPrimary()
        {
            primary.Primary.atmTxtBx.Text = primary.Primary.firstNameTxtBox.Text = primary.Primary.lastNameTxtBox.Text = "";

            primary.Primary.userStatusLbl.Text = "Please Enter Your Name";
        }

        public void stringBuiltSummary(string summary)
        {
            primary.Primary.userStatusLbl.Text = "Account Access Granted";

            StringBuilder accountSummary = new StringBuilder();
            accountSummary.AppendLine($"{summary}");
            accountSummary.AppendLine($"Account #: {primary.userAccount.AccountNumber}");
            accountSummary.AppendLine($"First Name: {primary.userAccount.FirstName}");
            accountSummary.AppendLine($"Last Name: {primary.userAccount.LastName}");
            accountSummary.AppendLine($"Account Bal: {primary.userAccount.AccountBalance:C}");

            primary.Primary.atmTxtBx.Text = accountSummary.ToString();
        }

        public void stringBuilt(string transactionType)
        {
            primary.Primary.userStatusLbl.Text = "Account Access Granted";

            StringBuilder withdrawSummary = new StringBuilder();
            withdrawSummary.AppendLine($"{transactionType}");
            withdrawSummary.AppendLine($"Account #: {primary.transfer.AccountNumber}");
            withdrawSummary.AppendLine($"First Name: {primary.transfer.FirstName}");
            withdrawSummary.AppendLine($"Last Name: {primary.transfer.LastName}");
            withdrawSummary.AppendLine($"Previous Bal: {primary.transfer.AccountBalance:C}");
            withdrawSummary.AppendLine($"Transfer Amt: {primary.transfer.TransferAmount:C}");
            withdrawSummary.AppendLine($"Remaining Bal: {primary.transfer.RemainingBalance:C}");

            primary.Primary.atmTxtBx.Text = withdrawSummary.ToString();
        }

        public string capitalize(string word)
        {
            if (word != string.Empty)
            {
                string first = word.Substring(0, 1);

                string last = word.Substring(1, word.Length - 1);

                StringBuilder fuse = new StringBuilder();

                fuse.Append(first.ToUpper());

                fuse.Append(last);

                return fuse.ToString();
            }

            return string.Empty;
        }
    }
}
