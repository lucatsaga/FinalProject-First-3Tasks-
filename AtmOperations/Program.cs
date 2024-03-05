// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Text.Json;
using AtmOperations;
using static System.Net.Mime.MediaTypeNames;
//Console.WriteLine("Welcome to Luca Bank");
//Console.WriteLine("Enter your Private Number");
//Console.ReadLine();
//Console.WriteLine("Enter your Password");
//Customer customer1 = new Customer("Luka", "Tsagareishvili", "01008048787", "1234", 500.82);
//Customer customer2 = new Customer("Giorgi", "Giorgadze", "01008048786", "1234", 242.24);
//Customer customer3 = new Customer("Nick", "Bakradze", "02992812823", "1854", 212.2654);



/*
customer1.CheckBalance();
customer1.PutMoney(800);
customer1.TakeMoney(700);
*/




//Customer customer = new Customer();
//customer.LogInAndSignUp();































/*


foreach (var privateNumber in Customer.GetRegisteredPrivateNumbers(customer1))
{
    Console.WriteLine(privateNumber);
}
*/



/*
{
    Customer customer3 = new Customer("giorgi", "Giorgadze", "01008048785", "1445", 860);
    string jsonString3 = JsonSerializer.Serialize(customer3);
    string filePath = "C:\\Users\\Luka\\Desktop\\FinalProject(new)\\AtmOperations\\Test.txt";

    File.AppendAllText(filePath, jsonString3 + Environment.NewLine);
}
*/









//CustomerLogger.LoadCustomers(); //wina gzit gaketebuli Json


   

    //Customer customer1 = new Customer();



    List<Customer>customers = new List<Customer>();
customers.Add(new Customer("Luka", "Tsagareishvili", "01008048787", "1234", 900));  

    FileLogger fileLogger = new FileLogger();


    Console.WriteLine("Welcome To the Bank");
    Console.WriteLine("Please Enter your Private Number");
    string insertedPrivNum = Console.ReadLine();

    customer1.PrivateNumber = insertedPrivNum;
    char lastOperation;

    do
    {
        if (!Customer.IsPrivateNumberUnique(customer1.PrivateNumber))
        {

            Console.WriteLine($"Welcome {customer1.FirstName} {customer1.LastName}. Please insert your Password");
            string password = Console.ReadLine();
            bool correctPass = (password == customer1.Password);
            string rePass;
            if (!correctPass)
            {
                do
                {
                    Console.WriteLine("The password is incorrect. Please write correct password.");
                    rePass = Console.ReadLine();
                    if (rePass == customer1.Password)
                    {
                        Console.WriteLine("You have succesfully logged in.");
                    }
                } while (rePass != customer1.Password);
            }
            else
            {
                Console.WriteLine("You have succesfully logged in.");
            }
        }
        else
        {
            Random random = new Random();
            string randomPass = random.Next(1000, 10000).ToString();
            customer1.Password = randomPass;
            Console.WriteLine($"You are our new member. Your password is {customer1.Password}");
            Customer.registeredPrivateNumbers.Add(customer1.PrivateNumber);
            Customer.registeredPasswords.Add(customer1.Password);
            Console.WriteLine("Please Enter Your FirstName");
            string fName = Console.ReadLine();
            customer1.FirstName = fName;
            Console.WriteLine("Please Enter Your LastName");
            string lName = Console.ReadLine();
            customer1.LastName = lName;
            customer1.Balance = 0;
       // CustomerLogger.SaveCustomer(customer1); //wina gzit gaketebuli json
        
    }
        Console.WriteLine("Please Choose Operation 1.[B] --> To Check Balance  2.[P] --> Put Money onto Balance  3.[T] --> To Take Money out of Balance  4.[H] --> To see History of Operations");
        char operation = Convert.ToChar(Console.ReadLine());

        switch (operation)
        {
            case 'B':
                customer1.CheckBalance();

                FileLogger.Log($"The balance of ID{customer1.Id}, {customer1.FirstName} {customer1.LastName} is {customer1.Balance}Lari", customer1);

                break;
            case 'P':
                Console.WriteLine("Enter Amount, how much you want to put to Balance");
                int putMoney = Convert.ToInt32(Console.ReadLine());
                customer1.PutMoney(putMoney);            
            FileLogger.Log($"{customer1.FirstName} {customer1.LastName} have added {putMoney} Lari to his/her account. Existing Balance is {customer1.Balance}Lari", customer1);
                break;
            case 'T':
                Console.WriteLine("Enter Amount, how much you want to take from Balance");
                int takeMoney = Convert.ToInt32(Console.ReadLine());
                customer1.TakeMoney(takeMoney);
            FileLogger.Log($"{customer1.FirstName} {customer1.LastName} have withdrawn {takeMoney}Lari from his/her account. Existing Balance is {customer1.Balance}Lari", customer1);
            break;
            case 'H':
                Console.WriteLine("I have to implement this method afterwards");
                break;

            

    }
    
    Console.WriteLine("Do you want to proceed the operations? [Y] --> To Proceed, [N] --> To Close the Bank");
        lastOperation = Convert.ToChar(Console.ReadLine());
    } while (lastOperation == 'Y');




    










