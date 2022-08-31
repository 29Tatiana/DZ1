Console.WriteLine("Введите два числа");
string number1 = Console.ReadLine();
string number2 = Console.ReadLine();
int a = int.Parse(number1);
int b = int.Parse(number2);
if (a > b)
    Console.WriteLine("min=" + b + ", max=" + a);
else
    Console.WriteLine("min=" + a + ", max=" + b);
