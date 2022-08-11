// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// a3 - искомое значение (третья цифра трехзначного числа).

Console.Write("Введите любое число (ввод числа не должен начинаться с нуля): ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
    Console.WriteLine("Tретья цифра в данном числе " + anyNumberText[2]);
}
else
{
    Console.WriteLine("Третья цифра отсутствует в данном числе");
}