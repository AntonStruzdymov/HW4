Console.WriteLine("Введите число от 0 до 100");
var userNumber = int.Parse(Console.ReadLine());
if (userNumber >= 0 && userNumber <= 30)
{
    Console.WriteLine("Данное число в промежутке от 0 до 30");
}else if (userNumber >= 31 && userNumber <= 60)
{
    Console.WriteLine("Данное число в промежутке от 31 до 60");
}else if (userNumber >= 61 && userNumber <= 100)
{
    Console.WriteLine("Данное число в промежутке от 61 до 100");
} else
{
    Console.WriteLine("Я такого числа не знаю.");
}