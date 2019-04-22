using System;

class Triangle
{
  static void Main()
  {
    Console.WriteLine("Enter a number");
    string stringFirstNumber = Console.ReadLine();
    int firstNumber = int.Parse(stringFirstNumber);

    Console.WriteLine("Enter a number");
    string stringSecondNumber = Console.ReadLine();
    int secondNumber = int.Parse(stringSecondNumber);

    Console.WriteLine("Enter a number");
    string stringThirdNumber = Console.ReadLine();
    int thirdNumber = int.Parse(stringThirdNumber);

    if (firstNumber == secondNumber && firstNumber == thirdNumber)
    {
      Console.WriteLine("That makes an equilateral");
    }
    else if ((firstNumber + secondNumber > thirdNumber && firstNumber + thirdNumber > secondNumber && secondNumber + thirdNumber > firstNumber) && (firstNumber == secondNumber || firstNumber == thirdNumber || secondNumber == thirdNumber))
    {
      Console.WriteLine("This makes an Isosceles triangle");
    }
    else if ((firstNumber + secondNumber > thirdNumber && firstNumber + thirdNumber > secondNumber && secondNumber + thirdNumber > firstNumber) && !(firstNumber == secondNumber || firstNumber == thirdNumber || secondNumber == thirdNumber))
    {
      Console.WriteLine("This makes a Scalene Triangle");
    }
    else
    {
      Console.WriteLine("This does not make a triangle");
    }


    }


  }
