string input = Console.ReadLine();
string str = input.ToLower();
string str2 = "";

int sz = str.Length;

for (int i = 0; i < sz; i++)
{
    if (str[i] != 'a' && str[i] != 'e' && str[i] != 'i' && str[i] != 'o' && str[i] != 'u' && str[i] != 'y')
    {
        str2 += "." + str[i];
    }
}
Console.WriteLine(str2);