//In this challenge you will deepen your understanding for methods.
//Please go ahead and create three variables with names of your friends.
//Then create a Method "GreetFriend" which writes something like: "Hi Frank, my friend!" onto the console, once it is called.
//Where "Frank" should be replaced with the Name behind the argument given to the Method when it's called. So the method will need a parameter (decide which DataType will be best). 

//Greet all your three friends.


using System;

namespace Challenge_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Friend1 = "Frank";
            string Friend2 = "Bonnie";
            string Friend3 = "Jack";

            GreetFriend(Friend1);
            GreetFriend(Friend2);
            GreetFriend(Friend3);
            Console.Read();
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine($"Hi {friendName}, my friend!");
        }
    }
}
