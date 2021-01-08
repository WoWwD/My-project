using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public struct Apteka //структура, содержащая поля 
    {
        public string name; //название 
        public string manufact; // производитель
        public double price; //цена 
        public int discount; // скидка 
        public double discountedPrice; //цена с учётом скидки 
        public void OutputDataStruct() //функция для вывода одной структуры
        {
            Console.WriteLine($"Название препарата: {name}, Производитель: {manufact}, Цена: {price} руб., Скидка: {discount} %, Цена со скидкой: {discountedPrice} руб.");
        }
    }
    public static class Data //класс, содержащий необходимые функции
    {
        public static void InputData(int N, Apteka[] p, Apteka[] d) // функция для проверки ввода и ввода N структур
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
             a1: //метка для возврата если введены не буквы
                Console.Write("Название препарата: ");
                p[i].name = Console.ReadLine();
                foreach (char c in p[i].name) //цикл для проверки ввода только букв
                {
                    if (char.IsLetter(c)) 
                    {
                        d[i].name = p[i].name;
                    }
                    else
                    {
                        Show("Строка должна содержать только буквы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                        Console.WriteLine("----------------------");
                        goto a1;
                    }                   
                }
             a2: //метка для возврата если введены не буквы
                Console.Write("Производитель: ");
                p[i].manufact = Console.ReadLine();
                foreach (char c in p[i].manufact) //цикл для проверки ввода только букв
                {
                    if (char.IsLetter(c))
                    {
                        d[i].manufact = p[i].manufact;
                    }
                    else
                    {
                        Show("Строка должна содержать буквы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                        Console.WriteLine("----------------------");
                        goto a2;
                    }
                }
            a3: //метка для возврата если введены не цифры
                Console.Write("Цена (руб.): ");
                if(!double.TryParse(Console.ReadLine(), out p[i].price)) //условие для проверки ввода только цифр
                {
                    Show("Нужно ввести число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                    Console.WriteLine("----------------------");
                    goto a3;
                }
                if (p[i].price > 0 && p[i].price < 10001) //условие для проверки диапазона введённой цены
                {
                    d[i].price = p[i].price;
                }
                else
                {
                    Show("Цена должна быть от 1 до 10000 (руб.)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                    Console.WriteLine("----------------------");
                    goto a3;
                }
             a4: //метка для возврата если введены не цифры
                Console.Write("Скидка (%): ");
                if (!int.TryParse(Console.ReadLine(), out p[i].discount))  //условие для проверки ввода только цифр
                {
                    Show("Нужно ввести число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                    Console.WriteLine("----------------------");
                    goto a4;
                }
                if (p[i].discount > 0 && p[i].discount < 101) //условие для проверки диапазона введённой скидки
                {
                    d[i].discount = p[i].discount;
                    d[i].discountedPrice = d[i].price - (d[i].price * d[i].discount) / 100; // вычисление цены со скидкой
                    Console.Write($"Цена со скидкой (руб.): {d[i].discountedPrice}");
                }
                else
                {
                    Show("Скидка должна быть от 1 до 100 (%)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                    Console.WriteLine("----------------------");
                    goto a4;
                }
                Console.WriteLine();
            }
        }
        public static void InputDataOne(int N, Apteka[] p, Apteka[] p1) //функция для проверки ввода и ввода одной структуры
        {
            int i = N - 1;
            Console.WriteLine();
         a1: //метка для возврата если введены не буквы
            Console.Write("Название препарата: ");
            p[i].name = Console.ReadLine();
            foreach (char c in p[i].name)
            {
                if (char.IsLetter(c)) //цикл для проверки ввода только букв
                {
                    p1[i].name = p[i].name;
                }
                else
                {
                    Show("Строка должна содержать только буквы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                    Console.WriteLine("----------------------");
                    goto a1;
                }

            }
         a2: //метка для возврата если введены не буквы
            Console.Write("Производитель: ");
            p[i].manufact = Console.ReadLine();
            foreach (char c in p[i].manufact) 
            {
                if (char.IsLetter(c)) //цикл для проверки ввода только букв
                {
                    p1[i].manufact = p[i].manufact;
                }
                else
                {
                    Show("Строка должна содержать только буквы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                    Console.WriteLine("----------------------");
                    goto a2;
                }

            }
         a3: //метка для возврата если введены не цифры
            Console.Write("Цена (руб.): ");
            if (!double.TryParse(Console.ReadLine(), out p[i].price)) //условие для проверки ввода только цифр
            {
                Show("Нужно ввести число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                Console.WriteLine("----------------------");
                goto a3;
            }
            if (p[i].price > 0 && p[i].price < 10001) //условие для проверки диапазона введённой цены
            {
                p1[i].price = p[i].price;
            }
            else
            {
                Show("Цена должна быть от 1 до 10000 (руб.)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                Console.WriteLine("----------------------");
                goto a3;
            }
         a4: //метка для возврата если введены не цифры
            Console.Write("Скидка (%): ");
            if (!int.TryParse(Console.ReadLine(), out p[i].discount)) //условие для проверки ввода только цифр
            {
                Show("Нужно ввести число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                Console.WriteLine("----------------------");
                goto a4;
            }
            if (p[i].discount > 0 && p[i].discount < 101) //условие для проверки диапазона введённой скидки
            {
                p1[i].discount = p[i].discount;
                p1[i].discountedPrice = p1[i].price - ((p1[i].price * p1[i].discount) / 100); // вычисление цены со скидкой
                Console.Write($"Цена со скидкой (руб.): {p1[i].discountedPrice}");
            }
            else
            {
                Show("Скидка должна быть от 1 до 100 (%)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); //вызов функции показа сообщения
                Console.WriteLine("----------------------");
                goto a4;
            }
            Console.WriteLine();
        }
        public static void OutputData(int N, Apteka[] d) //функция для вывода всех структур
        {
            Console.Write("Список препаратов: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                d[i].OutputDataStruct();
            }
        }
        public static void WriteToFile(Apteka[] d, string path) //функция для записи структур в файл
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (Apteka s in d) //цикл для записи в файл построчно структур с разделяющим символом "/"
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
        public static void ReadFrFile(out int N, out Apteka[] d, string path) //функция для считывания структур из файла и записи их в массив структур
        {
            using (StreamReader reader1 = new StreamReader(path))
            {
                N = 0;
                string str1;
                while ((str1 = reader1.ReadLine()) != null) //цикл для подсчёта количества структур построчно по разделяющему символу "/"
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
                string line;
                for (int i = 0; i < N; i++)
                {
                    while ((line = reader2.ReadLine()) != null) //поиск строк в файле построчно по ключевым словам и запись их в соответствующее поле структуры 
                    {
                        if (line.Contains("Название препарата:"))
                        {
                            line = line.Substring(line.IndexOf(':') + 1); 
                            d[i].name = line.Replace(" ", "");
                        }
                        if (line.Contains("Производитель:"))
                        {
                            line = line.Substring(line.IndexOf(':') + 1);
                            d[i].manufact = line.Replace(" ", "");
                        }
                        if (line.Contains("Цена (руб.):"))
                        {
                            line = line.Substring(line.IndexOf(':') + 1);
                            d[i].price = Convert.ToInt32(line);
                        }
                        if (line.Contains("Скидка (%):"))
                        {
                            line = line.Substring(line.IndexOf(':') + 1);
                            d[i].discount = Convert.ToInt32(line);
                        }
                        if (line.Contains("Цена со скидкой (руб.):"))
                        {
                            line = line.Substring(line.IndexOf(':') + 1);
                            d[i].discountedPrice = d[i].price - (d[i].price * d[i].discount) / 100;
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
        public static void SearchData(int N, Apteka[] d) //функция для поиска структур по производителю и их вывода
        {
            string str;
            int n = 0;
            Console.Write("Введите производителя: ");
            str = Console.ReadLine();
            for (int i = 0; i < N; i++)
            {
                if (str == d[i].manufact) //условие для проверки совпадения введённой строки с полем структуры
                {
                    Console.Write("Найденные препараты: ");
                    d[i].OutputDataStruct();
                    n++;
                }
            }
            if (n == 0)
            {
                Console.WriteLine("Таких товаров не найдено!");
            }
        }
        public static void Sort(Apteka[] d, int k, int N) //функция для сортировки полей структуры по цене методом подсчёта
        {
            var index = 0; //переменная для хранения элементов с нулевого индекса
            var count = new int[k + 1]; //массив ключей
            for (int j = 0; j < N; j++) //увеличение индексов, соответствующих элементам входного массива, на 1
            {
                count[(int)d[j].price]++;
            }
            for (int t = 0; t < count.Length; t++) // увеличение "t" на 1, пока она не больше размера (k) массива ключей
            {                                      // если t равна элементу в массиве ключей, то полю "цена"
                for (int w = 0; w < count[t]; w++) //  присвоить значение "t" с индексом "index"
                {    
                    for (int i = N - 1; i > 0; i--) //шаги по строкам
                    {
                        for (int j = 0; j < i; j++) //шаги по столбцам
                        {
                            if (d[j].price == t) //изменение расположения полей относительно сортируемого поля "цена"
                            {
                                string n = d[index].name;
                                d[index].name = d[j].name;
                                d[j].name = n;

                                string m = d[index].manufact;
                                d[index].manufact = d[j].manufact;
                                d[j].manufact = m;

                                double p = d[index].price;
                                d[index].price = d[j].price;
                                d[j].price = p;

                                int dis = d[index].discount;
                                d[index].discount = d[j].discount;
                                d[j].discount = dis;

                                double dp = d[index].discountedPrice;
                                d[index].discountedPrice = d[j].discountedPrice;
                                d[j].discountedPrice = dp;
                            }
                        }
                    }
                    index++;
                }
            }
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) //функция для вызова сообщений
        {
            return MessageBox.Show(text, caption, buttons, icon);
        }
    }
}