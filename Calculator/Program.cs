﻿CalculatorApp();

void CalculatorApp()
{
   // Ask the user to input the first number
    Console.WriteLine("Type in the first number followed by the Enter key");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    // Ask the user to input the second number
    Console.WriteLine("Type in the second number followed by the Enter key");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    // Perform the calculation
    int result = firstNumber + secondNumber;

    // Output the answer to the console
    Console.WriteLine("Adding {0} and {1} gave the answer {2}", firstNumber, secondNumber, result);
    Console.ReadKey(); 
}