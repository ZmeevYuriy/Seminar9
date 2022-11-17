// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = Promt("Введите первое число"); 
int N = Promt("Введите второе число");
if (IsInputValidate(M, N))
{
    Console.WriteLine(SumRec(M, N));
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
    if (a <= 0 || b <= 0 || a > b)
        return false;
    return true;
}

int SumRec(int a, int b)
{
    if (a == b)
        return b;
    else return a + SumRec(a + 1, b);
}