using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ATM
{
    public class NewAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public int AccountPin { get; set; }
        public decimal AccountBalance { get; set; }

        public void createNewAccount()
        {
            bool canCreate = true;

            try
            {
                FirstName = newAccount.createAccount.firstNameTxt.Text.Trim();
                LastName = newAccount.createAccount.lastNameTxt.Text.Trim();

                Regex emptyString = new Regex("^(?![\\s\\S])");

                if (emptyString.IsMatch(FirstName))
                {
                    canCreate = false;
                    throw new ATMException("First Name Can Not Be Empty");
                }
                
                if (emptyString.IsMatch(LastName))
                {
                    canCreate = false;
                    throw new ATMException("Last Name Can Not Be Empty");
                }

                string pinn = newAccount.createAccount.pinTxt.Text.Trim();

                Regex four = new Regex("^\\d\\d\\d\\d$");

                Regex isNumbers = new Regex("^\\d+$");

                if (four.IsMatch(pinn))
                {
                    AccountPin = int.Parse(newAccount.createAccount.pinTxt.Text.Trim());
                }
                else
                {
                    canCreate = false;
                    throw new ATMException("Pin Must Be Four Digits");
                }
        
                string balance = newAccount.createAccount.depositTxt.Text.Trim();

                decimal hundred = 100.00M;

                Regex dollar = new Regex("[0-9]+.\\d\\d");

                if (dollar.IsMatch(balance))
                {
                    AccountBalance = decimal.Parse(newAccount.createAccount.depositTxt.Text.Trim());
                    if (AccountBalance < hundred)
                    {
                        canCreate = false;
                        throw new ATMException("Money Deposit Must Be Over $100.00");
                    }
                }
                else
                {
                    canCreate = false;
                    throw new ATMException("Money Deposit Must Be Format #.##");
                }

            }
            catch(ATMException ex)
            {
                newAccount.createAccount.userUpdateLbl.Text = ex.Message;
            }

            if (canCreate == true)
            {
                createAccountNumber();

                primary.db.saveNewAccount();

                newAccount.createAccount.createdAccountInfoTxt.Text = primary.createUser.presentUser("*****USER CREATED*****").ToString();
            }
        }

        public void createAccountNumber()
        {
            StringBuilder accountNumber = new StringBuilder();

            Random rnd = new Random();

            string entryNumber = "2345";
            accountNumber.Append(entryNumber);
  
            int num;
            for(int i = 0; i < 12; i++) {

                num = rnd.Next(0, 9);

                accountNumber.Append(num);
            }

            AccountNumber = accountNumber.ToString();
            validateAccountNumber();

        }

        public void validateAccountNumber()
        {
            foreach (Accounts account in Database.ActiveAccounts)
            {
                if (AccountNumber == account.AccountNumber)
                {
                    createAccountNumber();
                }
            }
        }

        public StringBuilder presentUser(string createString)
        {
            StringBuilder user = new StringBuilder();
            user.AppendLine(createString);
            user.AppendLine("              WELCOME!!              ");
            user.AppendLine($"Account Number: {AccountNumber}");
            user.AppendLine($"First Name: {FirstName}");
            user.AppendLine($"Last Name: {LastName}");
            user.AppendLine($"Account Balance: {AccountBalance:C}");

            return user;
        }

        public void clearContent()
        {
            newAccount.createAccount.firstNameTxt.Text = newAccount.createAccount.lastNameTxt.Text = newAccount.createAccount.pinTxt.Text = newAccount.createAccount.depositTxt.Text = "";
        }
    }
}
