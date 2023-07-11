//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива (через пробел):");
        string[] input = Console.ReadLine().Split(' ');

        double[] numbers = new double[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = Convert.ToDouble(input[i]);
        }
        double difference = GetDifference(numbers);

        Console.WriteLine("Разница между максимальным и минимальным элементом: " + difference);
    }
    static double GetDifference(double[] array)
    {
        double min = array[0];
        double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];

            if (array[i] > max)
                max = array[i];
        }

        double difference = max - min;

        return difference;
    }
}