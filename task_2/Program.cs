// Программа, которая принимает на вход 3 числа и выдает максимальное из этих чисел.
Console.WriteLine("Введите 3 числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max < number2)
{
	max = number2;
}
if (max < number3)
{
	max = number3;
}

Console.WriteLine("Максимальнео чиcло равно " + max);