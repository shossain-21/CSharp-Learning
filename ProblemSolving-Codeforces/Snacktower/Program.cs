var n = int.Parse(Console.ReadLine());
var sSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

var end = n;
var dropped = new bool[n+1];

for (int i = 0; i < sSize.Length; i++)
{
    dropped[sSize[i]] = true;

    if (dropped[end])
    {
        //Console.WriteLine();
        while (dropped[end])
        {
            Console.Write($"{end} "); 
            end--;
        }
    }
    Console.WriteLine();
}