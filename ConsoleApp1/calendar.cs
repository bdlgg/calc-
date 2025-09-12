namespace ConsoleApp1;

public class calendar
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите номер дня недели с которого начинается месяц (1-пн, ..., 7-вс ): ");
        int startDay = int.Parse(Console.ReadLine() ?? "0");
        if (startDay < 1 || startDay > 7)
        {
            Console.WriteLine("Ошибка, дни недели должны быть  от 1-7");
            return;
        }
        Console.WriteLine("введите день месяца: ");
        int day = int.Parse(Console.ReadLine() ?? "0");
        if (day < 1 || day > 31)
        {
            Console.WriteLine("Ошибка, дни должны быть от 1-31");
            return;
        }
        int weekday = (startDay + day - 1) % 7;
        if (weekday == 0) weekday = 7;
        bool holiday = (day >= 1 && day <= 7) || (day >= 8 && day <= 10);
        bool weeknd = (weekday == 6 || weekday == 7);
        Console.WriteLine("-----Проверяем выходной ли день");
        switch (true)
        {
            case true when holiday:
                Console.WriteLine("Выходной день (Праздничный)");
                break;
            case true when weeknd:
                Console.WriteLine("Выходной день (Суббота/Воскресенье)");
                break;
            default:
                Console.WriteLine("Рабочий день :(");
                break;
        }
    }
}