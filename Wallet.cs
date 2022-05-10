using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Wallet : Person
    {
        private double _walletFunds;
        private double _price;
        public Wallet(string name, int age, double walletMoney, double prices) : base(name, age)
        {
            name = "Steven ";
            age = 21;
            _walletFunds = walletMoney;
            _price = prices;


        }
        public void PrintMessage()
        {
            double wallet = WalletFunds();
            double price = Price();
            IsBalance(wallet, price);

        }
        public static double WalletFunds()
        {
            double wallet = 100.0;
            return wallet;
        }
        public static double Price()
        {
            double price = 25.50;
            return price;
        }
        public static bool IsBalance(double wallet, double price)
        {
            bool expression = false;
            if (wallet > price)
            {
                expression = true;
                wallet -= price;

                Console.WriteLine(wallet);
            }
            else if (wallet < price)
            {
                return false;
            }

            return expression;
        }
        public double WalletMoney { get { return _walletFunds; } }
        public double Prices { get { return _price; } }
    }
}
