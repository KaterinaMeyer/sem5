//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
            array[i] = random.Next(1, 100);
        }

        Console.WriteLine("Сгенерированный массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();


        int sum = SumNumber(array);

 
        Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " +sum);

        Console.ReadLine();
    }

    static int SumNumber(int[] arr)
    {
        int sum = 0;
        for (int i = 1; i < arr.Length; i += 2)
        {
            sum += arr[i];
        }
        return sum;
    }
}