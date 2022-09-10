Console.Clear();
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size, 1, 9);

Console.WriteLine(String.Join(" ", array));

int [] GetArray(int size, int min, int max)
{
   int [] result = new int[size];
   for (int i = 0; i < size; i++)
   {
    result[i] = new Random().Next(min, max + 1);
   }
   return result;
}
int j = array.Length -1;
for (int x = 0; x < j; x++)
{
    int product = array[x] * array[j];
    j--;
    Console.Write(product + " ");
}
if(array.Length % 2 != 0)
{
    Console.Write(array[array.Length/2]);
}
