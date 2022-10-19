//Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int size = 4;
int[] numbers = new int[size];
FillArray (numbers);
Console.WriteLine("Содержание массива");
PrintArray (numbers);
Counter (numbers);


    void FillArray (int[] num)
    {   
        for (int i = 0; i < num.Length; i++)
        {
        Random random = new Random();
        num[i] = random.Next(100, 1000 );
        }
    }

    
    void Counter (int[] num)
    {
    int count = 0;
    for (int i = 0; i < size; i++)
    {
  
        if (num[i] % 2 == 0)
    {   
        count++;
    }
    }
    Console.WriteLine("Количество четных чисел " + count);
    }
       
    void PrintArray (int[] num)
    {

    for (int i = 0; i < size; i++)
    {
        Console.Write(num[i] + "\t"); 
    }
    Console.WriteLine();
    }