//конвертация строки
//parse / tryparse

// Console.Clear(); //целое число
// Console.Write("Введите число: ");
// string str = Console.ReadLine() ?? "0";
// int number  = int.Parse(str);

// Console.Write("Введите еще число: ");
// string str1 = Console.ReadLine() ?? "0";
// int number1  = int.Parse(str1);

// int c = number + number1;
// Console.Write($"сумма чисел {number} и {number1} = > {c}");
// Console.WriteLine();

Console.Clear(); //число с плавающей запятой
// Console.Write("Введите число: ");
// string str = Console.ReadLine() ?? "0";
// double number  = double.Parse(str);

//Console.Write("Введите еще число: ");
// string str1 = "5,9"; //Console.ReadLine() ?? "0";

// double number1  = double.Parse(str1);
// Console.Write($"{number1}");
// Console.WriteLine();

// Console.Write("Введите число: ");
// string str = Console.ReadLine() ?? "0";
// //int number  = int.Parse(str);
// try
// {
//     int a = Convert.ToInt32(str);
//     Console.WriteLine($"Успешная конвертация числа {a}");
// }
// catch (Exception)
// {
//     Console.WriteLine("Ошибка при конвертации");

// }

//tryparse

Console.Write("Введите число: ");
string str = Console.ReadLine() ?? "0";
int a;
bool result = int.TryParse(str, out a);
if(result)
{
    Console.WriteLine($"успешно, значение {a}");
}
else Console.WriteLine("Ошибка при конвертации");
Console.WriteLine();

