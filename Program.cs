using System;

namespace myFirstApp
{
  class Program
  {

    static void Main(string[] args)
    {
      var guessing = true;
      var count = 0;
      var min = 0;
      var max = 100;
      var guess = 50;
      string name;
      string input;


      Console.WriteLine("Welcome to the number guessing game!\nType in your name to begin!");
      name = Console.ReadLine();
      Console.WriteLine($"Thanks {name}!\n Now, think of a number between {min} and {max} and I'll try to guess!");
      while (guessing == true)
      {
        Console.WriteLine($"Is your number {guess}?");
        input = Console.ReadLine();
        if (input == "no")
        {
          count++;
          Console.WriteLine("higher or lower?");
          input = Console.ReadLine();
          if (input == "higher")
          {
            count++;
            min = guess + 1;
            guess = (min + max) / 2;
          }
          else if (input == "lower")
          {
            count++;
            max = guess - 1;
            guess = (min + max) / 2;
          }
        }
        else if (input == "yes")
        {
          guessing = false;
        }
      }

      Console.WriteLine($"Your number is {guess}! I guessed it in {count} tries!");

    }
  }
}
