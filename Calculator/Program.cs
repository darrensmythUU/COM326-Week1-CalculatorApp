CalculatorApp();

void CalculatorApp()
{
    // Declare the variables and initialize them to 0
    int firstNumber = 0;
    int secondNumber = 0; 
    int result = 0;
    int choice = 0;

    // Ask the user to input the first number
    Console.WriteLine("Type in the first number followed by the Enter key");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    // Ask the user to input the second number
    Console.WriteLine("Type in the second number followed by the Enter key");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    // Use a loop to make the relavent decision
    // and perform the requested maths operation
    Console.WriteLine("Choose an option from the below list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    // Convert string to integer
    choice = Convert.ToInt32(Console.ReadLine());

    // Use an IF statement to perform selected maths operation
    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}.");
        Console.ReadLine();
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {firstNumber} from {secondNumber} equals {result}.");
        Console.ReadLine();
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} by {secondNumber} equals {result}.");
        Console.ReadLine();
    }
    else if (choice == 4)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} by {secondNumber} equals {result}.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("You did not select a valid number between 1 - 4.");
        Console.ReadLine();
    }
}