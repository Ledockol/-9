//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Задайте значение M");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N");
int end = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int num = start;
while(num <= end)
{
    sum = sum + num; num++;
}
Console.WriteLine(sum);