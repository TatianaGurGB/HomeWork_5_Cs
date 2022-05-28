// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void Print (double []arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
    Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}
double [] MassNums(int size)
{
    double[]arr = new double[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1,12);
    }
    return arr;
}
double Array (double[]num)
{
    int i = 0;
    double s_max = num[0];
    double s_min = num[0];
    double result = 0;
    for (i = 0; i < arr.Length; i++)
    {
        if(s_max < num[i]);
        s_max = num[i];
    }
    {
        if (s_min > num[i]);
        s_min = num[i];
    }
    result = s_max - s_min;
    return result;
}
double[]arr = MassNums(20);
Print(arr);
Array(arr);
