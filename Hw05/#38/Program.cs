void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double[] CreateArrayRndInt(int size)
{
    double[] arr = new double[size];
    double a = 1.3;

    for (int i = 0; i < arr.Length; i++)
    {   
        arr[i] = a;
        a+=a;
    }

    return arr;
}

double[] array = CreateArrayRndInt(5);
PrintArray(array);


double MinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]){
            min = arr[i];
        }
        if (max < arr[i]){
            max = arr[i];
        }
    }
    double res = max - min;
    return res;
}
Console.WriteLine($" -> {MinMax(array)}");