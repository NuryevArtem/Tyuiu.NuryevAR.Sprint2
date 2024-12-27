using Tyuiu.NuryevAR.Sprint2.Task4.V25.Lib;

namespace Tyuiu.NuryevAR.Sprint2.Task4.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, res;

            Console.Title = "Спринт #2 | Выполнил: Нурыев А.Р. | ИИПб-24-2";
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                              *");
            Console.WriteLine("* Тема: Тернарный оператор                                                               *");
            Console.WriteLine("* Задание #4                                                                             *");
            Console.WriteLine("* Вариант #26                                                                            *");
            Console.WriteLine("* Выполнил: Нурыев Артём Радикович | ИИПБ-24-2                                           *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                               *");
            Console.WriteLine("* Написать программу, \n" +
                "которая вычисляет требуемое значение с использованием тернарного оператора, \n" +
                "где пользователь вводит значение переменных х с клавиатуры, \n" +
                "если х - 2 < у + 2, то z = 10 + z = (10 + 2 / x^2)^y иначе х^2 - (1 / y)                 *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Введите значение переменной x:                                                         *");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите значение переменной y:                                                         *");
            
            res = ds.Calculate(x);
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
            Console.WriteLine($"Значение функции = {res}");
            Console.WriteLine("******************************************************************************************");
            Console.ReadKey();
        }
    }
}
