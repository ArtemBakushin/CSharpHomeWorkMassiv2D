// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if ( M > N)
{
    Console.WriteLine("Число M должно быть меньше N! " );
}
int GetSumNaturalOfElements (int start , int end)
{
    if (start==end) return end;

    return start += GetSumNaturalOfElements(start+1,end);
}
Console.WriteLine($"Сумму натуральных элементов в промежутке от {M} до {N} число {GetSumNaturalOfElements(M,N)} ");