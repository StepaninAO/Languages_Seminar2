// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру (цельночисленное цифровое значение), обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) // Проверка дня недели.
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Этот день недели является выходным днем");
    }
    else
        if (dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("Цифровое значение дня недели введено некорректно");
        }
    else Console.WriteLine("Это день недели является рабочим днем");
}
CheckingTheDayOfTheWeek(dayNumber);