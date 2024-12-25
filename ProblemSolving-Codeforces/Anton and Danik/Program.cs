string tmp = Console.ReadLine();
int n = int.Parse(tmp);
string s = Console.ReadLine();

int anton = 0;
int danik  = 0;

for (int i = 0; i < n; i++)
{
    if (s[i] == 'A') anton++;
    else if (s[i] == 'D') danik++;
}

if (anton > danik)
{
    Console.WriteLine("Danik");
}
else Console.WriteLine("Friendship");