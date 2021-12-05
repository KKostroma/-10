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
            Corner corner = new Corner(600,800,30);
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

        public double Gradus
        {
            set
            {
                if (value < 500)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Градус не может быть больше 500");
                }
            }
            get
            {
                return gradus;  
            }
        }

        public double Min
        {
            set
            {
                if (value < 700)
                {
                    min = (int)value;
                }
                else
                {
                    Console.WriteLine("Минут не может быть больше 700");
                }
            }
            get
            {
                return min;
            }
        }

        public Corner(double gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
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
