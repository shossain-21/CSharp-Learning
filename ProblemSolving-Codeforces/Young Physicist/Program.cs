int n = int.Parse(Console.ReadLine());
int xsum = 0; int ysum = 0; int zsum = 0;
while (n-- > 0)
{
    string[] input = Console.ReadLine().Split(' ');
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);
    int z = int.Parse(input[2]);

    xsum += x; ysum += y; zsum += z;
}
if (xsum == 0 && ysum == 0 && zsum == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}