using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

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
    class Program
    {
        static void Main(string[] args)
        { 
            var calculator = new Calculator();
            try
            {
                WriteLine("Укажите первое целое число");
                string inputA = Console.ReadLine();
                if(!int.TryParse(inputA, out int NumberOne))  /// проверяем корректность ввода иначе выбрасываем ошибку
                    throw new FormatException("Неверный формат первого числа.");
                string inputB = Console.ReadLine();
                if (!int.TryParse(inputB, out int NumberTwo)) /// проверяем корректность ввода иначе выбрасываем ошибку
                    throw new FormatException("Неверный формат второго числа.");
                int result = calculator.Sum(NumberOne,NumberTwo);
                Console.WriteLine(result);

            }
            catch (FormatException ex) /// Исключение по формату (принимаем только целые чиста)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Завершение работы");
            }
        }
    }
}
