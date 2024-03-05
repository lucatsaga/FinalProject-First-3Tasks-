// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to the Chamokhrchobana");
List<string> words = new List<string>{"apple", "banana", "orange", "grape", "kiwi","strawberry", "pineapple", "blueberry", "peach", "watermelon"};

int x;
bool isUserInputValid = true;
bool isBetweenRanges = true;


do
{
    Console.WriteLine("Choose word between #1 - #10");
    string insertedWordNumber = Console.ReadLine();
    isUserInputValid = int.TryParse(insertedWordNumber, out x);
    isBetweenRanges = x >= 1 && x <= 10;
    if (!isUserInputValid)
    {
        Console.WriteLine("Invalid Input. Please enter a number");
    }
    else if(!isBetweenRanges)
    {
        Console.WriteLine("Invalid Input. Please enter numers between 1-10");
    }
    
}
while (!isUserInputValid || !isBetweenRanges);

string chosenWord = words[x - 1];

for (int i = 1; i <= 6 ; i++)
{
    char letterInChar;
    
    bool isValidInput = true;
    bool isLetterBetweenRanges = true;

    do {
        Console.WriteLine($"Try {i} (Tries left:{7 - i}). Please enter a letter from [a] to [z] ");
        string letterInString = Console.ReadLine();
        isValidInput = char.TryParse(letterInString, out letterInChar);
        isLetterBetweenRanges = letterInChar >= 'a' && letterInChar <= 'z';
        if(!isValidInput)
        {
            Console.WriteLine("Invalid Input. Please enter lowercase letters from [a] to [z]");
        }
        else if (!isLetterBetweenRanges)
        {
            Console.WriteLine("Invalid Input. Please enter lowercase letters from [a] to [z]");
        }

    } while (!isValidInput || !isLetterBetweenRanges);

    for (int j = 0; j < chosenWord.Length; j++)
    {
        if (letterInChar == Convert.ToChar(chosenWord[j]))
        {
            Console.WriteLine($"The '{letterInChar}' Letter is on the {j + 1}th ");
        }        
        
    }
    
}

Console.WriteLine("Please Enter the Word");
string userWord =Console.ReadLine();
if(userWord == chosenWord)
{
    Console.WriteLine($"Congratulation you are right. The word was '{chosenWord}'");
}
else
{
    {
        Console.WriteLine($"Unfortunately you are wrong. The word was '{chosenWord}'");
    }
}

