int n = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int[] groups = new int[5]; int cnt = 0;

for(int i = 1; i <= 4; i++) groups[i] = 0;

for (int i = 0; i < n; i++)
{
    groups[arr[i]]++;
}

if (groups[4] > 0) 
{ 
    cnt += groups[4]; groups[4] = 0;
}
if(groups[3] > 0)
{
    cnt += groups[3];
    if (groups[1] > 0)
    {
        groups[1] -= Math.Min(groups[1], groups[3]);
    }
}
if (groups[2]%2 == 0)
{
    cnt += groups[2] / 2; groups[2] = 0;
}
else
{
    cnt += groups[2] / 2;
    cnt++;
    if (groups[1] > 0)
    {
        groups[1] -= Math.Min(groups[1], 2);
    }
}
if (groups[1] > 0)
{
    cnt += groups[1] / 4;
    if (groups[1] % 4 != 0)
    {
        cnt++;
    }
}

Console.WriteLine(cnt);