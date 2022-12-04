/* Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 3, n = 2->A(m, n) = 29*/


                
                
            
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("Введите число M: ");
int m =  Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackerman = Ack(m, n);
Console.WriteLine($"Функция Аккермана = {Ackerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
