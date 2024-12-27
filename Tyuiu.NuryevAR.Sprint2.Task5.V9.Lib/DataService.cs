using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NuryevAR.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int dayOfWeek = (n + m - 2) % 7;
            if (dayOfWeek == 0)
            {
                dayOfWeek = 7;
            }
            switch (dayOfWeek)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 7:
                    return "Воскресенье";
                default:
                    return "Понедельник";
            }
        }
    }
}
