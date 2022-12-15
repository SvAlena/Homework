/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/


/*Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("number1 > number2");
}
else if (number1 < number2)
{
    Console.WriteLine("number2 > number1");
}
else if (number1 < number2)
{
    Console.WriteLine("number1 = number2");
}*/





//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*Console.WriteLine("Введите number1: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите number2: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите number3: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine($"максимальное число = {max}");*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

/*Console.Clear();
System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine("Число четное");
}
else
{
    System.Console.WriteLine("Число нечетное");
}*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();
System.Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());

int i = 1;
while (i <= N);
{
    if (i % 2 == 0)
    {
        System.Console.Write($"{i} ");
    }
    i++;
}
System.Console.WriteLine();


