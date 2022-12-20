// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 <= 0 || num2 <= 0) 
Console.WriteLine("Ошибка, числа должны быть больше 0");
if (num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}


Console.WriteLine(SumRec(num1, num2));
int SumRec(int num1, int num2)
{
    if (num1 > num2) return 0;
    else return num1 + SumRec(num1 + 1, num2);
}

