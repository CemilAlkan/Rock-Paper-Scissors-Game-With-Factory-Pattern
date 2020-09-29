using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace FactoryPatternExample
{
    public class GuessFactory
    {
        public static Guess getGuess()
        {
            Random random = new Random();
            int randomGuesId = random.Next(0, 4);

            switch (randomGuesId)
            {
                case (int)GuessEnum.Rock:
                    return new Rock() ;
                case (int)GuessEnum.Scissors:
                    return new Scissors();
                case (int)GuessEnum.Paper:
                    return new Paper();
                default:
                    return null;
            }
        }
    }
}
