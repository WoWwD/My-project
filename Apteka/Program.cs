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
        public static void Menu() //Меню программы
        {
            Console.WriteLine("1. Добавление препаратов");
            Console.WriteLine("2. Вывод всех препаратов");
            Console.WriteLine("3. Добавить один препарат");
            Console.WriteLine("4. Удалить последний добавленный препарат");
            Console.WriteLine("5. Добавить список препаратов в файл");
            Console.WriteLine("6. Добавить препараты из файла в список");
            Console.WriteLine("7. Поиск препаратов по производителю");
            Console.WriteLine("8. Сортировать методом подсчёта препараты по цене");
            Console.WriteLine("9. Построить диаграмму");
            Console.WriteLine("Escape. Выход");
        }
        [STAThread] //используется для запуска формы диаграммы через консоль
        static void Main(string[] args)
        {
            string path = @"..\..\..\apteka.txt";
            int N = 0; //количество структур
            Apteka[] d; //основной массив для хранения структур
            Apteka[] p; //массив для проверки входных данных
            Apteka[] p1; //дополнительный массив для хранения структур
            d = new Apteka[N];
          Menu: //метка для возврата
            Menu(); //вызов функции для вывода меню
            switch (Console.ReadKey(true).Key) //конструкция switch..case, которая считывает нажатия клавиш для выбора пунктов меню
            { 
                case ConsoleKey.D1: //если будет нажата клавиша "1", то выполнится функция добавления препаратов в основной массив
                {
                    Console.Clear();
                    Console.Write("Количество добавляемых препаратов: ");
                    N = Convert.ToInt32(Console.ReadLine());
                    d = new Apteka[N];
                    p = new Apteka[N];
                    Data.InputData(N, p, d); //вызов функции для ввода нескольких препаратов
                    Data.Show("Препараты добавлены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); //вызов функции показа сообщения
                    Console.Clear();
                    goto Menu;
                }
                case ConsoleKey.D2: //если будет нажата клавиша "2", то отобразится список всех препаратов
                { 
                    Console.Clear();
                    if (N != 0)
                    {
                        Data.OutputData(N, d); //вызов функции для вывода структур
                        Console.WriteLine("Нажмите Enter для возврата в меню");
                        Console.ReadKey();
                        Console.Clear();
                        goto Menu; 
                    }
                    Data.Show("Список препаратов пуст!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); //вызов функции показа сообщения
                    Console.Clear();
                    goto Menu;
                }
                case ConsoleKey.D3: //если будет нажата клавиша "3", то запустится функция для добавления одного препарата в основной массив
                { 
                    Console.Clear();
                    N++; //увеличение количества препаратов на 1
                    p = new Apteka[N];
                    p1 = new Apteka[N];
                    for (int i = 0; i < N - 1; i++)
                    {
                        p1[i] = d[i]; //перенос структур в дополнительный массив
                    }
                    d = new Apteka[N]; 
                    Data.InputDataOne(N, p, p1); //вызов функции для ввода одного препарата
                    for (int i = 0; i < N; i++)
                    {
                        d[i] = p1[i]; //перенос структур из дополнительного массива в основной
                    }
                    Data.Show("Препарат добавлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); //вызов функции показа сообщения
                    Console.Clear();
                    goto Menu;
                }
                case ConsoleKey.D4: //если будет нажата клавиша "4", то запустится функция для удаления одного препарата из основного массива
                {
                    Console.Clear();
                    if (N != 0)
                    {
                        N--; //уменьшение количества препаратов на 1
                        p1 = new Apteka[N];
                        for (int i = 0; i < N; i++)
                        {
                            p1[i] = d[i]; //перенос структур в дополнительный массив
                        }
                        d = new Apteka[N];
                        for (int i = 0; i < N; i++)
                        {
                            d[i] = p1[i]; //перенос структур из дополнительного массива в основной
                        }
                        Data.Show("Последний добавленный препарат был удалён!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); //вызов функции показа сообщения
                        Console.Clear();
                        goto Menu; 
                    }
                    else
                    {
                        Data.Show("Список препаратов пуст!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); //вызов функции показа сообщения
                        goto Menu;
                    }
                }
                case ConsoleKey.D5: //если будет нажата клавиша "5", то выполнится запись всех препаратов в основном массиве в файл
                {
                    Console.Clear();
                    if (N != 0)
                    {
                        Data.WriteToFile(d, path); //вызов функции для записи структур в файл
                        Data.Show("Препараты были сохранены в файл 'Apteka.txt' !", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); //вызов функции показа сообщения
                        Console.Clear();
                        goto Menu;
                    }
                    else
                    {
                        Data.Show("Список препаратов пуст!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); //вызов функции показа сообщения
                        goto Menu;
                    }
                }
                case ConsoleKey.D6: //если будет нажата клавиша "6", то все препараты будут добавлены из файла в основной массив 
                {
                    Console.Clear();
                    Data.ReadFrFile(out N,  out d, path); //вызов функции для записи структур из файла в основной массив
                    if (new FileInfo(path).Length == 0)
                    {
                        Data.Show("Файл пустой!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); //вызов функции показа сообщения
                        goto Menu; 
                    }
                    Data.Show("Препараты были добавлены в список!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); //вызов функции показа сообщения
                    Console.Clear();
                    goto Menu; 
                }
                case ConsoleKey.D7: //если будет нажата клавиша "7", то выполнится запуск функции для поиска препаратов
                {
                    Console.Clear();
                    if (N != 0)
                    {
                        Data.SearchData(N, d); //вызов функции для поиска структур по проивзодителю
                        Console.WriteLine("Нажмите Enter для возврата в меню");
                        Console.ReadKey();
                        Console.Clear();
                        goto Menu; 
                    }
                    else
                    {
                        Data.Show("Список препаратов пуст!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); //вызов функции показа сообщения
                        goto Menu; 
                    }
                }
                case ConsoleKey.D8: //если будет нажата клавиша "8", то выполнится запуск сортировки препаратов
                {
                    Console.Clear();
                    if (N != 0)
                    {
                        Data.Sort(d, 10000, N); //вызов функции сортировки методом подсчёта
                        Data.Show("Сортировка выполнена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); //вызов функции показа сообщения
                        Console.Clear();
                        goto Menu;
                    }
                    else
                    {
                        Data.Show("Список препаратов пуст!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); //вызов функции показа сообщения
                        goto Menu; 
                    }
                }
                //case ConsoleKey.D9: //если будет нажата клавиша "9", то выполнится запуск диаграммы
                //{
                       // Application.EnableVisualStyles();
                       // Application.Run(new KP.AptekaChart());
                   // Console.Clear();
                   // goto Menu; 
                //}
                case ConsoleKey.Escape: //если будет нажата клавиша "Escape", то будет осуществлён выход из программы
                { 
                    break; //выход из программы
                }
                default:
                    Console.Clear();
                    goto Menu;
            }
        }
    }
}
