int n = int.Parse(Console.ReadLine());
int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int m = int.Parse(Console.ReadLine());
int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

for(int i = 1; i < n; i++)
{
    a[i] += a[i - 1];
}

for (int i = 0; i < m; i++)
{
    int target = q[i];
    int index = Array.BinarySearch(a, target);
    if (index < 0)
    {
        index = ~index;
    }
    Console.WriteLine(index + 1);
}
