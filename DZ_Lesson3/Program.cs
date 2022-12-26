// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine ("Ввести любое пятизначное число: ");

// string enternum = Console.ReadLine();
// int numder = enternum.Length;


// if (numder == 5)
// {
//     if (enternum[0] == enternum[4] && enternum [1] == enternum[3])
//     {
//         Console.WriteLine("Да, палиндром");
//     }
//     else
//         {
//         Console.WriteLine("Нет, не палиндром");
//         }
// }
// if (numder > 5 )
//     { 
//     Console.WriteLine(" число не пятизначное");
//     }
// if (numder < 5 )
//    { 
//    Console.WriteLine(" число не пятизначное");
//  }


// Задача №21. Работа в группах
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21
 

// Console.WriteLine("Введите x точки a: ");
//  int xa = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите y точки a: ");
// int ya = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите x точки b: ");
// int xb = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите y точки b: ");
// int yb = int.Parse(Console.ReadLine());

 
// double result = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2));

// System.Console.WriteLine(result);


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
    Console.Write($"{i * i * i}, ");


// Метод
// int ReadInt(string message)
// {
//     Console.Write (message);
//     return Convert.ToInt32(Console.ReadLine());
// }
