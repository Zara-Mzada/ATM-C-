// object-den boxing ve unboxing
// bitwise operation

int password = 1234;
double balance = 20.5;
Enter:
Console.Write("Enter password: ");
int enteredPassword = Convert.ToInt32(Console.ReadLine());

if (enteredPassword == password)
{
    Console.WriteLine("Your balance " + balance);
    Reenter:
    Console.WriteLine("Withdraw or Adding (w/a)?");
    string answer = Console.ReadLine();
    Reamount:
    Console.WriteLine("Which currency will you use, USD, EUR, AZN? (u/e/a): ");
    string currency = Console.ReadLine();
    Console.WriteLine("Enter amount of money: ");
    double amount = Convert.ToDouble(Console.ReadLine());
    if (answer == "w")
    {
        if (currency == "u")
        {
            double convertedAZN = amount * 1.7;
            convertedAZN = (double)System.Math.Round(convertedAZN, 2);
            if (balance - convertedAZN >= 0)
            {
                Console.WriteLine("Balance " + (balance - convertedAZN));
            }
            else
            {
                Console.WriteLine("It is less than 0, reenter amount again");
                goto Reamount;
            }
        }
        else if (currency == "e")
        {
            double convertedAZN = amount * 1.8;
            convertedAZN = (double)System.Math.Round(convertedAZN, 2);
            if (balance - convertedAZN >= 0)
            {
                Console.WriteLine("Balance " + (balance - convertedAZN));
            }
            else
            {
                Console.WriteLine("It is less than 0, reenter amount again");
                goto Reamount;
            }
        }
        else if (currency == "a")
        {
            if (balance - amount >= 0)
            {
                Console.WriteLine("Balance " + (balance - amount));
            }
            else
            {
                Console.WriteLine("It is less than 0, reenter amount again");
                goto Reamount;
            }
        }
        else
        {
            Console.WriteLine("There is not this choice!");
            goto Reamount;
        }
    }
    else if (answer == "a")
    {
        if (currency == "u")
        {
            double convertedAZN = amount * 1.7;
            convertedAZN = (double)System.Math.Round(convertedAZN, 2);
            Console.WriteLine("Balance " + (balance+convertedAZN));
        }
        else if (currency == "e")
        {
            double convertedAZN = amount * 1.8;
            convertedAZN = (double)System.Math.Round(convertedAZN, 2);
            Console.WriteLine("Balance " + (balance+convertedAZN));
        }
        else if (currency == "a")
        {
            Console.WriteLine("Balance " + (balance+amount));
        }
        else
        {
            Console.WriteLine("There is not this choice!");
            goto Reamount;
        }
    }
    else
    {
        Console.WriteLine("There is not this variant, reenter");
        goto Reenter;
    }

}
else
{
    goto Enter;
}
goto Enter;