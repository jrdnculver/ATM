using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ATM
{
    public class Database
    {
        public static List<Accounts> ActiveAccounts = new List<Accounts>();
        public List<Accounts> getAccounts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ATM")))
            {
                return connection.Query<Accounts>($"select * from Accounts").ToList();
            }
        }

        public void saveNewAccount()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ATM")))
            {
                connection.Execute($"insert into Accounts (FirstName, LastName, AccountNumber, AccountPin, AccountBalance) values ('{primary.createUser.FirstName}','{primary.createUser.LastName}','{primary.createUser.AccountNumber}',{primary.createUser.AccountPin},{primary.createUser.AccountBalance})");
            }
        }

        public void saveTransaction()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ATM")))
            {
                connection.Execute($"update Accounts set Accountbalance = {primary.transfer.RemainingBalance} where AccountNumber = '{primary.transfer.AccountNumber}'");
            }
        }

        public void savePin()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ATM")))
            {
                connection.Execute($"update Accounts set AccountPin = {primary.change.NewPin} where AccountNumber = '{primary.userAccount.AccountNumber}'");
            }
        }

        public void createDatabase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("Master")))
            {
                try
                {
                    connection.Execute("create database ATM;");
                }
                catch
                {
                    ;
                }
            }
        }

        public void createTable()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ATM")))
            {
                try
                {
                    connection.Execute("create table Accounts (FirstName varchar(25), LastName varchar(25), AccountNumber varchar(16), AccountPin int, AccountBalance decimal(9,2));");
                }
                catch
                {
                    ;
                }
            }
        }
    }
}
