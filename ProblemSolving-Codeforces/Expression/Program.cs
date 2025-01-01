int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int mx = Math.Max(a*b*c, Math.Max(a+b+c, Math.Max(a+(b*c), Math.Max((a+b)*c, Math.Max((a*b)+c, a*(b+c))))));

Console.WriteLine(mx);