﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
//сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число:  ");
int a =Convert.ToInt32(Console.ReadLine());
 if (a<100)
{
    Console.WriteLine("третьей цифры нет");

}
else if (a<1000)
{
Console.WriteLine(a%10);
}
else if (a>1000)
{
    while(a>1000)
    a=a/10;
    Console.WriteLine(a%10);
    }


