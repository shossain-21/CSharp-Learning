string str = Console.ReadLine();
int len = str.Length;

for (int i = 0; i < len; i++)
{
    if(str[0] == '9' && i == 0)
    {
        continue;
    }
    if (str[i] > '4')
    {
        str = str.Remove(i, 1).Insert(i, (9 - (str[i] - '0')).ToString());
    }
}
Console.WriteLine(str);