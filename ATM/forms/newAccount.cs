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
    public partial class newAccount : Form
    {
        public static newAccount createAccount = new newAccount();
        public newAccount()
        {
            InitializeComponent();

            createAccount = this;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            primary.createUser.createNewAccount();   
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            primary.createUser.clearContent();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            newAccount.createAccount.createdAccountInfoTxt.Text = "";

            this.Hide();

            primary.Primary.Show();
        }
    }
}
