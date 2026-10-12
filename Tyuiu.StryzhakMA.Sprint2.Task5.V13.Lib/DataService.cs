using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StryzhakMA.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysinMonth;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysinMonth = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    daysinMonth = 30;
                    break;

                case 2:
                    daysinMonth = 29;
                    break;

                default:
                    throw new ArgumentException("Некорректный месяц");

            }

            if (n < 1 || n > daysinMonth)
            {
                throw new ArgumentException("Некорректное число");
            }
            if (n < daysinMonth)
            {
                n++;
            }
            else
            {
                n = 1;
                if (m < 12)
                {
                    m++;
                }
                else
                {
                    m = 1;
                    g++;
                }
            }
            return $"{n:D2}.{m:D2}.{g:D4}";
        }
    }
}
