using System;

namespace TestDrivenDevelopmentTutorial
{
    public class Rooter
    {
        public double SquareRoot(double Input)
        {
            if (Input <= 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }

            double Result = Input;
            double PreviousResult = -Input;
            while (Math.Abs(PreviousResult - Result) > Result / 1000)
            {
                PreviousResult = Result;
                Result = (Result + Input / Result) / 2;
            }
            return Result;
        }
    }
}