namespace CSharp
{
    public class Calculator
    {
        public double _runningTotal;
        public double _currentNumber;

        public Calculator()
        {
        }
        public Calculator Add(double number){
            _currentNumber = number;
            _runningTotal += _currentNumber;
            return this;
        }
        public Calculator Subtract(double number){
            _currentNumber = number;
            _runningTotal -= _currentNumber;
            return this;
        }
        public Calculator Divide(double number){
            _currentNumber = number;
            _runningTotal /= _currentNumber;
            return this;
        }
        public Calculator Multiply(double number){
            _currentNumber = number;
            _runningTotal *= _currentNumber;
            return this;
        }

        public Calculator Mod(double number){
            _currentNumber = number;
            _runningTotal %= number;
            return this;
        }
        public double Result 
        {
            get
            {
                return _runningTotal;
            }
        }

        public Calculator Clear()
        {
            this._runningTotal = 0;
            this._currentNumber = 0;
            return this;
        }


    }
}