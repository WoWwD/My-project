using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("1. Добавление товаров");
            Console.WriteLine("2. Вывод всех товаров");
            Console.WriteLine("3. Добавить один товар");
            Console.WriteLine("4. Удалить последний добавленный товар");
            Console.WriteLine("5. Добавить товары в файл");
            Console.WriteLine("6. Чтение из файла");
            Console.WriteLine("7. Поиск товаров по производителю");
            Console.WriteLine("8. Сортировка");
            Console.WriteLine("9. Построить диаграмму");
            Console.WriteLine("Escape. Выход");
        }

        //метод для получения массива заполненного случайными числами
        [STAThread]
        static void Main(string[] args)
        {
            int N = 0;
            Apteka[] d;
            Apteka[] p;
            d = new Apteka[N];
            p = new Apteka[N];
        Menu:
            try
            {
                Menu();
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:{
                            Console.Clear();
                            Console.Write("Количество добавляемых товаров: ");
                            N = Convert.ToInt32(Console.ReadLine());
                            d = new Apteka[N];
                            Data.InputData(N, d);
                            MessageBox.Show("Товары добавлены!");
                            Console.Clear();
                            goto Menu;
                        }
                    case ConsoleKey.D2:{
                            Console.Clear();
                            if (N != 0)
                            {
                                Data.OutputData(N, d);
                                Console.WriteLine("Нажмите Enter для возврата в меню");
                                Console.ReadKey();
                                Console.Clear();
                                goto Menu;
                            }
                            else
                            {
                                Console.WriteLine("Список товаров пуст!");
                                Console.WriteLine("Нажмите Enter для возврата в меню");
                                Console.ReadKey();
                                Console.Clear();
                                goto Menu;
                            }
                        }
                    case ConsoleKey.D3:{
                            Console.Clear();
                            N = N + 1;
                            p = new Apteka[N];
                            for (int i = 0; i < N - 1; i++)
                                p[i] = d[i];
                            d = new Apteka[N];
                            Data.InputDataOne(N, p);
                            for (int i = 0; i < N; i++)
                                d[i] = p[i];
                            MessageBox.Show("Товар добавлен!");
                            Console.Clear();
                            goto Menu;
                        }
                    case ConsoleKey.D4:{
                            Console.Clear();
                            if (N > 0)
                            {
                                N = N - 1;
                                p = new Apteka[N];
                                for (int i = 0; i < N; i++)
                                    p[i] = d[i];
                                d = new Apteka[N];
                                for (int i = 0; i < N; i++)
                                    d[i] = p[i];
                                MessageBox.Show("Последний добавленный товар удалён!");
                                Console.Clear();
                                goto Menu;
                            }
                            else
                            {
                                Console.WriteLine("Список товаров пуст!");
                                Console.WriteLine("Нажмите Enter для возврата в меню");
                                Console.ReadKey();
                                Console.Clear();
                                goto Menu;
                            }
                        }
                    case ConsoleKey.D5:{
                            Console.Clear();
                            if (N != 0)
                            {
                                Data.WriteToFile(d, @"D:\\apteka.txt");
                                MessageBox.Show("Товары были сохранены в файл Apteka.txt!");
                                goto Menu;
                            }
                            else
                            {
                                Console.WriteLine("Список товаров пуст!");
                                Console.WriteLine("Нажмите Enter для возврата в меню");
                                Console.ReadKey();
                                Console.Clear();
                                goto Menu;
                            }
                        }
                    case ConsoleKey.D6:{
                            Console.Clear();
                            Data.ReadFrFile(out N, out d, @"D:\\apteka.txt");
                            if (new FileInfo(@"D:\\apteka.txt").Length == 0)
                            {
                                Console.WriteLine("Файл пустой!");
                                Console.WriteLine("Нажмите Enter для возврата в меню");
                                Console.ReadKey();
                                Console.Clear();
                                goto Menu;
                            }
                            MessageBox.Show("Товары добавлены из файла в список!");
                            Console.WriteLine("Список добавленных товаров: ");
                            for (int i = 0; i < N; i++)
                            {
                                Console.WriteLine();
                                d[i].OutputDataStruct();
                            }
                            Console.WriteLine("Нажмите Enter для возврата в меню");
                            Console.ReadKey();
                            Console.Clear();
                            goto Menu;
                        }
                    case ConsoleKey.D7:{
                            Console.Clear();
                            if (N != 0)
                            {
                                Data.SearchData(N, d);
                                Console.WriteLine("Нажмите Enter для возврата в меню");
                                Console.ReadKey();
                                Console.Clear();
                                goto Menu;
                            }
                            else
                            {
                                Console.WriteLine("Список товаров пуст!");
                                Console.WriteLine("Нажмите Enter для возврата в меню");
                                Console.ReadKey();
                                Console.Clear();
                                goto Menu;
                            }
                        }
                    case ConsoleKey.D8:{
                            Console.Clear();
                            if (N != 0)
                            {
                                Data.Sort(d, 100, N);
                                Console.WriteLine("Сортировка выполнена!");
                                Console.WriteLine("Нажмите Enter для возврата в меню");
                                Console.ReadKey();
                                Console.Clear();
                                Console.ReadLine();
                                goto Menu;
                            }
                            else
                            {
                                Console.WriteLine("Список товаров пуст!");
                                Console.WriteLine("Нажмите Enter для возврата в меню");
                                Console.ReadKey();
                                Console.Clear();
                                goto Menu;
                            }
                        }
                    case ConsoleKey.D9:{
                            Application.EnableVisualStyles();
                            Application.Run(new KP.AptekaChart());
                            Console.Clear();
                            goto Menu;
                        }
                    case ConsoleKey.Escape: { break; }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine("Нажмите Enter для возврата в меню");
                Console.ReadKey();
                Console.Clear();
                goto Menu;
            }
        }
        
    }
}
