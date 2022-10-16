/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов
 в промежутке от M до N. Рекурсивно
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine(RecourseMtoN(firstNumber, secondNumber));
int RecourseMtoN(int num1, int num2)
{
    if (num1 == num2)
    {
        return num2;
    }
    else
    {
        return num1 + RecourseMtoN(num1+1, num2);
    }
}