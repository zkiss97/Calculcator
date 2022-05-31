using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Khalculator
    {
        private double A;
        private double B;
        private char X;

        public Khalculator()
        {        }

        public double Addition(double A, double B)
        {
            return A + B;
        }

        public double Subtraction(double A, double B)
        {
            return A - B;
        }

        public double Multiplication(double A, double B)
        {
            return A * B;
        }

        public double Division(double A, double B)
        {
            return A / B;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string x;

            Khalculator k1 = new Khalculator();

            Console.WriteLine("Infix módon add meg az adatokat:");
            Console.WriteLine("Egyik szám:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Műveleti jel:");
            x = Console.ReadLine();

            Console.WriteLine("Másik szám:");
            b = double.Parse(Console.ReadLine());

            if (x == "+")
            {
                Console.WriteLine(k1.Addition(a, b));
            }
            else if (x == "-")
            {
                Console.WriteLine(k1.Subtraction(a, b));
            }
            else if (x == "*")
            {
                Console.WriteLine(k1.Multiplication(a, b));
            }
            else if (x == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("Nullával nem osztunk");
                }
                else Console.WriteLine(k1.Division(a, b));
            }
            else
            {
                Console.WriteLine("Érvénytelen művelet");
            }

                Console.ReadLine();
        }
    }
}
