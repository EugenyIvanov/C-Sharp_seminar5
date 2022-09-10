Console.Clear();
Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());
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

int sumPositive = 0;
int sumNegative = 0;

foreach(int element in array)
{
   sumPositive += element > 0 ? element : 0;
   sumNegative += element < 0 ? element : 0;
}

Console.WriteLine($"sum positive: {sumPositive} | sum negative: {sumNegative}");