

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

// void Palindrome(int n){
// int number = n;
// int rev = 0;
// while (n > 0){
//     int end = n % 10;
//     rev = (rev * 10) + end;
//     n = n / 10;}
// if (rev == number) Console.WriteLine("Palindrome");

// else Console.WriteLine("not Palindrome");
// }
// Console.WriteLine("Ведите пятизначное число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     Palindrome(num);


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// void Geo (int x1, int x2, int y1, int y2, int z1, int z2){
// double n = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
// Console.WriteLine($"Расстояние: {Math.Round(n,2)}");
// }
// Console.WriteLine("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Geo(x1,x2,y1,y2,z1,z2);



// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N.


//  void Cube(int n){
//     for(int i = 1; i <= n; i++)
//     {
//         int i3 = (i * i * i);
//         Console.Write($"{i3} " );
//     }
//  }
//  Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     Cube(num);