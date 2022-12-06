// Задача 29:
// Напишите программу, которая задаёт массив из 8 элементов с клавиатуры
// и выводит массив на экран.

int[] ArrEnter()
{
    int[] array = new int[8];
    for (int i = 0; i<= array.Length-1; i++) array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}

void ArrayPrint (int[] arr)
{
    int len = arr.Length;
    for ( int i = 0; i<=len-1; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Введите массив");
int[] arr = ArrEnter();
Console.WriteLine("-------------------------");
ArrayPrint(arr);
