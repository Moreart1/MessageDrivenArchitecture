using System.Diagnostics;


namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var restaurant = new Hall();
            while (true)
            {
                Console.WriteLine("Привет! Желаете забронировать или освободить столик?\n" +
                                  "1 - забронировать, мы уведомим Вас по смс (асинхронно)\n" +
                                  "2 - забронировать, подождите на линии, мы Вас оповестим (синхронно)\n" +
                                  "3 - освободить, мы уведомим Вас по смс (асинхронно)\n" +
                                  "4 - освободить, подождите на линии, мы Вас оповестим (синхронно)\n"
                                  );

                var choiceValid = int.TryParse(Console.ReadLine(), out var choice);
                if (!choiceValid || (choiceValid && choice is < 1 or > 4))
                {
                    Console.WriteLine("Введите, пожалуйста от 1 до 4");
                    continue;
                }

                var stopWatch = new Stopwatch();
                stopWatch.Start();

                switch (choice)
                {
                    case 1:
                        restaurant.BookFreeTableAsync(1);
                        break;
                    case 2:
                        restaurant.BookFreeTable(1);
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("Укажите номер столика");
                        int.TryParse(Console.ReadLine(), out var tableId);
                        if (choice == 3)
                        {
                            restaurant.FreeTableAsync(tableId);
                        }
                        else
                        {
                            restaurant.FreeTable(tableId);
                        }
                        break;
                }

                Console.WriteLine("Спасибо за Ваше обращение!");
                stopWatch.Stop();
                var timeSpan = stopWatch.Elapsed;
                Console.WriteLine($"{timeSpan.Seconds:00}:{timeSpan.Milliseconds:00}");
            }
        }
    }
}