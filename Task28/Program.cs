// Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, либо 
// можете сами задавать массив чисел) и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
// {2, 3, 4} -> 2, 6, 24
// {5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1
Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
for(int i=0; i<size; i++)
{
    Console.Write($"Введите элемент массива {i}:\t ");
    arr[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine('['+string.Join(" , ", arr)+ ']');

int prod = 1;
for(int i=0; i<size; i++)
{
    prod = prod*arr[i];
}
Console.WriteLine(prod);