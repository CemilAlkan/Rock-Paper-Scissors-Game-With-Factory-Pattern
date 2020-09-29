using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Rock : Guess
    {
        public ResultEnum Compare(GuessEnum guess)
        {
            switch (guess)
            {
                case GuessEnum.Paper:
                    return ResultEnum.Loss;
                case GuessEnum.Scissors:
                    return ResultEnum.Win;
                default:
                    return ResultEnum.Draw;
            }
        }

        public GuessEnum GetGuessType()
        {
            return GuessEnum.Rock;
        }
    }
}
