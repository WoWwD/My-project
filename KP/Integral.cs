using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public static class Integral 
    {
        public static void CalcInteg(int UpLimit, int LowLimit, double Segments, double eps, out double Res) //функция для вычисления интеграла методов трапеций
        {
            double h;
            h = (UpLimit - LowLimit) / Segments; //вычисление шага (разбиение отрезка интегрирования на трапеции)
            Res = eps * (FuncInteg(LowLimit) + FuncInteg(UpLimit));
            for (int i = 1; i < Segments; i++) // суммирование результата с каждым шагом
            {
                Res += FuncInteg(LowLimit + h * i);
            }
            Res *= h;
        }
        public static double FuncInteg(double x) //функция, которая возвращает функцию интеграла
        {
            return Math.Cos(Math.Pow(Math.Abs(x),0.5));
        }
    }
}