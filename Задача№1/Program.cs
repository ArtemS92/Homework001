//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());
int max = number1;
int min = number2;

if (number1 > number2)
    { max = number1;
      min = number2;
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
    }   
else {max = number2 ;
      min = number1;
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
}   
