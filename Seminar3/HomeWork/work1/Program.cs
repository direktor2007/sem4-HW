﻿// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;
// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }

// 2 Решение. Математический способ
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num/10000 == num%10 && num/1000 % 10== num % 10000 / 1000)
// {
//     System.Console.WriteLine("Число является палиндромом");
// }
// else
// {
//     System.Console.WriteLine("Число не является палендромом");
// }

// 3 Решение. Артем. Если мы попытаемя редактировать значение внутри строк. (num[0]="1") То нельзя. Ругается
//Я не могу изменить редактировать там переменную, у меня такая запись только для чтения. 
Console.WriteLine("Введите число: ");
 string? number= Console.ReadLine();//(null значение) Знак ? означает, строка пустой быть точно не должна, а если будет то в переменную number запишется значение
//или
if (number!.Length ==5)//или такой способ снятия желтой волнистой линии
{

}
// if (number[0] == number[4] && number[1] == number[3])
// {
//      Console.WriteLine("Число является палиндромом");
// }
// else
// {
// Console.WriteLine("Число не является палиндромом"");
// }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }

//Если я захочу узнать цифру третьего числа и сделать математические действия возвести ее в квадрат например

//int convertedNun = Convert.ToInt32(number[2]);// при обращении у нас возвращается чар элемент, т.к. это символ, строка это массив букв, а буква это чар
//System.Console.WriteLine(convertedNun);// вводим 12754 а ввыдает 55, У чар-переменных нет эквивалента для конвертации в int . 55 это значение по таблице АСКИ (номер символа 7)

//Надо сначала конвертировать элемент в строку, из чар-переменной сделать string-переменную, а потом string-переменную в int-переменную
int convertedNun = Convert.ToInt32(Convert.ToString(number[2]));
System.Console.WriteLine(convertedNun); 