using System.Reflection.PortableExecutable;

var t = int.Parse(Console.ReadLine());

while (t!=0)
{
    string[] inputs = Console.ReadLine().Split();
    int n = int.Parse(inputs[0]);
    long h = long.Parse(inputs[1]);
    //Console.WriteLine(h);
    var arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
    
    Array.Sort(arr, (a, b) => b.CompareTo(a));

    //for(int i = 0; i < arr.Length; i++)
    //{
    //    Console.Write($"{arr[i]} ");
    //}

    long count = 0;
    long x = arr[0] + arr[1];
    if (h % x == 0)
    {
        count = 2 * Math.Abs(h / x);
    }
    else if (h % x <= arr[0])
    {
        count = (2 * Math.Abs(h / x)) + 1;
    }
    else
    {
        count = (2 * Math.Abs(h / x)) + 2;
    }
    Console.WriteLine(count);
    t--;
}