using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StryzhakMA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            if (k < 1 || k > 365)
            {
                throw new ArgumentException($"Номер дня года должен быть от 1 до 365. Значение {k}");
            }
            int dayIndex = (k + d - 2) % 7 + 1;
            string dayName = dayIndex switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => throw new ArgumentException("Некорректное значение")
            };

            return dayName;
        }
    }
}
