internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите три числа");
        string number1 = Console.ReadLine();
        string number2 = Console.ReadLine();
        string number3 = Console.ReadLine();
        int a = int.Parse(number1);
        int b = int.Parse(number2);
        int c = int.Parse(number3);
        int max = a;
        if (b > max)
            max = b;
        if (c > max)
            max = c;
        Console.WriteLine(max);
    }
}
