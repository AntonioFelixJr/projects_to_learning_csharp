using System;

namespace Generics1
{
    class PrintService<T>
    {
        private T[] _values = new T[10];
        public int _count = 0;

        public void AddValue(T value)
        {
            if (_count >= 10)
                throw new ArgumentOutOfRangeException("PrintService no accepts values great than 10");

            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
                throw new ArgumentOutOfRangeException("PrintService is empty");

            return _values[0];
        }

        public void Print()
        {
            string saida = "[";

            for (int i = 0; i < _count; i++)
            {
                    saida += _values[i] + ", ";
            }

            saida = saida.TrimEnd();
            saida = saida.TrimEnd(',');
            saida = saida + "]";

            Console.WriteLine(saida);
        }
    }
}
