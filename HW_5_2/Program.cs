// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов с нечётными индексами.



int size = 4;
int[] numbers = new int[size];
FillArray (numbers);
Console.WriteLine("Содержание массива");
PrintArray (numbers);
Sum (numbers);


    void FillArray (int[] num)
    {   
        for (int i = 0; i < num.Length; i++)
        {
        Random random = new Random();
        num[i] = random.Next(-99, 100);
        }
    }

    
    void Sum (int[] num)
    {
    int s = 0;
    for (int i = 1; i < size; i++)
    {
  
        if (i % 2 == 0)
    {   
        s = s;
    }
        else s = s + num[i];
    }
    Console.WriteLine("Сумма элементов с нечетным индексом " + s);
    }
       
    void PrintArray (int[] num)
    {

    for (int i = 0; i < size; i++)
    {
        Console.Write(num[i] + "\t"); 
    }
    Console.WriteLine();
    }