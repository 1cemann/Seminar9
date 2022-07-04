//**Задача 67:** Напишите программу, которая будет принимать на 
//вход число и возвращать сумму его цифр.

//453 -> 12

//45 -> 9

using System;
using static System.Console;
Clear();

int n=Convert.ToInt32(ReadLine());
WriteLine(SumNumbers(n));

int SumNumbers(int a)
{
    return a>0? (a%10+SumNumbers(a/10)):0;
    //if (a>0) return (a%10+SumNumbers(a/10));
    //else return 0;
}
