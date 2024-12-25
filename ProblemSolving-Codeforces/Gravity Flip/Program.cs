int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

string tmp = Console.ReadLine();
string[] parts = tmp.Split(' ');

for (int i = 0; i < n; i++)
{
    int.TryParse(parts[i], out arr[i]);
}

Array.Sort(arr);

Console.WriteLine(string.Join(" ", arr)); 