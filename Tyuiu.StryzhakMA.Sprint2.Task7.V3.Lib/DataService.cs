using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StryzhakMA.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            
            if (x >= -1 && x <= 1 && y <= 1 - x * x && y >= 1 - Math.Sqrt(1 - x * x))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
