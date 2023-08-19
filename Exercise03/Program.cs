Console.WriteLine("Hello");
do
{
    Console.WriteLine("_____________");
    int a, b;
    Console.WriteLine($"Enter a number or control + C to end");
    a = (int)Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine($"Enter another number");
    b = (int)Convert.ToUInt32(Console.ReadLine());

    if (a % b == 0)
    {
        Console.WriteLine($"The number a: {b:N0} is multiple of number b: {a:N0}");
    }
    else
    {
        Console.WriteLine($"The number a: {b:N0} isn't multiple of number b: {a:N0}");
    }
} while (true);  
