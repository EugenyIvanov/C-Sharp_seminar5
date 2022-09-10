Console.Clear();
Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size, -100, 1000);

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
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
bool x = false;
for(int j = 0; j < array.Length; j++)
{
    if (number == array[j])
    {
        x = true;
    }
    
}
if (x == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


