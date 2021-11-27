using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class transferMoney
    {
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal TransferAmount { get; set; }
        public decimal RemainingBalance { get; set; }

        public bool declareTransaction(decimal dollar)
        {
            bool greaterThanZero;

            AccountNumber = primary.userAccount.AccountNumber;
            FirstName = primary.userAccount.FirstName;
            LastName = primary.userAccount.LastName;
            AccountBalance = primary.userAccount.AccountBalance;
            TransferAmount = dollar;
            if (primary.pathway == 2)
            {
                RemainingBalance = AccountBalance - TransferAmount;
                return greaterThanZero = RemainingBalance >= 0;
            }
            else
            {
                RemainingBalance = AccountBalance + TransferAmount;
                return greaterThanZero = RemainingBalance >= 0;
            }
        }

        public void performTransaction(decimal dollar)
        {
            bool isFound = primary.account.checkValidAccount();

            bool greaterThanZero = primary.transfer.declareTransaction(dollar);

            switch (greaterThanZero)
            {
                case true:
                    primary.db.saveTransaction();

                    primary.account.transactionSummary(isFound);
                    break;
                default:

                    primary.Primary.userStatusLbl.Text = "You Have Insufficient Funds";

                    break;
            }
        }
    }
}
