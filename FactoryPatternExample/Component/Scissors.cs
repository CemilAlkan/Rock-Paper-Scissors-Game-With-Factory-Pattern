using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Scissors : Guess
    {
        public ResultEnum Compare(GuessEnum guess)
        {
            switch (guess)
            {
                case GuessEnum.Rock:
                    return ResultEnum.Win;
                case GuessEnum.Paper:
                    return ResultEnum.Loss;
                default:
                    return ResultEnum.Draw;
            }
        }

        public GuessEnum GetGuessType()
        {
            return GuessEnum.Scissors;
        }
    }
}
