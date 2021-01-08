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
        public static int nMax = 10; //максимальное значений итераций
        public static void CalcEquat(double x0, double Eps, out double Res, out int nRes) //функция для вычисления уравнения по методу Ньютона
        {
            string path = @"..\..\..\log.txt";
            double x1;
            int n = 1; 
            x1 = x0 - (FuncEquat(x0) / dFuncEquat(x0));
            StreamWriter sw = new StreamWriter(path);
            while ((x1 - x0) >= Eps && n <= nMax)
            {
                n++;
                sw.WriteLine($"x{n-1} = {x1},  F(x) = {FuncEquat(x0)},  dF(x) = {dFuncEquat(x0)}\n"); //запись результатов построчно в файл
                x0 = x1;
                x1 = x0 - ((FuncEquat(x0) / dFuncEquat(x0)));
            }
            sw.WriteLine($"x{n} = {x1},  F(x) = {FuncEquat(x0)},  dF(x) = {dFuncEquat(x0)}\n"); //запись результатов построчно в файл
            sw.Close();
            Res = x1;
            nRes = n;
        }
        public static double FuncEquat(double x) //функция, которая возвращает функцию уравнения
        {
            return Math.Log(x) - Math.Sqrt(4 - x);
        }
        public static double dFuncEquat(double x) //функция, которая возвращает производную функции уравнения
        {
            return (1 / (2 * Math.Sqrt(4 - x))) + (1 / x);
        }
    }
}