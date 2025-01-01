string[] input = Console.ReadLine().Split(' ');
int s = int.Parse(input[0]);
int n = int.Parse(input[1]);

int[][] dragons = new int[n][];

for(int i = 0; i < n; i++)
{
    input = Console.ReadLine().Split(' ');
    dragons[i] = new int[] { int.Parse(input[0]), int.Parse(input[1]) };
}

Array.Sort(dragons, (a, b) => a[0].CompareTo(b[0]));

bool canWin = true;

for (int i = 0; i < n; i++)
{
    if (s > dragons[i][0])
    {
        s += dragons[i][1];
    }
    else
    {
        canWin = false;
        break;
    }
}
if (canWin)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}