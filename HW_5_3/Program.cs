// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



int size = 8;
double[] numbers = new double[size];
FillArray (numbers);
Console.WriteLine("Содержание массива");
PrintArray (numbers);
DifferenceArray (numbers);


    void FillArray (double[] num)
    {   
        for (int i = 0; i < num.Length; i++)
        {
        Random random = new Random();
        double value = random.NextDouble() * 20 - 10;
        num[i] = Math.Round(value , 2);
        }
    }

    
    void DifferenceArray (double[] num)
    {
    double max = num[0]; 
    for (int i = 0; i < num.Length; i++)
    {
        if (max < num[i])  
        {
            max = num[i];
        }  
    }
    Console.WriteLine("Максимальное число " + max);
    
    double min = num[0]; 
    for (int i = 0; i < num.Length; i++)
    {
        if (min > num[i])  
        {
            min = num[i];
        }  
    }
    Console.WriteLine("Минимальное число " + min);
    double difference = max - min;
    Console.WriteLine("Разность максимального и минимального элемент " + Math.Round(difference, 2));
    }
    
    void PrintArray (double[] num)
    {

    for (int i = 0; i < size; i++)
    {
        Console.Write(num[i] + "\t"); 
    }
    Console.WriteLine();
    }