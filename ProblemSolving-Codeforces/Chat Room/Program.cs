string str = Console.ReadLine();
string str2 = "hello";

int sz = str.Length;
int j = 0; int cnt = 0;

for (int i = 0; i < sz && j < 5; i++)
{
    if(str[i] == str2[j])
    {
        cnt++;  j++;
    }
}
if (cnt == 5)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
