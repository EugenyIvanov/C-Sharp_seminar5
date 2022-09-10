Console.Clear();
int size = 123;
int [] array = GetArray(size, -9, 9);

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
for(int j = 10; j < 100; j++)
{
    Console.Write(array[j] + " ");
}