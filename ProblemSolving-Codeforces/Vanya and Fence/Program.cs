string input = Console.ReadLine();
string[] parts = input.Split(' ');

int n; int.TryParse(parts[0], out n);
int h; int.TryParse(parts[1], out h);

int[] heights = new int[n];

string input1 = Console.ReadLine(); 
string[] parts1 = input1.Split(' ');

for (int i = 0; i < n; i++)
{
    heights[i] = int.Parse(parts1[i]); 
}

int count = 0;
for (int i = 0; i < n; i++)
{
    if (heights[i] > h)
    {
        count += 2;
    }
    else
    {
        count++;
    }
}

Console.WriteLine(count);