using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITBIT

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int menu = 0;
                List<Count> counts = new List<Count>();
                do
                {
                    Console.WriteLine("1. Добавить счёт");
                    Console.WriteLine("2. Посмотреть счёта");
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Введите имя счёта");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите номер счёта");
                            int number = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите сумму счёта");
                            double sum = Convert.ToDouble(Console.ReadLine());
                            counts.Add(new Count(name, number, sum));
                            break;
                        case 2:
                            Console.Write("Имя");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].name);
                            }
                            Console.WriteLine();
                            Console.Write("Номер");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].number);
                            }
                            Console.WriteLine();
                            Console.Write("Сумма");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].sum);
                            }
                            Console.ReadKey();
                            break;
                    }
                } while (menu < 3);
                Console.ReadKey();
            }
            catch { }

        }
    }
}
