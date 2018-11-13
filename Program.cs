using System;
using System.Collections.Generic;


  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number 0-100");
     string stringNumberEntered = Console.ReadLine();
     int numberEntered = int.Parse(stringNumberEntered);

    
    double guess = 50;
    string answer = "";
    int count = 2;

    while (answer != "Correct")
    {
    Console.WriteLine("Is your number higher or lower than " + guess + "? (Higher/Lower/Correct)");
    answer = Console.ReadLine();
    if (answer == "Higher")
    {
    guess=guess+50/count;
    }
    else if (answer == "Lower")
    {
    guess=guess-50/count;
    }
    else 
    {
    Console.WriteLine("Great! I guessed your number. Would you like to play again? (Yes/No)");
    }
    count=count*2;
  }
 }
}


  


