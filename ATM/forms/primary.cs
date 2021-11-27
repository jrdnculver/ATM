using ATM.classes;
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
    // Primary Form
    public partial class primary : Form
    {
        public static primary Primary;
        public static Accounts account = new Accounts();
        public static Database db = new Database();
        public static ActiveUser userAccount = new ActiveUser();
        public static NewAccount createUser = new NewAccount();
        public static transferMoney transfer = new transferMoney();
        public static KeyPad keypad = new KeyPad();
        public static ChangePin change = new ChangePin();
        public static PinPad pinpad = new PinPad();
        public static PrintTransaction printer = new PrintTransaction();
        public static int pathway {get; set;}

        public primary()
        {
            InitializeComponent();

            Primary = this;

            db.createDatabase();

            db.createTable();
        }

        private void newAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            account.clearPrimary();

            newAccount.createAccount.Show();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            pathway = 1;

            Database.ActiveAccounts = db.getAccounts();

            account.getNames();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            pathway = 2;

            Database.ActiveAccounts = db.getAccounts();

            account.getNames();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            pathway = 3;

            Database.ActiveAccounts = db.getAccounts();

            account.getNames();
           
        }

        private void pinBtn_Click(object sender, EventArgs e)
        {
            pathway = 4;

            Database.ActiveAccounts = db.getAccounts();

            account.getNames();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            account.clearPrimary();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            printer.getPrintSummary();
        }
    }
}
