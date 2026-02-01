using System;
using static System.Console;

namespace HW_03
{
    class Program
    {
        static void Main(string[] args)
        { 
            var calculator = new Calculator();
            try
            {
                WriteLine("Укажите первое целое число");
                string inputA = ReadLine();
                if(!int.TryParse(inputA, out int NumberOne))  /// проверяем корректность ввода иначе выбрасываем ошибку
                    throw new FormatException("Неверный формат первого числа.");
                string inputB = ReadLine();
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
                WriteLine("Завершение работы");
            }
        }
    }
}
