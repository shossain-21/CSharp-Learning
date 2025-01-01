string[] input = Console.ReadLine().Split(' ');
double n = int.Parse(input[0]);
int m = int.Parse(input[1]);
int a = int.Parse(input[2]);
int b = int.Parse(input[3]);

int x1 = (int)Math.Ceiling(n / m) * b;
int x2 = ((int)n % m) * a + ((int)n / m ) * b; 

int min = Math.Min(x1, Math.Min(x2, (int)n*a));

Console.WriteLine(min);