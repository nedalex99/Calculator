using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Equation
    {
        private string operation = String.Empty;
        private int nrOfOperatorPressed = 0;
        private bool isOperatorPressed = false;
        private bool isOperationFinished = false;
        private bool numPressed = false;
        private bool dividedByZero = false;
        private double[] numbers = new double[2];
        private double rezult = 0;


        public string BtnNumberClick(string inputText, string btnContent)
        {
            numPressed = true;
            if(!isOperatorPressed && !isOperationFinished)
            {
                inputText = inputText + btnContent;
                return inputText;
            }
            inputText = btnContent;
            isOperationFinished = false;
            isOperatorPressed = false;
            return inputText;
        }

        public string BtnOperatorClick(string inputText, string btnContent)
        {
            if(!numPressed)
            {
                return String.Empty;
            }

            try
            {
                numbers[nrOfOperatorPressed] = Double.Parse(inputText);
            }
            catch(System.FormatException e1)
            {
                operation = btnContent;
                inputText = operation;
                return inputText;
            }

            if(nrOfOperatorPressed == 0)
            {
                nrOfOperatorPressed++;
                operation = btnContent;
                isOperatorPressed = true;
                inputText = btnContent;
                return inputText;
            }

            if(operation.Equals("/") && (numbers[1] == 0 || numbers[0] == 0))
            {
                dividedByZero = true;
                rezult = 0;
                Array.Clear(numbers, 0, numbers.Length);
                isOperationFinished = true;
                isOperatorPressed = false;
                nrOfOperatorPressed = 0;
                inputText = "Impossible";
                return inputText;
            }

            dividedByZero = false;
            rezult = Math.Round(Utils.Calculate(numbers[0], numbers[1], operation), 3);
            inputText = rezult.ToString() + btnContent;
            numbers[0] = rezult;
            isOperatorPressed = true;
            operation = btnContent;

            if(isOperationFinished)
            {
                isOperationFinished = false;
                inputText = btnContent;
                return inputText;
            }

            return inputText;
        }

        public string BtnEqualClick(string inputText)
        {
            if (!numPressed)
            {
                return String.Empty;
            }

            numbers[nrOfOperatorPressed] = Double.Parse(inputText);
            if(operation.Equals("/") && (numbers[1] == 0 || numbers[0] == 0))
            {
                dividedByZero = true;
                rezult = 0;
                Array.Clear(numbers, 0, numbers.Length);
                isOperatorPressed = false;
                isOperationFinished = true;
                numPressed = false;
                nrOfOperatorPressed = 0;
                inputText = "Impossible";
                return inputText;
            }
            rezult = Math.Round(Utils.Calculate(numbers[0], numbers[1], operation), 3);
            Array.Clear(numbers, 0, numbers.Length);
            isOperationFinished = true;
            nrOfOperatorPressed = 0;
            inputText = rezult.ToString();
            return inputText;
        }

        public string BtnClear(string inputText)
        {
            Array.Clear(numbers, 0, numbers.Length);
            rezult = 0;
            operation = String.Empty;
            isOperatorPressed = false;
            isOperationFinished = false;
            numPressed = false;
            nrOfOperatorPressed = 0;
            inputText = String.Empty;
            return inputText;
        }

        public string BtnSqrtClick(string inputText)
        {
            if (!numPressed)
            {
                return String.Empty;
            }

            numbers[nrOfOperatorPressed] = Math.Round(Math.Sqrt(Double.Parse(inputText)), 2);
            inputText = numbers[nrOfOperatorPressed].ToString();
            return inputText;
        }

        public string BtnPowClick(string inputText)
        {
            if (!numPressed)
            {
                return String.Empty;
            }

            numbers[nrOfOperatorPressed] = Math.Round(Math.Pow(Double.Parse(inputText), 2), 2);
            inputText = numbers[nrOfOperatorPressed].ToString();
            return inputText;
        }

        public string BtnReverseClick(string inputText)
        {
            if (!numPressed)
            {
                return String.Empty;
            }

            numbers[nrOfOperatorPressed] = Math.Round((1 / Double.Parse(inputText)), 5);
            inputText = numbers[nrOfOperatorPressed].ToString();
            return inputText;
        }

        public string BtnDelClick(string inputText)
        {
            if (!numPressed)
            {
                return String.Empty;
            }

            inputText = inputText.Remove(inputText.Length - 1);
            return inputText;
        }

        public string BtnPercentClick(string inputText)
        {
            if (!numPressed)
            {
                return String.Empty;
            }

            numbers[nrOfOperatorPressed] = Double.Parse(inputText) / 100;
            inputText = numbers[nrOfOperatorPressed].ToString();
            return inputText;
        }

        public string BtnPointClick(string inputText, string btnContent)
        {
            if (!numPressed)
            {
                return String.Empty;
            }

            if (!inputText.Contains("."))
            {
                inputText = btnContent;
            }
            return inputText;
        }

        public string BtnPozNegClick(string inputText)
        {
            if (!numPressed)
            {
                return String.Empty;
            }

            if (!inputText.Contains("-"))
            {
                inputText = "-" + inputText;
                return inputText;
            }
            inputText = inputText.Remove(0, 1);

            return inputText;
        }
    }
}
