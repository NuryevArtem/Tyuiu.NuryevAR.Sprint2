using Tyuiu.NuryevAR.Sprint2.Task7.V10.Lib;

namespace Tyuiu.NuryevAR.Sprint2.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, y;
            bool res;
            Console.Title = "Спринт #2 | Выполнил: Нурыев А.Р. | ИИПБ-24-2";
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                              *");
            Console.WriteLine("* Тема: Получение результата из switch                                                   *");
            Console.WriteLine("* Задание #7                                                                             *");
            Console.WriteLine("* Вариант #10                                                                            *");
            Console.WriteLine("* Выполнил: Нурыев Артём Радикович | ИИПБ-24-2                                           *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                               *");
            Console.WriteLine("* Написать программу на C#,                                                              *");
            Console.WriteLine("* которая запрашивает исходные данные (вещественные значения) и вычисляет,               *");
            Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.                        *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Введите X:                                                                             *");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите Y:                                                                             *");
            y = Convert.ToDouble(Console.ReadLine());
            res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
            if (res)
            {
                Console.WriteLine("Указанная точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Указанная точка не находится в заштрихованной области");
            }
            Console.WriteLine("******************************************************************************************");
            Console.ReadKey();
        }
    }
}
