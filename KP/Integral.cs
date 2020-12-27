using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public static class Integral 
    {
        public static void CalcInteg(double UpLimit, double LowLimit, int Segments, out double Res)
        {
            double h;
            h = (UpLimit - LowLimit) / Segments;
            Res = 0.5 * (FuncInteg(LowLimit) + FuncInteg(UpLimit));
            for (int i = 1; i < Segments; i++)
            {
                Res += FuncInteg(LowLimit + h * i);
            }
            Res *= h;
        }
        public static double FuncInteg(double x)
        {
            return Math.Cos(Math.Pow(x,0.5));
        }
    }
}
