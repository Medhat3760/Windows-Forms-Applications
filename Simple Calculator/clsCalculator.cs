using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{

    public enum enOperationType { None, Add, Subtract, Multiply, Divide }

    public enum enCalcState { EnteringNumber, OperationSelected, ResultShown}

    internal class clsCalculator
    {

        private double _result = 0;
        private double _currentNumber = 0;
        private enOperationType _operationType = enOperationType.None;
        private enCalcState _state = enCalcState.EnteringNumber;

        public string Display { get; private set; } = "0";

        public void Clear()
        {

            _result = 0;
            _currentNumber = 0;
            _operationType = enOperationType.None;
            _state = enCalcState.EnteringNumber;
            Display= "0";

        }

        public void InputDigit(char digit)
        {

            if(_state == enCalcState.ResultShown)
            {
                Clear();
            }

            if(Display == "0" || _state == enCalcState.OperationSelected)
            {
                Display = digit.ToString();
            }
            else
            {
                Display += digit.ToString();
            }

            _state = enCalcState.EnteringNumber;

        }

        public void Calculate()
        {

            _currentNumber = double.Parse(Display);

            switch (_operationType)
            {

                case enOperationType.None:
                    _result = _currentNumber;
                    break;

                case enOperationType.Add:
                    _result += _currentNumber;
                    break;

                case enOperationType.Subtract:
                    _result -= _currentNumber;
                    break;

                case enOperationType.Multiply:
                    _result *= _currentNumber;
                    break;

                case enOperationType.Divide:

                    if (_currentNumber == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }

                    _result /= _currentNumber;
                    break;

            }

            Display = _result.ToString();

        }

        public void SetOperation(enOperationType operationType)
        {

            if(_state == enCalcState.EnteringNumber || _state == enCalcState.ResultShown)
            {
                Calculate();
            }

            _operationType = operationType;

            _state = enCalcState.OperationSelected;

        }

        public void Equal()
        {

            Calculate();
            _operationType = enOperationType.None;
            _state = enCalcState.ResultShown;

        }

        public void Backspace()
        {

            if(_state == enCalcState.ResultShown)
                Clear();

            if (Display.Length > 0 )
            {

                if (Display.Length == 1)
                {
                    Display = "0";
                    return;
                }

                Display = Display.Substring(0, Display.Length - 1);

            }            

        }

        public void InputDecimalPoint()
        {

            if(_state == enCalcState.ResultShown)
                Clear();

            if(_state == enCalcState.OperationSelected)
            {

                Display = "0.";
                _state = enCalcState.EnteringNumber;
                return;

            }

            if (!Display.Contains("."))
                Display += ".";
   
        }

        public void Percent()
        {

            double current = double.Parse(Display);

            switch (_operationType)
            {

                case enOperationType.Add:
                case enOperationType.Subtract:
                    current = _result * current / 100;
                    break;

                case enOperationType.Multiply:
                case enOperationType.Divide:
                    current = current / 100;
                    break;

                case enOperationType.None:
                    current = current / 100;
                    break;

            }

            Display = current.ToString();

            _state = enCalcState.EnteringNumber;

        }

        public void ToggleSign()
        {

            if (Display == "0")
                return;

            if (Display.StartsWith("-"))
            {
                Display = Display.Substring(1);
            }
            else
            {
                Display = "-" + Display;
            }

            if (_state == enCalcState.OperationSelected )
            {
                _state = enCalcState.EnteringNumber;
            }

        }

    }
}
