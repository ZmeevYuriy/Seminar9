// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int M = Promt("Введите первое число"); 
int N = Promt("Введите второе число");
if (IsInputValidate(M, N))
{
    Console.WriteLine(Akkerman(M, N));
}
else Console.WriteLine("Здесь есть ошибка");

int Promt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

bool IsInputValidate(int a, int b)
{
    if (a < 0 || a > 3 || b <= 0)
        return false;
    return true;
}

int Akkerman(int m, int n)
{  
    if (m == 0)
    {
        return n + 1;
    } 
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    } 
    else 
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}