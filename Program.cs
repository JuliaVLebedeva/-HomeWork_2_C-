Урок 2. Массивы и функции в программировании

Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Console.WriteLine("введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1000 && x > 99)
{
Console.WriteLine("Результат: " + (x / 10 % 10));
}
else
Console.WriteLine("ввели не трехзначное число");


_____________________
Задача 13: 
Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

326791 -> 6

Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());
x = Math.Abs(x);

if (x < 100)
 {
    Console.Write("третьей цифры нет");
 }
else
{
while (x >= 999)
{
    x /= 10;
}
    Console.Write("Результат: " + x%10);
 }

______________
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 1 && number <= 5)
{
    Console.WriteLine("Рабочий");
}
else if(number == 6 || number ==7)

{
    Console.WriteLine("Выходной");
}
else
    Console.WriteLine("Неверный день недели");
    
__________________________________________
__________________________________________
Дополнительные задачи:
Ссылка на допы
https://docs.google.com/document/d/1290lbMnnyiCWjzeQ52F0W93LaaMF-hrugltCN8mdQpQ/edit?usp=sharing


Знакомство с языками программирования. Семинар 2.
Дополнительные задачи.

Задача 1. 
Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

Random rand = new Random();
/* int sideA = rand.Next(2, 8);
    int sideB = rand.Next(2, 8);
    int sideC = rand.Next(2, 8); */

    int sideA = rand.Next(3, 6);
    int sideB = rand.Next(3, 6);
    int sideC = rand.Next(12, 596);

    if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
    {
        if (sideA == sideB || sideA == sideC || sideB == sideC)
            Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} равнобедренный");
        else
            Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} неравнобедренный");
    }
    else
        Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} не существует");
___________________

Задача 2. 
На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.

Random rand = new Random();
    int day = rand.Next(1, 26);
    int month = rand.Next(1, 12);
    int year = rand.Next(2011, 2022);
    int age = 2022 - year;
    Console.WriteLine($"Дата рождения {day}.{month}.{year}");
    if (month > 8 || (month == 8 && day > 2));
    {
        age--;
    }
    Console.WriteLine("Возраст человека: " + age);

не смогла разобраться, почему ошибка. почему май прошел, а возраст не 11 лет. в чем беда?:
Дата рождения 10.5.2011
Возраст человека: 10

______________________


Задача 3. 
Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.

Random rand = new Random();
 double deposit = 1000;
 int month = rand.Next(10, 1000);
 for (int i = 0; i < month; i++)
 {
    deposit *= 1.015;    
 }  
 Console.WriteLine($"Сумма депозита через {month} месяца (-ев) составляет {Math.Round(deposit, 2)} рублей (-я) ");

____________________
Задача 4. 
Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.


 int number = 9563874;
    int max = -1;
    int min = 10;
    int positionMax = 0;
    int positionMin = 0;
    int count = 1;
    Console.WriteLine($"В числе {number} ");
    while(number > 0)
{
    int digit = number %10;
    if (digit > max)
    {
        max = digit;
        positionMax = count;
    }
    else if (digit < min)
    {
        min = digit;
        positionMin = count;
    }
    count++;
    number /= 10;
}
    if (positionMax > positionMin)
    {
    Console.WriteLine($"Цифра {max} стоит левее цифры {min}");
    }
else 
{
    Console.WriteLine($"Цифра {min} стоит левее цифры {max}");
}



