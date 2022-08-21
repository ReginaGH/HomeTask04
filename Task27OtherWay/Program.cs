// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11;       82 -> 10;        9012 -> 12
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
string s = Convert.ToString(number);
int sum = 0;
int i=0;
while (i<s.Length)
    {
        sum = sum + int.Parse(s[i].ToString()); 
        i++;
    }
Console.WriteLine(sum);   