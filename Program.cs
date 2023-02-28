/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;
if (number<0)  number =  number * (-1);
while (number > 0)
{
    sum = sum + number % 10;
    number = number /10 ; 
}
    Console.WriteLine($"Cумма чисел в числе равна {sum} ");