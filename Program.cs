// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Net.NetworkInformation;

namespace Project_Final
{
    class program
    {
        static void Main(string[] args)
        {
            program task = new program();
            task.store_data();
            task.read_data();
            Console.ReadKey();
        }
        public void store_data()
        {
            StreamWriter acc = new StreamWriter("Accounts.txt");
            int[] acount_nums = { 123456789, 987654321, 135791113, 246810121 };
            acc.WriteLine("---------ACCOUNT NUMBERS---------");
            foreach (int num in acount_nums)
            {
                acc.WriteLine(num);
            }
            StreamWriter Pin = new StreamWriter("Accounts_Pins.txt");
            Pin.WriteLine("---------ACCOUNT PINS---------");
            int[] pins = { 1122, 3344, 5566, 7788 };
            foreach (int num in pins)
            {
                Pin.WriteLine(num);
            }
            StreamWriter bal = new StreamWriter("Accounts_Balance.txt");
            bal.WriteLine("---------ACCOUNT BALANCE---------");
            int[] balance = { 10000, 20000, 30000, 50000 };
            foreach (int num in balance)
            {
                bal.WriteLine(num);
            }
            acc.Close();
            Pin.Close();
            bal.Close();
        }
        public void read_data()
        {
            StreamReader file = new StreamReader("Accounts.txt");
            int count1 = 0;
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            string ln1;
            while ((ln1 = file.ReadLine()) != null)
            {
                if (ln1 == "123456789")
                {
                    a1 = int.Parse(ln1);
                }
                else if (ln1 == "987654321")
                {
                    a2 = int.Parse(ln1);
                }
                else if (ln1 == "135791113")
                {
                    a3 = int.Parse(ln1);
                }
                else if (ln1 == "246810121")
                {
                    a4 = int.Parse(ln1);
                }
                count1++;
            }
            StreamReader file1 = new StreamReader("Accounts_Pins.txt");
            int count2 = 0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            string ln2;
            while ((ln2 = file1.ReadLine()) != null)
            {
                if (ln2 == "1122")
                {
                    p1 = int.Parse(ln2);
                }
                else if (ln2 == "3344")
                {
                    p2 = int.Parse(ln2);
                }
                else if (ln2 == "5566")
                {
                    p3 = int.Parse(ln2);
                }
                else if (ln2 == "7788")
                {
                    p4 = int.Parse(ln2);
                }
                count2++;
            }
            StreamReader file2 = new StreamReader("Accounts_Balance.txt");
            int count3 = 0;
            int b1 = 0;
            int b2 = 0;
            int b3 = 0;
            int b4 = 0;
            string ln3;
            while ((ln3 = file2.ReadLine()) != null)
            {
                if (ln3 == "10000")
                {
                    b1 = int.Parse(ln3);
                }
                else if (ln3 == "20000")
                {
                    b2 = int.Parse(ln3);
                }
                else if (ln3 == "30000")
                {
                    b3 = int.Parse(ln3);
                }
                else if (ln3 == "50000")
                {
                    b4 = int.Parse(ln3);
                }
                count3++;
            }
            int newbalance = 0;
            Console.WriteLine("Enter Your Account Number : ");
            int user_acc_num = int.Parse(Console.ReadLine());
            if (a1 == user_acc_num)
            {
                Console.WriteLine("Please Enter Your PIN :");
                int user_pin = int.Parse(Console.ReadLine());
                for (int j = 0; j < 4; j++)
                {
                    if (user_pin == p1)
                    {
                        Console.WriteLine("SELECT FROM FOLLOWING OPTIONS :");
                        Console.WriteLine(" 1. CASH WITHDRAWAL\n 2. FAST CASH\n 3. BALANCE INQUIRY\n 4. DEPOSIT\n 5. CHANGE PIN\n 6. EXIT");
                        char ch = char.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case '1':
                                Console.WriteLine("Enter the amount to withdraw");
                                int withdraw_amt = int.Parse(Console.ReadLine());
                                if (b1 >= withdraw_amt)
                                {
                                    if (withdraw_amt % 100 == 0)
                                    {
                                        Console.WriteLine("Please collect the cash : " + withdraw_amt);
                                        newbalance = b1 - withdraw_amt;
                                        Console.WriteLine("The current balance is now : " + newbalance);
                                    }
                                    else
                                        Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
                                }
                                else
                                    Console.WriteLine("Your account does not have sufficient balance");
                                break;
                            case '2':
                                Console.WriteLine("Select How Much Amount You Want To Withdraw : ");
                                Console.WriteLine(" 1. 500\n 2. 1000\n 3. 1500\n 4. 2000\n 5. 5000\n 6. 10000");
                                char fast_ch = char.Parse(Console.ReadLine());
                                switch (fast_ch)
                                {
                                    case '1':
                                        newbalance = b1 - 500;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '2':
                                        newbalance = b1 - 1000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '3':
                                        newbalance = b1 - 1500;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '4':
                                        newbalance = b1 - 2000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '5':
                                        newbalance = b1 - 5000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '6':
                                        newbalance = b1 - 10000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    default:
                                        Console.WriteLine("INVAILD NUMBER");
                                        break;
                                }
                                break;
                            case '3':
                                Console.WriteLine("The current balance in the account is : " + b1);
                                break;
                            case '4':
                                Console.WriteLine("Enter the amount to be deposite");
                                int deposit = int.Parse(Console.ReadLine());
                                newbalance = b1 + deposit;
                                Console.WriteLine("The current balance in the account is : " + newbalance);
                                break;
                            case '5':
                                Console.WriteLine("Want to change your pin");
                                Console.WriteLine("Enter your previous pin");
                                int prepin = int.Parse(Console.ReadLine());
                                if (prepin == p1)
                                {
                                    Console.WriteLine("Enter your new pin");
                                    int pin2 = int.Parse(Console.ReadLine());
                                    p1 = pin2;
                                    Console.WriteLine("Your pin is changed");
                                }
                                else
                                    Console.WriteLine("Enter your correct pin");
                                break;
                            default:
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("INVALID PIN");
                    }
                    break;
                }
            }
            else if (a2 == user_acc_num)
            {
                Console.WriteLine("Please Enter Your PIN :");
                int user_pin = int.Parse(Console.ReadLine());
                for (int j = 0; j < 4; j++)
                {
                    if (user_pin == p2)
                    {
                        Console.WriteLine("SELECT FROM FOLLOWING OPTIONS :");
                        Console.WriteLine(" 1. CASH WITHDRAWAL\n 2. FAST CASH\n 3. BALANCE INQUIRY\n 4. DEPOSIT\n 5. CHANGE PIN\n 6. EXIT");
                        char ch = char.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case '1':
                                Console.WriteLine("Enter the amount to withdraw");
                                int withdraw_amt = int.Parse(Console.ReadLine());
                                if (b2 >= withdraw_amt)
                                {
                                    if (withdraw_amt % 100 == 0)
                                    {
                                        Console.WriteLine("Please collect the cash : " + withdraw_amt);
                                        newbalance = b2 - withdraw_amt;
                                        Console.WriteLine("The current balance is now : " + newbalance);
                                    }
                                    else
                                        Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
                                }
                                else
                                    Console.WriteLine("Your account does not have sufficient balance");
                                break;
                            case '2':
                                Console.WriteLine("Select How Much Amount You Want To Withdraw : ");
                                Console.WriteLine(" 1. 500\n 2. 1000\n 3. 1500\n 4. 2000\n 5. 5000\n 6. 10000");
                                char fast_ch = char.Parse(Console.ReadLine());
                                switch (fast_ch)
                                {
                                    case '1':
                                        newbalance = b2 - 500;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '2':
                                        newbalance = b2 - 1000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '3':
                                        newbalance = b2 - 1500;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '4':
                                        newbalance = b2 - 2000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '5':
                                        newbalance = b2 - 5000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '6':
                                        newbalance = b2 - 10000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    default:
                                        Console.WriteLine("INVAILD NUMBER");
                                        break;
                                }
                                break;
                            case '3':
                                Console.WriteLine("The current balance in the account is : " + b2);
                                break;
                            case '4':
                                Console.WriteLine("Enter the amount to be deposite");
                                int deposit = int.Parse(Console.ReadLine());
                                newbalance = b2 + deposit;
                                Console.WriteLine("The current balance in the account is : " + newbalance);
                                break;
                            case '5':
                                Console.WriteLine("Want to change your pin");
                                Console.WriteLine("Enter your previous pin");
                                int prepin = int.Parse(Console.ReadLine());
                                if (prepin == p2)
                                {
                                    Console.WriteLine("Enter your new pin");
                                    int pin2 = int.Parse(Console.ReadLine());
                                    p2 = pin2;
                                    Console.WriteLine("Your pin is changed");
                                }
                                else
                                    Console.WriteLine("Enter your correct pin");
                                break;
                            default:
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("INVALID PIN");
                    }
                    break;
                }
            }
            else if (a3 == user_acc_num)
            {
                Console.WriteLine("Please Enter Your PIN :");
                int user_pin = int.Parse(Console.ReadLine());
                for (int j = 0; j < 4; j++)
                {
                    if (user_pin == p3)
                    {
                        Console.WriteLine("SELECT FROM FOLLOWING OPTIONS :");
                        Console.WriteLine(" 1. CASH WITHDRAWAL\n 2. FAST CASH\n 3. BALANCE INQUIRY\n 4. DEPOSIT\n 5. CHANGE PIN\n 6. EXIT");
                        char ch = char.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case '1':
                                Console.WriteLine("Enter the amount to withdraw");
                                int withdraw_amt = int.Parse(Console.ReadLine());
                                if (b3 >= withdraw_amt)
                                {
                                    if (withdraw_amt % 100 == 0)
                                    {
                                        Console.WriteLine("Please collect the cash : " + withdraw_amt);
                                        newbalance = b3 - withdraw_amt;
                                        Console.WriteLine("The current balance is now : " + newbalance);
                                    }
                                    else
                                        Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
                                }
                                else
                                    Console.WriteLine("Your account does not have sufficient balance");
                                break;
                            case '2':
                                Console.WriteLine("Select How Much Amount You Want To Withdraw : ");
                                Console.WriteLine(" 1. 500\n 2. 1000\n 3. 1500\n 4. 2000\n 5. 5000\n 6. 10000");
                                char fast_ch = char.Parse(Console.ReadLine());
                                switch (fast_ch)
                                {
                                    case '1':
                                        newbalance = b3 - 500;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '2':
                                        newbalance = b3 - 1000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '3':
                                        newbalance = b3 - 1500;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '4':
                                        newbalance = b3 - 2000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '5':
                                        newbalance = b3 - 5000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '6':
                                        newbalance = b3 - 10000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    default:
                                        Console.WriteLine("INVAILD NUMBER");
                                        break;
                                }
                                break;
                            case '3':
                                Console.WriteLine("The current balance in the account is : " + b3);
                                break;
                            case '4':
                                Console.WriteLine("Enter the amount to be deposite");
                                int deposit = int.Parse(Console.ReadLine());
                                newbalance = b3 + deposit;
                                Console.WriteLine("The current balance in the account is : " + newbalance);
                                break;
                            case '5':
                                Console.WriteLine("Want to change your pin");
                                Console.WriteLine("Enter your previous pin");
                                int prepin = int.Parse(Console.ReadLine());
                                if (prepin == p3)
                                {
                                    Console.WriteLine("Enter your new pin");
                                    int pin2 = int.Parse(Console.ReadLine());
                                    p3 = pin2;
                                    Console.WriteLine("Your pin is changed");
                                }
                                else
                                    Console.WriteLine("Enter your correct pin");
                                break;
                            default:
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("INVALID PIN");
                    }
                    break;
                }
            }
            else if (a4 == user_acc_num)
            {
                Console.WriteLine("Please Enter Your PIN :");
                int user_pin = int.Parse(Console.ReadLine());
                for (int j = 0; j < 4; j++)
                {
                    if (user_pin == p4)
                    {
                        Console.WriteLine("SELECT FROM FOLLOWING OPTIONS :");
                        Console.WriteLine(" 1. CASH WITHDRAWAL\n 2. FAST CASH\n 3. BALANCE INQUIRY\n 4. DEPOSIT\n 5. CHANGE PIN\n 6. EXIT");
                        char ch = char.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case '1':
                                Console.WriteLine("Enter the amount to withdraw");
                                int withdraw_amt = int.Parse(Console.ReadLine());
                                if (b4 >= withdraw_amt)
                                {
                                    if (withdraw_amt % 100 == 0)
                                    {
                                        Console.WriteLine("Please collect the cash : " + withdraw_amt);
                                        newbalance = b4 - withdraw_amt;
                                        Console.WriteLine("The current balance is now : " + newbalance);
                                    }
                                    else
                                        Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
                                }
                                else
                                    Console.WriteLine("Your account does not have sufficient balance");
                                break;
                            case '2':
                                Console.WriteLine("Select How Much Amount You Want To Withdraw : ");
                                Console.WriteLine(" 1. 500\n 2. 1000\n 3. 1500\n 4. 2000\n 5. 5000\n 6. 10000");
                                char fast_ch = char.Parse(Console.ReadLine());
                                switch (fast_ch)
                                {
                                    case '1':
                                        newbalance = b4 - 500;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '2':
                                        newbalance = b4 - 1000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '3':
                                        newbalance = b4 - 1500;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '4':
                                        newbalance = b4 - 2000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '5':
                                        newbalance = b4 - 5000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    case '6':
                                        newbalance = b4 - 10000;
                                        Console.WriteLine("Your Balance is : " + newbalance);
                                        break;
                                    default:
                                        Console.WriteLine("INVAILD NUMBER");
                                        break;
                                }
                                break;
                            case '3':
                                Console.WriteLine("The current balance in the account is : " + b4);
                                break;
                            case '4':
                                Console.WriteLine("Enter the amount to be deposite");
                                int deposit = int.Parse(Console.ReadLine());
                                newbalance = b4 + deposit;
                                Console.WriteLine("The current balance in the account is : " + newbalance);
                                break;
                            case '5':
                                Console.WriteLine("Want to change your pin");
                                Console.WriteLine("Enter your previous pin");
                                int prepin = int.Parse(Console.ReadLine());
                                if (prepin == p4)
                                {
                                    Console.WriteLine("Enter your new pin");
                                    int pin2 = int.Parse(Console.ReadLine());
                                    p4 = pin2;
                                    Console.WriteLine("Your pin is changed");
                                }
                                else
                                    Console.WriteLine("Enter your correct pin");
                                break;
                            default:
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("INVALID PIN");
                    }
                    break;
                }
            }
            else
            {
                Console.WriteLine("INVALID ACCOUNT NUMBER");
            }

        }
    }
}