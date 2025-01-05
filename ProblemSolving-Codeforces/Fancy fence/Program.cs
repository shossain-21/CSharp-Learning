int t = int.Parse(Console.ReadLine());

while(t > 0)
{
    int a = int.Parse(Console.ReadLine());
    int flag = 0;
    for(int i = 3; i < 361; i++)
    {
        int x = (i-2) * 180;
        if (x == a*i)
        {
            Console.WriteLine("YES");
            flag = 1;
            break;
        }
    }
    if (flag == 0)
    {
        Console.WriteLine("NO");
    }
    t--;
}