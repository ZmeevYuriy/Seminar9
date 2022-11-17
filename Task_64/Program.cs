// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.

int N = Promt("Введите число");
if (IsInputValidate(N))
{
    Console.WriteLine (NumbersRec(N, 1));
}
else Console.WriteLine("Здесь есть ошибка");

int Promt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}


bool IsInputValidate(int a)
{
    if (a < 1)
        return false;
    return true;
}

string NumbersRec (int a, int b)
{
    if (a>=b) 
    {
        string temp = NumbersRec(a-1, b);   
        return $"{a} " + temp;  
    } 
    else return String.Empty;
}

