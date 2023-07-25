// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double GetMaxMinDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double diff = max - min;
    Console.Write($" => {max} - {min}");
    return Math.Round(diff,2);
}

double[] GenerateRandomArray(int elements, double start, double finish)
{
    double[] array = new double[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = Math.Round((start + new Random().NextDouble()*(finish-start)),2);
    }
    return array;
}

double[] array = GenerateRandomArray(4, 0, 100);
Console.Write($"[{String.Join(", ", array)}]");
Console.WriteLine($" = {GetMaxMinDiff(array)}");