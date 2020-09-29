using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Guess newGues = GuessFactory.getGuess();

            Console.WriteLine("Rock Paper Scissors \n");
            Console.WriteLine("1-Rock\n2-Paper\n3-Scissors\n");
            int guess = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(newGues.GetGuessType());
            Console.WriteLine(newGues.Compare((GuessEnum)guess));

        }
    }
}
