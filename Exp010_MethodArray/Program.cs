int[] array = { 1, 12, 31, 18, 15, 16, 17, 18 };
int n = array.Length;
int find = 18;
int i = 0;

while (i < n)
{
    if (array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    i++;
}
