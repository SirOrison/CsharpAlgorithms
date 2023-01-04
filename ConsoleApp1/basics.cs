using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Basics
    {
        public int add(int num)
        {
            return num*num;
        }

        public int ThreeFactors(int num1,int num2,int num3)
        {
            return num1*num2*num3;
        }

        public int DivisionByZero(int num1,int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Cannot divide by 0");
                return 0;
            }
        }

        public void OrderOfPriority(int num)
        {
            Console.WriteLine("{0}", -6+num*5);
            Console.WriteLine("{0}", (13 - 2) * num);
            Console.WriteLine("{0}", (num + -2) * (20 / 10));
            Console.WriteLine("{0}", (12 + num) / (5 - 4));
        }

        public int Average(int num1, int num2, int num3, int num4)
        {
            return ((num1 + num2 + num3 + num4) / 4);
        }

        public void EquivalentOperations(int a, int b, int c)
        {
            int result1 = (a + b) * c;
            int result2 = a * c + b * c;
            Console.WriteLine("(a+b)*c = {0}", result1);
            Console.WriteLine("a * c + b*c = {0}", result2);
        }

        public void MathFunction(int num,int num2)
        {
            int results;
            for (int i = num; i < num2; i++)
            {
                results = i*i-2*i+ 1;
                Console.WriteLine("{0}", results);
            }
            
        }
    }
}
