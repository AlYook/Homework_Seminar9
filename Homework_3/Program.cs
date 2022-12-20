// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 ==4)
{
Console.WriteLine("Нельзя указывать число больше 3, поскольку значение числа превышает количество атомов в видимой нами вселенной");
return;
}

Console.WriteLine(CalculateAkkerman(num1, num2));
int CalculateAkkerman(int num1, int num2)
{
    if (num1 == 0) return num2+1;
    else
    {
        if((num1 != 0) && (num2==0))
        return CalculateAkkerman(num1 - 1 , 1);
        else return CalculateAkkerman(num1 - 1, CalculateAkkerman(num1, num2 - 1));
    }
}