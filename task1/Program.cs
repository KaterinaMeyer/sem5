//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        Console.WriteLine("Сгенерированный массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int evenCount = CountEvenNumbers(array);

        Console.WriteLine("Количество чётных чисел в массиве: " + evenCount);

        Console.ReadLine();
    }

    static int CountEvenNumbers(int[] arr)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}
