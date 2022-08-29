using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
     //This is all sorts of random information with variables

     int age = 21;
     int weight = 160;

     float heightMeters = 1.9558F;
     double memorizedPiDigits = 3.1415926D;

     char favLetter = 'B';
     char leastFavLetter = 'A';

     bool isTall = true;
     bool isTired = true;

     string coolFact = "I can speak Spanish pretty well.";
     string bigFear = "Despite the fact I'm tall, I'm scared of heights.";

     Console.WriteLine("These are some facts about Justin");
     Console.WriteLine("I am " + age + " years old.");
     Console.WriteLine("I weigh " + weight + " pounds.");
     Console.WriteLine("I am " + heightMeters + " meters tall.");
     Console.WriteLine("This is how many digits of Pi I have memorized: " + memorizedPiDigits + ".");
     Console.WriteLine("My favorite letter is " + favLetter + ",");
     Console.WriteLine("and my least favorite is " + leastFavLetter + ".");
     Console.WriteLine("Am I tall? " + isTall + ".");
     Console.WriteLine("Am I tired? Also " + isTired + ".");
     Console.WriteLine("Two facts about me are that " + coolFact + " " + bigFear);
     Console.WriteLine("That's all there is to learn today!");
    }
  }
}
