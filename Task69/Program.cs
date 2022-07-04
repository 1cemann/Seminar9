//**Задача 69:** Напишите программу, которая на вход принимает два 
//числа A и B, и возводит число А в целую степень B с помощью рекурсии.

//A = 3; B = 5 -> 243 (3⁵)

//A = 2; B = 3 -> 8

using System;
using static System.Console;
Clear();

WriteLine("Введите A: ");
int A = Convert.ToInt32(ReadLine());
WriteLine("Введите стартовое число B: ");
int B = Convert.ToInt32(ReadLine());
WriteLine(DegreeNumbers(A,B));

int DegreeNumbers(int a, int b)
{
    if(b==0)
    return 1;
    else if (b<0)
    return 1/DegreeNumbers(a,-b);
    else
    return a*DegreeNumbers(a,b-1);
}
    