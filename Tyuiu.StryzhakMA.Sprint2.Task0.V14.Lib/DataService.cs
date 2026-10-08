using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StryzhakMA.Sprint2.Task0.V14.Lib
{
    public class DataService : ISprint2Task0V14
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 321 == y;
            res[1] = x - 321 != y;
            res[2] = x - 330 < y; 
            res[3] = x - 330 > y;
            res[4] = x - 330 <= y;
            res[5] = x - 330 >= y;

            return res;
        }
    }
}
