using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ØvelseTime2._2
{
    public class _14
    {
        public void main()
        {

        }
        public double discriminant(double a, double b, double c)
        {
            var res = (b*2)-4*a*c;
            Console.WriteLine($" Diskriminaten d er {res}");
            return res;
        }
        public void roots(double a, double b, double c)
        {
            var d = discriminant(a, b, c);
            if (d >0)
            {
                var x1 = (-b - Math.Sqrt(d)) / (2 * a);
                var x2 = (-b +Math.Sqrt(d)) / (2 * a);

                Console.WriteLine($"Der er to rødder da d > 0 og betyder at x1 = {x1} og x2 ={x2}");

			}
            else if (d==0)
            {
                var x = (-b) / (2 * a);
                Console.WriteLine($"der er en rød og den er :{x}");
            }
            else
            {
                Console.WriteLine("der er ingen rødder ");
            }
        }
    }
}
