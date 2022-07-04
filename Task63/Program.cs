//**Задача 65:** Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

using System;
using static System.Console;
Clear();

WriteLine("Введите N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine("Введите стартовое число: ");
int m = Convert.ToInt32(ReadLine());
OutputBeforeN(n, m);


void OutputBeforeN(int a, int start)
{
    
    if (start <= a)
    {
        Write($"{start} ");
        start++;
        OutputBeforeN(a, start);
    }
    else return;
}
