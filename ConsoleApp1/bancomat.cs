namespace ConsoleApp1;

public class bancomat
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму для снятия");
        int n = int.Parse(Console.ReadLine() ?? "0");
        if (n <= 0)
        {
            Console.WriteLine("Меньше нуля снимать нельзя");
        }

        if (n % 100 != 0)
        {
            Console.WriteLine("Сумма должна быть кратна 100");
        }

        if (n > 150000)
        {
            Console.WriteLine("Сумма должна быть меньше 150 тысяч!");
        }

        int[] nominals = { 5000, 2000, 1000, 500, 200, 100 };
        int[] count = new int[nominals.Length];
        int ost = n;
        for (int i = 0; i < nominals.Length; i++)
        {
            count[i] = ost / nominals[i];
            ost %= nominals[i];
        }

        if (ost == 0)
        {
            Console.WriteLine($"Выдача {n} рублей возможна следующими купюрами: ");
            for (int i = 0; i < nominals.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.Write($"{nominals[i]} руб: {count[i]} шт. ");
                }
            }
        }
        else
        {
            Console.WriteLine($"Выдать ровно {n}  рублей невозможно");
        }
    }
}