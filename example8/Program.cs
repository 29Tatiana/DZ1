Console.WriteLine("Введите n");
string n = Console.ReadLine();
int num = int.Parse(n);
for (int i = 1; i <= num; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);

