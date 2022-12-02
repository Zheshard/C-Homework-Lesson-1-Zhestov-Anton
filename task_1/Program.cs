Console.WriteLine("Введите 2 целых числа: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{
	Console.Write("Число 1 (" + number_1 + ") больше числа 2 (" + number_2 + ")");
}
else if (number_1 == number_2)
{
	Console.Write("Число 1 (" + number_1 + ") равно числу 2 (" + number_2 + ")");
}
else
{
	Console.Write("Число 1 (" + number_1 + ") меньше числа 2 (" + number_2 + ")");
}