using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a number:");
    var t1 = Console.ReadLine();
    int number1 = Convert.ToInt32(t1);

    Console.WriteLine("Enter another number:");
    var t2 = Console.ReadLine();
    int number2 = Convert.ToInt32(t2);

    Console.WriteLine("sum = " + (number1 + number2));

    Console.WriteLine("diff = " + (number1 - number2));

    Console.WriteLine("product = " + (number1 * number2));

    Console.WriteLine("quotient = " + (number1 / number2));

    Console.WriteLine("Remainder = " + (number1 % number2));

    }
}