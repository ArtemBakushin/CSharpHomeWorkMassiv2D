// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите неотрицательно число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательно число: ");
int n = Convert.ToInt32(Console.ReadLine());
int Ack (int numberOne , int numberSecond)
{
  if (numberOne == 0) return numberSecond + 1;
  else if (numberSecond == 0) return Ack(numberOne - 1, 1);
  else return Ack(numberOne - 1, Ack(numberOne, numberSecond - 1));
}
Console.Write($"Функция Аккермана = {Ack(m,n)} ");
