// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N ");

int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M ");
int M = Convert.ToInt32(Console.ReadLine());
if (N > M) return;   // Останавливаем, чтоб не глючило
string PrintNumber(int N, int M)  
{
    if (N == M) return N.ToString();
    return (N + ", " + PrintNumber(N + 1, M));
}
Console.WriteLine($"числа от {N} до {M}: {PrintNumber(N, M)}");
