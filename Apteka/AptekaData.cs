using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka
{ 
    public struct Apteka
    {
        public string name;
        public string manufact;
        public double price;
        public double discount;
        public double discountedPrice;
        public Apteka(string name, string manufact, double price, double discount, double discountedPrice)
        {
            this.name = name;
            this.manufact = manufact;
            this.price = price;
            this.discount = discount;
            this.discountedPrice = discountedPrice;
        }
        public void OutputDataStruct()
        {
            Console.WriteLine($"Название препарата: {name}, Производитель: {manufact}, Цена: {price} руб., Скидка: {discount} %, Цена со скидкой: {discountedPrice} руб.");
        }
    }
    public static class Data
    {
        public static void InputData(int N, Apteka[] d)
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                Console.Write("Название препарата: ");
                d[i].name = Console.ReadLine();
                Console.Write("Производитель: ");
                d[i].manufact = Console.ReadLine();
                Console.Write("Цена (руб.): ");
                d[i].price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Скидка (%): ");
                d[i].discount = Convert.ToDouble(Console.ReadLine());
                d[i].discountedPrice = d[i].price - (d[i].price * d[i].discount) / 100;
                Console.Write($"Цена со скидкой (руб.): {d[i].discountedPrice}");
                Console.WriteLine();
            }
        }
        public static void InputDataOne(int N, Apteka[] d)
        {
            int i = N - 1;
            Console.WriteLine();
            Console.Write("Название препарата: ");
            d[i].name = Console.ReadLine();
            Console.Write("Производитель: ");
            d[i].manufact = Console.ReadLine();
            Console.Write("Цена (руб.): ");
            d[i].price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Скидка (%): ");
            d[i].discount = Convert.ToDouble(Console.ReadLine());
            d[i].discountedPrice = d[i].price - (d[i].price * d[i].discount) / 100;
            Console.Write($"Цена со скидкой (руб.): {d[i].discountedPrice}");
            Console.WriteLine();
        }
        public static void OutputData(int N, Apteka[] d)
        {
            Console.Write("Список товаров: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                d[i].OutputDataStruct();
            }
        }
        public static void WriteToFile(Apteka[] d, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {  
                foreach (Apteka s in d)
                {
                    writer.WriteLine($"Название препарата: {s.name}");
                    writer.WriteLine($"Производитель: {s.manufact}");
                    writer.WriteLine($"Цена (руб.): {s.price}");
                    writer.WriteLine($"Скидка (%): {s.discount}");
                    writer.WriteLine($"Цена со скидкой (руб.): {s.discountedPrice}\n/");
                }
                writer.Close();
            }
        }
        public static void ReadFrFile(out int N, out Apteka[] d, string path)
        {
            using (StreamReader reader1 = new StreamReader(path))
            {
                N = 0;
                string str1;
                while ((str1 = reader1.ReadLine()) != null)
                {
                    if (str1.Contains('/'))
                    {
                        N++;
                    }
                }
                reader1.Close();
            }
            d = new Apteka[N];
            using (StreamReader reader2 = new StreamReader(path))
            {
                string str2, line;
                for (int i = 0; i < N; i++)
                {
                    while ((line = reader2.ReadLine()) != null)
                    {
                        if (line.Contains("Название препарата:"))
                        {
                            str2 = line;
                            str2 = str2.Substring(str2.IndexOf(':') + 1);
                            d[i].name = str2.Replace(" ", "");
                        }
                        if (line.Contains("Производитель:"))
                        {
                            str2 = line;
                            str2 = str2.Substring(str2.IndexOf(':') + 1);
                            d[i].manufact = str2.Replace(" ", "");
                        }
                        if (line.Contains("Цена (руб.):"))
                        {
                            str2 = line;
                            str2 = str2.Substring(str2.IndexOf(':') + 1);
                            d[i].price = Convert.ToDouble(str2);
                        }
                        if (line.Contains("Скидка (%):"))
                        {
                            str2 = line;
                            str2 = str2.Substring(str2.IndexOf(':') + 1);
                            d[i].discount = Convert.ToDouble(str2);
                        }
                        if (line.Contains("Цена со скидкой (руб.):"))
                        {
                            str2 = line;
                            str2 = str2.Substring(str2.IndexOf(':') + 1);
                            d[i].discountedPrice = d[i].price-(d[i].price* d[i].discount)/100;
                        }
                        if (line.Contains('/'))
                        {
                            break;
                        }
                    }
                }
                reader2.Close();
            }
        }
        public static void SearchData(int N,Apteka[] d)
        {
            string atr;
            int n = 0;
            Console.Write("Введите производителя: ");
            atr = Console.ReadLine();
            for (int i = 0; i < N; i++)
            {
                if (atr == d[i].manufact)
                {
                    Console.Write("Найденные товары: ");
                    d[i].OutputDataStruct();
                    n++;
                }
            }
            if (n == 0)
            {
                Console.WriteLine("Таких товаров не найдено!");
            }
        }
        
    }
}