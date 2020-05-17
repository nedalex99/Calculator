using System;

namespace Calculator
{
    class Utils
    {
        public static double Calculate(Double nr1, Double nr2, String operation)
        {
            switch (operation)
            {
                case "+":
                    return nr1 + nr2;
                    break;
                case "-":
                    return nr1 - nr2;
                    break;
                case "*":
                    return nr1 * nr2;
                    break;
                case "/":
                    return nr1 / nr2;
                    break;
                default:
                    return 0;
                    break;
            }
        }

        public static bool IsOperator(char ch)
        {
            if (ch.Equals('+') || ch.Equals('-') || ch.Equals('*') || ch.Equals('/'))
            {
                return true;
            }
            return false;
        }
    }
}
