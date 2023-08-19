Console.WriteLine("Hello");
do
{
    Console.WriteLine("_____________");
    int a, b;
    Console.WriteLine($"Enter a number or control + C to end");
    a = (int)Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine($"Enter another number");
    b = (int)Convert.ToUInt32(Console.ReadLine());

    // if (a % b == 0|| b % a == 0) 
    if (a % b == 0)
    {
        Console.WriteLine($"The number a: {a} is multiple of number b: {b}");
    }

    else
    {
        Console.WriteLine($"the number a: {a} is not multiple of number b: {b}");
    }
}while (true);  
