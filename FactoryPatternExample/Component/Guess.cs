using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public interface Guess
    {
        public abstract GuessEnum GetGuessType();
        public abstract ResultEnum Compare(GuessEnum guess);
    }
}
