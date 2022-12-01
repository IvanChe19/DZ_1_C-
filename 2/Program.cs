Console.WriteLine("введите число");
string input0 = Console.ReadLine();
Console.WriteLine("введите второе число");
string input1 = Console.ReadLine();
int num0 = Convert.ToInt32(input0);
int num1 = Convert.ToInt32(input1);
if (num0 > num1)
{
    Console.WriteLine($"Наибольшее число  {num0} Наименьшее число {num1}");
}
else
{
Console.WriteLine($"Наибольшее число   {num1} Наименьшее число {num0}");
}