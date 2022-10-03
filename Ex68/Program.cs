//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

Console.WriteLine("Задайте значение M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N");
int numN = Convert.ToInt32(Console.ReadLine());

int Function(int numM, int numN)
{
    if(numM == 0)
    {
        return numN + 1;
    }
    else if(numM > 0 && numN == 0)
    {
        return(Function(numM - 1, 1));
    }
    else if(numM > 0 && numN > 0)
    {
       return(Function(numM - 1, Function(numM, numN - 1))); 
    }
    else
        return(Function(numM, numN));
}
Console.Write(Function(numM, numN)); 