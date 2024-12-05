Console.WriteLine("Это калькулятор, что хочешь то и считай.");
int num1;
int num2;
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("вот результат всех взаимодействий этих чисел:");
Console.WriteLine("Вычитание:" + (num1 - num2));
Console.WriteLine("Сложение:" + (num1 + num2));
Console.WriteLine("Умножение:" + (num1 * num2));
Console.WriteLine("Деление без остатка:"+ (num1 / num2));
Console.WriteLine("Остаток от деления:"+ (num1 % num2));