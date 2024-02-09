using System;

namespace Assets.Visitor
{
    public class SpawnVeigth
    {
        private int _currentValue;
        private int _maxValue;

        public SpawnVeigth(int maxValue) => _maxValue = maxValue;

        public int CurrentValue => _currentValue;

        public void Add(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Value cannot be negative!");

            _currentValue += value;
        }

        public void Reduce(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Value cannot be negative!");

            _currentValue -= value;

            if (_currentValue < 0)
                _currentValue = 0;
        }

        public bool IsMaxWeight() => _currentValue >= _maxValue;

        public bool IsNotMaxWeight() => _currentValue < _maxValue;
    }
}