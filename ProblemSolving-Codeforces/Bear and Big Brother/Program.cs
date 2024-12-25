string s = Console.ReadLine();
string[] parts = s.Split(' ');

int bear; int.TryParse(parts[0], out bear);
int bob; int.TryParse(parts[1], out bob);

int count = 0;
while(bear<=bob)
{
    count++; bear = bear * 3; bob = bob * 2;
}

Console.WriteLine(count);