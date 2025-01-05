string input = Console.ReadLine();
int n = int.Parse(input.Split(' ')[0]);
int l = int.Parse(input.Split(' ')[1]);
int[] lanterns = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
Array.Sort(lanterns);
double maxDistance = 0;
for (int i = 0; i < n - 1; i++)
{
    double distance = (lanterns[i + 1] - lanterns[i]) / 2.0;
    if (distance > maxDistance)
    {
        maxDistance = distance;
    }
}
double distanceToStart = lanterns[0];
double distanceToEnd = l - lanterns[n - 1];
double result = Math.Max(maxDistance, Math.Max(distanceToStart, distanceToEnd));
Console.WriteLine($"{result:F10}");