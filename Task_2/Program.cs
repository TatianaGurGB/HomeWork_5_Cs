// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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
        arr[i] = new Random().Next(1,12);
    }
    return arr;
}
void SumNum(int []arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++){
        if ( i % 2 = 1);
        result = result + arr[i];
    }
    Console.WriteLine(result);
}

int[]arr = MassNums(20);
Print(arr);
SumNum(arr);