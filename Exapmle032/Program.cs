Console.Clear();
Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size, -9, 9);

int [] GetArray(int size, int min, int max)
{
   int [] result = new int[size];
   for (int i = 0; i < size; i++)
   {
    result[i] = new Random().Next(min, max + 1);
   }
   return result;
}
Console.WriteLine(String.Join(" ", array));

for(int i = 0; i <array.Length; i++)
{
    array[i] = array[i] * -1;
}
Console.WriteLine(String.Join(" ", array));