using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Paper : Guess
    {
        public ResultEnum Compare(GuessEnum guess)
        {
            switch (guess)
            {
                case GuessEnum.Rock:
                    return ResultEnum.Loss;
                case GuessEnum.Scissors:
                    return ResultEnum.Win;
                default:
                    return ResultEnum.Draw;
            }
        }

        public GuessEnum GetGuessType()
        {
            return GuessEnum.Paper;
        }
    }
}
