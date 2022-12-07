// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Привет, Света, это первый урок!");

//напишите программу, которая на вход принимает число и выдет его квадрат
// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int doubleA = a * a;
// Console.WriteLine();
// Console.Write($"квадрат числа {a} равен {doubleA}");
// Console.WriteLine();

//напишиет программу, которая будет выдавать название дня недели по номеру
/*Console.Clear();
Console.Write("Введите число от 1 до 7 по кол-ву дней недели: ");
int number = Convert.ToInt32(Console.ReadLine() ?? "0");
if(number <1 || number > 7) Console.Write("Такого дня недели не существует!");
if(number == 1) Console.Write("Monday");
if(number == 2) Console.Write("Tuesday");
if(number == 3) Console.Write("Wednesday");
if(number == 4) Console.Write("Thursday");
if(number == 5) Console.Write("Friday");
if(number == 6) Console.Write("Saturday");
if(number == 7) Console.Write("Sunday");

многострочный комментарий
выполнение программы идет последовательно, строчка за строчкой
{}, , ; () $  - синтаксис
; - окончание инструкции
*/

//типы данных

//напишите программу, которая на вход принимает число N и на выходе показывает все целые числа от -N до N
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine() ?? "0");
// int a = -n;
// while (a <= n)
// {
//     Console.Write($"{a} ");
//     a++;
// }
Console.Clear();
// int a = 9; 
// int b = 11;
// //a = 5;
// Console.Write($"{a}, {b}");
// Console.WriteLine();

// int a,b;
// a = 7;
// b = 99;
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine();

// int a  = 5;
// Console.WriteLine(a);
// Console.WriteLine();
// a = 676; 
// Console.WriteLine(a);
// Console.WriteLine();

//ввод данных в консоль

// string data;
// data = Console.ReadLine();
// Console.WriteLine("Hello, " + data + " !!!");
// Console.WriteLine();

//конвертация данных string

// string str  = "5";
// string str1 = "9";
// string str2 = "7";
// string str3 = "8";
// //Console.WriteLine(str + str1 + str2);
// int a = Convert.ToInt32(str);
// int b = Convert.ToInt32(str1);
// int c = Convert.ToInt32(str2);
// int d = Convert.ToInt32(str3);
// Console.Write($"{a}, {b}, {c}, {d}");
// Console.WriteLine();
// Console.Write("сумма указанных чисел равна = ");
// Console.Write(a + b + c + d);
// Console.WriteLine();

Console.Clear();
// Console.Write("Введите первое число: ");
// string str1 = Console.ReadLine() ?? "0";
// int a = Convert.ToInt32(str1);

// Console.Write("Введите второе число: ");
// string str2 = Console.ReadLine() ?? "0";
// int b = Convert.ToInt32(str2);

// Console.Write("Введите третье число: ");
// string str3 = Console.ReadLine() ?? "0";
// int c = Convert.ToInt32(str3);

// int result = a + b + c;

// Console.Write($"{a}, {b}, {c}");
// Console.WriteLine();
// Console.Write("сумма указанных чисел равна = " + result);
// //Console.Write(result);
// Console.WriteLine();

string str = "1,1";
double c = Convert.ToDouble(str);
Console.Write(c);
Console.WriteLine();
