var n = 0;
while (true)
{
    Console.Write("Enter even number: ");
    n = int.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
        break;
    }
    Console.WriteLine("The number is not Even.");
}
Console.WriteLine($"Even number entered: {n}");