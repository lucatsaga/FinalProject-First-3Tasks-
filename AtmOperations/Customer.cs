using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtmOperations
{
    public class Customer
    {

        /*
        private static int nextId = 1;


        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static HashSet<string> registeredPrivateNumbers = new HashSet<string>();
        private string privateNumber;
        public string PrivateNumber
        {
            get { return privateNumber; }
            set
            {


                if (IsPrivateNumberUnique(value) && value.Length == 11)
                {
                    privateNumber = value;
                    registeredPrivateNumbers.Add(value);
                }
                else
                {
                    Console.WriteLine("Private Number is already registered or inserted Private Number doesn't contain 11numbers");

                }
            }
        }

        public bool IsPrivateNumberUnique(string privateNumber)
        {
            return !registeredPrivateNumbers.Contains(PrivateNumber);
        }


        private static HashSet<string> registeredPasswords = new HashSet<string>();
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length == 4 && IsPasswordUnique(value))
                {
                    password = value;
                    registeredPasswords.Add(value);

                }
                else
                {
                    Console.WriteLine("PinCode is already registered or inserted PinCode doesn't contain 4Digits");

                }

            }
        }

        private bool IsPasswordUnique(string password)
        {
            return !registeredPasswords.Contains(password);
        }

        public double Balance { get; set; }


        public Customer(string firstName, string lastName, string privateNumber, string password, double balance)
        {

            this.FirstName = firstName;
            this.LastName = lastName;
            this.PrivateNumber = privateNumber;
            this.Password = password;
            this.Balance = balance;
            this.Id = nextId++;
        }

        public Customer(string firstName)
        {
            this.FirstName = firstName;
        }

        public Customer()
        {

        }






        public void DisplayUserInfo()
        {
            Console.WriteLine($"User(ID:{Id}, Name:{FirstName}, LastName:{LastName}, PrivateNumber:{PrivateNumber}, Password:{Password}, Balance:{Balance}");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"The balance of {FirstName} {LastName} is {Balance}Lari");
        }

        public void PutMoney(int money)
        {
            Balance += money;
            Console.WriteLine($"You have added {Balance}Lari in you account. Your existing Balance is {Balance}Lari");
        }

        public void TakeMoney(int money)
        {
            Balance -= money;
            Console.WriteLine($"You have taken {money}Lari from your account. Your existing Balance is {Balance}Lari");
        }



        public void LogInAndSignUp(Customer customer)
        {
            //string x = customer.FirstName;
            //string y = customer.LastName;
            //string z = customer.PrivateNumber;
            //string g = customer.Password;
            //double h = customer.Balance;

            Console.WriteLine("Enter Private Number");
            customer.PrivateNumber = Console.ReadLine();
            if (!registeredPasswords.Contains(customer.PrivateNumber))
            {
                Console.WriteLine("Pin code will automatically be provided.");
                registeredPrivateNumbers.Add(customer.PrivateNumber);
                bool isPasswordUnique = !(registeredPasswords.Contains(customer.Password));
                do
                {
                    Random random = new Random();
                    customer.Password = random.Next(1000, 10000).ToString();
                    if (isPasswordUnique)
                    {
                        Console.WriteLine($"Your Pin is {customer.Password}");
                    }


                } while (!isPasswordUnique);

                Console.WriteLine("Gtxovt sheiyvanot saxeli");
                customer.FirstName = Console.ReadLine();
                Console.WriteLine("Gtxovt sheivanot gvari");
                customer.LastName = Console.ReadLine();
                customer.Balance = 0;
            }
            else if (registeredPasswords.Contains(customer.PrivateNumber))
            {
                do
                {
                    Console.WriteLine("Please enter your Pin Code");
                    customer.Password = Console.ReadLine();
                    if (registeredPasswords.Contains(customer.Password))
                    {
                        Console.WriteLine("Tkven warmatebit shexvedit angarisshi");
                    }
                    else if (!registeredPasswords.Contains(customer.Password))
                    {
                        Console.WriteLine("Araswori paroli gtxovt sheiyvanot swori pin code");
                    }
                } while (!registeredPasswords.Contains(customer.Password));

                




            }
            Console.WriteLine($"gtxovt aarchiot operacia" +
                    $"[B] - Balansis shemowmeba " +
                    $"[P] - Tanxis shetana " +
                    $"[T] - Tanxis ganagdeba " +
                    $"[H] - operaciebis istoriis naxva");

            string operation = Console.ReadLine();
            if (operation == "B")
            {
                customer.CheckBalance();
            }
            else if (operation == "P")
            {
                Console.WriteLine("Sheiyvanet tanxa ramdenic unda daematos angarishs");
                int money = Convert.ToInt32(Console.ReadLine());
                customer.PutMoney(money);
                
            }
            else if (operation == "T")
            {
                Console.WriteLine("Sheiyvanet gasatani tanxa");
                int money = Convert.ToInt32(Console.ReadLine());
                customer.TakeMoney(money);
               
            }
            else if (operation == "H")
            {
                Console.WriteLine("es shesavsebia");
            }
            Console.WriteLine("Gmadlobt bankshi sargeblobistvis");


        }

        

    }
        */


        private static int nextId = 1;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        List<Customer> customers = new List<Customer>();
        public static HashSet<string> registeredPrivateNumbers = new HashSet<string>();

        
        public static HashSet<string> GetRegisteredPrivateNumbers(Customer customer)
        {
            return registeredPrivateNumbers;
        }
        

        private string privateNumber;

        public string PrivateNumber
        {
            get { return privateNumber; }
            set
            {
                do
                {
                    if (IsPrivateNumberUnique(value) && value.Length == 11)
                    {
                        privateNumber = value;                      
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Private Number is already registered or inserted Private Number doesn't contain 11 numbers");
                        Console.WriteLine("Please Re-Enter Private Number");
                        value = Console.ReadLine();
                    }
                } while (true);
            }
        }

        public static bool IsPrivateNumberUnique(string privateNumber)
        {
            
            return !registeredPrivateNumbers.Contains(privateNumber);
        }

        public static HashSet<string> registeredPasswords = new HashSet<string>();
        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length == 4 && IsPasswordUnique(value))
                {
                    password = value;
                    registeredPasswords.Add(value);
                }
                else
                {
                    Console.WriteLine("Pin Code is already registered or inserted Pin Code doesn't contain 4 Digits");
                }
            }
        }

        private static bool IsPasswordUnique(string password)
        {
            return !registeredPasswords.Contains(password);
        }

        public double Balance { get; set; }

        public Customer customer { get; set; }

        public Customer(string firstName, string lastName, string privateNumber, string password, double balance)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PrivateNumber = privateNumber;
            this.Password = password;
            this.Balance = balance;
            this.Id = nextId++;
        }

        public Customer()
        {
        }


    
        public void DisplayUserInfo()
        {
            Console.WriteLine($"User(ID:{Id}, Name:{FirstName} {LastName}, PrivateNumber:{PrivateNumber}, Password:{Password}, Balance:{Balance})");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"The balance of {FirstName} {LastName} is {Balance} Lari");
            
            
        }

        public void PutMoney(int money)
        {
            Balance += money;
            Console.WriteLine($"You have added {money} Lari to your account. Your existing balance is {Balance} Lari");
        }

        public void TakeMoney(int money)
            {
                if (Balance >= money)
                {
                    Balance -= money;
                    Console.WriteLine($"You have withdrawn {money} Lari from your account. Your existing balance is {Balance} Lari");
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Withdrawal failed.");
                }         
        }
    }   
}



/* public void LogInAndSignUp()   //Dzveli Code
         {
             char proceed;

             do
             {
                 Console.WriteLine("Enter Private Number");
                 PrivateNumber = Console.ReadLine();

                 if (!IsPrivateNumberUnique(PrivateNumber))
                 {
                     Console.WriteLine("Pin code will automatically be provided.");
                     registeredPrivateNumbers.Add(PrivateNumber);

                     do
                     {
                         Random random = new Random();
                         Password = random.Next(1000, 10000).ToString();
                         if (!IsPasswordUnique(Password))
                         {
                             Console.WriteLine($"Your Pin is {Password}");
                             break;
                         }
                     } while (true);

                     Console.WriteLine("Enter First Name");
                     FirstName = Console.ReadLine();

                     Console.WriteLine("Enter Last Name");
                     LastName = Console.ReadLine();
                     Balance = 0;

                     Console.WriteLine("Registration successful. Welcome!");
                 }
                 else if (IsPrivateNumberUnique(PrivateNumber))
                 {
                     do
                     {
                         Console.WriteLine("Please enter your Pin Code");
                         Password = Console.ReadLine();

                         if (registeredPasswords.Contains(Password))
                         {
                             Console.WriteLine("You have successfully logged in.");
                             break;
                         }
                         else
                         {
                             Console.WriteLine("Incorrect password. Please try again.");
                         }
                     } while (true);
                 }


                 Console.WriteLine($"Operations Menu:\n[B] - Check Balance\n[P] - Deposit Money\n[T] - Withdraw Money\n[H] - Transaction History");
                 string operation = Console.ReadLine();


                 switch (operation.ToUpper())
                 {
                     case "B":
                         CheckBalance();
                         break;
                     case "P":
                         Console.WriteLine("Enter the amount to deposit");
                         int depositAmount;
                         while (!int.TryParse(Console.ReadLine(), out depositAmount) || depositAmount < 0)
                         {
                             Console.WriteLine("Invalid input. Please enter a valid positive integer.");
                             Console.Write("Enter the amount to deposit: ");
                         }
                         PutMoney(depositAmount);
                         break;
                     case "T":
                         Console.WriteLine("Enter the amount to withdraw");
                         int withdrawAmount;
                         while (!int.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount < 0)
                         {
                             Console.WriteLine("Invalid input. Please enter a valid positive integer.");
                             Console.Write("Enter the amount to withdraw: ");
                         }
                         TakeMoney(withdrawAmount);
                         break;
                     case "H":
                         Console.WriteLine("Transaction history not implemented yet.");
                         break;
                     default:
                         Console.WriteLine("Invalid operation. Please select a valid option.");
                         break;
                 }

                 Console.WriteLine("Thank you for banking with us!");
                 Console.WriteLine("daachire [Y]-s gasagrdzeleblad, an [N] - procesis dasasruleblad");
                 proceed = Convert.ToChar(Console.ReadLine());


             } while (proceed == 'Y');

         }
            */