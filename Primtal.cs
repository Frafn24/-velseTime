using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ØvelseTime2._2
{
    internal class Primtal
    {
        public void main()
        {
            for (int i = 2; i < 1000000; i++)
            {
                if (IsPrime(i)==true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        bool IsPrime(int value)
        {
            if (value <=1)
            {
                return false;
            }
            else if (value == 2)
            {
                return true;
            }
            if (value % 2 == 0) return false;
            
            var boundary = (int)Math.Floor(Math.Sqrt(value));
            for (int i = 3; i < boundary; i += 2)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
                
            return true;
                
            
        }
    }
}
