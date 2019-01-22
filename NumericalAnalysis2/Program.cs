using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NumericalAnalysis2
{
    class ModifiedNewtonsMethod
    {
        private const int maximumNumberOfIterations = 25;  //sets the maximum number of iterations to 25
        private const double x0 = 3;  //x0 = 3

        //initial getters and setters for Xn, Error and M
        public static double Xn { get; set; } 
        public static double Error { get; set; }
        public static int M { get; set; }

        /// <summary>
        /// Finds all intermediate points and backwards errors when m=1
        /// </summary>
        public static void SolverM1()
        {
            WriteLine("When x0=3 and m=1");
            Xn = x0;
            M = 1;
            for (int i = 1; i <= maximumNumberOfIterations; i++)
            {
                Error = Function(Xn);
                Xn = Xn - (M * Function(Xn) / DerivativeOfFunction(Xn));
                WriteLine("x" + i + "=" + Xn + " backward error = " + Error);
                if (Function(Xn) < Math.Pow(10, -12))
                {
                    break;
                }
            }
            WriteLine("");
        }


        /// <summary>
        /// Finds all intermediate points and backwards errors when m=2
        /// </summary>
        public static void SolverM2()
        {
            WriteLine("When x0 = 3 and m=2");
            Xn = x0;
            M = 2;
            for (int i = 1; i <= maximumNumberOfIterations; i++)
            {
                Error = Function(Xn);
                Xn = Xn - (M * Function(Xn) / DerivativeOfFunction(Xn));
                WriteLine("x" + i + "=" + Xn + " backward error = " + Error);
                if (Function(Xn) < Math.Pow(10, -12))
                {
                    break;
                }
            }
            WriteLine("");
            ReadLine();
        }

        public static double Function(double x)
        {
            return x * x * x - 3 * x * x + 4;
        }

        public static double DerivativeOfFunction(double x)
        {
            return 3 * x * x - 6 * x;
        }

        private static void Main(string[] args)
        {
            SolverM1();
            SolverM2();
        }
    }
}
