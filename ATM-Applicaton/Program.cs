using System;
using System.Collections.Generic;
using ATMApplicaton.Properties;

namespace ATMApplicaton
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Create users
            User userOne = new User(1234, "Zakaria Merfouk", 5052.12);
            User userTwo = new User(2345, "John Doe", 4512.45);
            User userThree = new User(3456, "Lionel Messi", 28355456.41);
            Console.WriteLine(userOne.UserName);

            //User Verfication
            List<User> users = new List<User>();
            users.Add(userOne);
            users.Add(userTwo);
            users.Add(userThree);
            Console.WriteLine("Enter Pin");
            int enteredPin = Convert.ToInt32(Console.ReadLine());

            IsPinValid(users, enteredPin);
        }

        private static void IsPinValid(List<User> users, int enteredPin)
        {
            bool validUser = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].ValidatePin(enteredPin))
                {
                    validUser = true;
                    //message = $"Hello {users[i].UserName}";
                    //Console.WriteLine(message);
                    //Console.WriteLine("1. Check your balance\n" +
                    //    "2. Withdraw\n" +
                    //    "3. Deposit"
                    // );
                    //int enteredOption = int.Parse(Console.ReadLine());
                    //switch (enteredOption)
                    //{
                    //    case 1:
                    //        Console.WriteLine($"Your current balance is ${users[i].Balance}");
                    //        break;
                    //    case 2:
                    //        Console.WriteLine("Withdraw Amount");
                    //        int withdrawAmount = int.Parse(Console.ReadLine());
                    //        users[i].Balance -= withdrawAmount;
                    //        Console.WriteLine($"Your current balance is ${users[i].Balance}");
                    //        break;
                    //    case 3:
                    //        Console.WriteLine("Deposit Amount");
                    //        int depositAmount = int.Parse(Console.ReadLine());
                    //        users[i].Balance += depositAmount;
                    //        Console.WriteLine($"Your current balance is ${users[i].Balance}");
                    //        break;
                    //    default:
                    //        Console.WriteLine("Option is not valid");
                    //        break;
                    //}
                }


                if (validUser)
                {
                    Console.WriteLine($"Hello {users[i].UserName}");
                    Console.WriteLine("1. Check your balance\n" +
                        "2. Withdraw\n" +
                        "3. Deposit"
                     );
                    int enteredOption = int.Parse(Console.ReadLine());
                    switch (enteredOption)
                    {
                        case 1:
                            Console.WriteLine($"Your current balance is ${users[i].Balance}");
                            break;
                        case 2:
                            Console.WriteLine("Withdraw Amount");
                            int withdrawAmount = int.Parse(Console.ReadLine());
                            users[i].Balance -= withdrawAmount;
                            Console.WriteLine($"Your current balance is ${users[i].Balance}");
                            break;
                        case 3:
                            Console.WriteLine("Deposit Amount");
                            int depositAmount = int.Parse(Console.ReadLine());
                            users[i].Balance += depositAmount;
                            Console.WriteLine($"Your current balance is ${users[i].Balance}");
                            break;
                        default:
                            Console.WriteLine("Option is not valid");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid user");
                }
            }
            
        }
    }
}
