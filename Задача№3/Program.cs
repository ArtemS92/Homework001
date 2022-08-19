//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
int div = number%2;

if (div == 0)
    {Console.WriteLine("Четное");

    }
else {Console.WriteLine("Нечетное");

    }