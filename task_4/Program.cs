// Программа, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 2;

while (index <= number)
{
	Console.WriteLine(index);
	index += 2;
}
