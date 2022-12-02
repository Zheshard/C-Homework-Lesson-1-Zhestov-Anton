// Программа, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка)
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int div = number % 2;

if (div == 0)
{
	Console.WriteLine("Вы ввели четное число");
}
else
{
	Console.WriteLine("Вы ввели нечетное число");
}