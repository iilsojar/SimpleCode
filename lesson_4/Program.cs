﻿//инкремент и декримент постфиксный и префиксный
//инкремент - операция увеличения значения на единицу, декримент - операцуия уменьшения значения на единицу
//разница в приоритете выполнения операций 

//int a = 0;
// a--;
// a--; //постфиксный декремент
// ++a; //префиксный инкремент
//Console.WriteLine(a++); //при такой записи получим 0 из за приоритета выполнения операций - такой инкремент вторичен
//Console.WriteLine(++a); //при такой записи получим 1 из за приоритета выполнения операций - такой инкремент первичен
//такое же правило и декрементов по приоритетам
//int a =1;
//a = ++a * a; //приоритет в операции у префиксного инкремента а не у умножения
// a = a++ * a; ////приоритет в операции у умножения а не у постфиксного инкремента
// Console.WriteLine(a);
// Console.WriteLine();

//операторы отношений и сравнений

// == равно
// != - не равно
//> - больше
// >= больше или равно
// < меньше
// <= меньше или равно

// int a = 5;
// int b = 4;
// //bool result = a==b; // = присваивание == равно

// Console.WriteLine(a == b);
// Console.WriteLine(a != b);
// Console.WriteLine(a > b);
// Console.WriteLine(a < b);


//if else - помогает реалиховать ветвление кода
// if (утверждение или выражение) данные в формате истина или ложь, если что-то - иначе
// {
//     действие 1
// }
// else
// {
//     действие 2
// }

// bool isInfected = true;
// if (isInfected)
// {
//     Console.WriteLine("Персонаж инфицирован!");
// }
// else
// {
//     Console.WriteLine("Персонаж здоров!");
// }

// int a;
// a = int.Parse(Console.ReadLine() ?? "0");
// if (a == 5)
// {
//     Console.WriteLine("a равно 5");
// }
// else
// {
//     Console.WriteLine("а не равно 5");
// }

//проверка числа на четность
int a;
a = int.Parse(Console.ReadLine() ?? "0");
if (a % 2 == 0)
{
    Console.WriteLine($"число {a} четное");
}
else
{
    Console.WriteLine($"число {a} НЕчетное");
}

