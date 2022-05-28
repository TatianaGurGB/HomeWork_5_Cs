// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

void Print (int []arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
    Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}
int [] MassNums(int size)
{
    int[]arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1,10);
    }
    return arr;
}
void PairNum (int[]arr)
{
    int sum = 0;
    int i = 0;
    int size = arr.Length-1;
    while (i < size / 2)
    {
        sum = arr[i]+arr[size - 1];
        i +=1;
    }
    Console.WriteLine($"{sum}");
}
int[]arr = MassNums(10);
Print(arr);
PairNum(arr);
