using System;
namespace ATMApplicaton.Properties
{
    public class User
    {
        private int pinNumber;
        private string userName;
        private double balance;

        public int PinNumber
        {
            get
            {
                return pinNumber;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public User(int pin, string name, double availableBalance)
        {
            pinNumber = pin;
            userName = name;
            balance = availableBalance;
        }

        public void Print()
        {
            Console.WriteLine($"Hello {userName}");
        }

        public bool ValidatePin(int pin)
        {
            if(pin == pinNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
