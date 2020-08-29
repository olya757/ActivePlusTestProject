using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpClassLibrary.FirstTask
{
    public class Counter
    {
        public static int GetSummOfOddNumbers(int[] numbers)
        {
            int summ = 0;
            bool isSecond = false;
            foreach(var n in numbers)
            {
                if(n%2!=0 )
                {
                    if (isSecond)
                    {
                        summ += n;
                    }
                    isSecond = !isSecond;
                }
            }
            return summ;
        }
    }
}
