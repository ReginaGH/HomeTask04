//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.// 3, 5 -> 243 (3⁵) // 2, 4 -> 16
Console.WriteLine("Напишите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

int prod =1;
for (int count=1; count<=b; count++)
{
    prod = a*prod;
}
Console.WriteLine(prod);