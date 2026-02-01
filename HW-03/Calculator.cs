using System;

namespace HW_03
{
    public interface ICalculator /// Интерфейс для калькулятора
    {
        int Sum(int a, int b);
    }

    public class Calculator() : ICalculator  ///Калькулятор на вход принимаем только целые числа (для добных нужно переделать на double)
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
