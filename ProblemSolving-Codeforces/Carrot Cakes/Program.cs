using var reader = new StreamReader(Console.OpenStandardInput());
using var writer = new StreamWriter(Console.OpenStandardOutput());

string[] inputs = reader.ReadLine().Split();
int n = int.Parse(inputs[0]);
int t = int.Parse(inputs[1]);
int k = int.Parse(inputs[2]);
int d = int.Parse(inputs[3]);

int x = (int)(Math.Ceiling((double)n / k) - 1) * t;
if (x>d)
{
    writer.WriteLine("YES");
}
else
{
    writer.WriteLine("NO");
}

//writer.WriteLine($"{n} {t} {k} {d}");