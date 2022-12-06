// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// (в цикле умножение А на А (res=A; res *= A; ), пока i == В)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int a, int b)
{
    int res = a;
    for (int i = 1; i < b; i++)
    {
        res *= a;
    }
    return res;
}

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат возведения в степень: {Degree(A, B)}");
