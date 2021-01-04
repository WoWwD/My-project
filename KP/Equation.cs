using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public static class Equation
    {
        public static int nMax = 10;
        public static void CalcEquat(double X0, double Eps, out double Res, out double nRes)
        {
            string path = @"D:\\log.txt";
            double x1;
            int n = 1; 
            x1 = X0 - (FuncEquat(X0) / dFuncEquat(X0));
            StreamWriter sw = new StreamWriter(path);
            while (Math.Abs(x1 - X0) >= Eps && n <= nMax)
            {
                n++;
                sw.WriteLine(x1);
                X0 = x1;
                x1 = X0 - ((FuncEquat(X0) / dFuncEquat(X0)));
            }
            sw.WriteLine(x1);
            sw.Close();
            Res = x1;
            nRes = n;
        }
        public static double FuncEquat(double x)
        {
            return Math.Log(x) - Math.Sqrt(4 - x);
        }
        public static double dFuncEquat(double x)
        {
            return (1 / (2 * Math.Sqrt(4 - x))) + (1 / x);
        }
    }
}
