var t = int.Parse(Console.ReadLine());

while (t != 0)
{
    string[] inputs = Console.ReadLine().Split();
    long x1 = long.Parse(inputs[0]); long p1 = long.Parse(inputs[1]);
    inputs = Console.ReadLine().Split();
    long x2 = long.Parse(inputs[0]); long p2 = long.Parse(inputs[1]);

    long min = Math.Min(p1, p2);
    
    p1 -= min; p2 -= min;
    
    if (p1 >= 7)
    {
        Console.WriteLine(">");
    }
    else if(p2 >= 7)
    {
        Console.WriteLine("<");
    }
    else
    {
        x1 = x1 * (long)Math.Pow(10, p1);

        x2 = x2 * (long)Math.Pow(10, p2);

        if (x1 > x2)
        {
            Console.WriteLine(">");
        }
        else if (x1 < x2)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("=");
        }
    }
    
    t--;
}