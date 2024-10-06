using System;

class Program
{
    static void Main()
    {
        // Ввод данных из таблицы
        Console.Write("Введите название передачи: ");
        string nazvanie = Console.ReadLine();
        Console.Write("Введите имя ведущего: ");
        string vedushiy = Console.ReadLine();
        Console.Write("Введите рейтинг передачи: ");
        int reiting = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите тип передачи (И, А, Т): ");
        string tip = Console.ReadLine();

        // Вывод форматированной таблицы на экран
        Console.WriteLine("Телепередачи");
        Console.WriteLine("------------");
        Console.WriteLine("Передача\tВедущий\tРейтинг\tТип");
        Console.WriteLine("------------");
        Console.WriteLine($"{nazvanie}\t{vedushiy}\t{reiting}\t{tip}");
        Console.WriteLine("------------");
        Console.WriteLine("Примечания:");
        Console.WriteLine("И - игровая");
        Console.WriteLine("А - аналитическая");
        Console.WriteLine("Т - ток-шоу");
    }
}
