using System;

var input=0;
var balance = 50000;
void WelcomeMessage()
{
    Console.WriteLine("------Welcome to Fatmah Bank ------\nFor deposit press 1\nFor withdarwal press 2\nTo check balancepress 3\nTo exit press 4");
    var isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum == false || num < 1 || num > 4)
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        WelcomeMessage();
    }
    input = num;
}

void Deposit()
{
    Console.WriteLine("Enter amount to deposit:");
    var isNum = int.TryParse(Console.ReadLine(), out int depositAmount);
    if (isNum == false)
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        WelcomeMessage();
    }

    if (depositAmount <= 0)
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        WelcomeMessage();
    }

    balance += depositAmount;

    Console.WriteLine($"Your deposit was successful and your new balance is {balance}");
}

WelcomeMessage();

if(input == 1)
{
    Deposit();
}
else if(input == 2)
{

}
