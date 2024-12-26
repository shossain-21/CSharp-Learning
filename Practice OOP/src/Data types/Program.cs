//Write a program to declare variables of different data types (int, float, char, string, bool).
//Demonstrate how to initialize and use them.

int x = new int();
char c = new char();
float f = new float();
string s = string.Empty;
bool b = new bool();
int[] arr = new int[5];
string[] str = new string[5];
int[,] arr2 = new int[4, 4];
for(int i=0; i<4; i++)
{
    int[] tmp = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j=0; j<4; j++){
        arr2[i, j] = tmp[j];
    }
}

for(int i=0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(arr2[i, j] + " ");
    }
    Console.WriteLine();
}

str = Console.ReadLine().Split(' ');
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(str[i]);
}
Console.WriteLine();

//Jagged Array
int size = 5;
int[][] vector = new int[size][];
for (int i = 0; i < size; i++)
{
    vector[i] = new int[i + 1];
    vector[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

for(int i = 0; i < size; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(vector[i][j] + " ");
    }
    Console.WriteLine();
}