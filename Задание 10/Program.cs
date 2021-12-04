using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corner corner = new Corner(60,2,30);
            Console.WriteLine(corner.gradus);
            Console.WriteLine(corner.min);
            Console.WriteLine(corner.sec);
            corner.Radians();
            Console.ReadKey();
        }
    }
    class Corner
    {
        public double gradus;
        public int min;
        public int sec;


        public Corner(double gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
            if (min <= 0 || sec < 0)
            {
                Console.WriteLine("Ошибка!");
            }
        }

        public void Radians()
        {
            double r =  (Math.PI / 180) * gradus;
            Console.WriteLine("Радиан угла равен {0}", r);
        }
    }
}
