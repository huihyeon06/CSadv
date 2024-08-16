﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSadv
{
    class Wanted<T>
    {
        public T Value;

        public Wanted(T value)
        {
            this.Value = value;
        }

        class WantedTest<T, U>
             where T : IComparable
             where U : IComparable, IDisposable
        {

        }

        class SquareCalculator
        {
            public int this[int i]
            {
                get
                {
                    return i;
                }
                set
                {
                    Console.WriteLine("{i}번째 상품 설정", i);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("string");
            Wanted<int> wantedint = new Wanted<int>(52273);
            Wanted<double> wantedDouble = new Wanted<double>(52.273);

            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedint.Value);
            Console.WriteLine(wantedDouble.Value);

            SquareCalculator sc = new SquareCalculator();
            Console.WriteLine(sc[10]);
            Console.WriteLine(sc[11]);
            Console.WriteLine(sc[40]);
            sc[3] = 4;
        }
    }
}
