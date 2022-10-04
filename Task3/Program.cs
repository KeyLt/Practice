//Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти ");
int number_first = Convert.ToInt32(Console.ReadLine());
if(number_first == 1)
{
    Console.WriteLine("Четверть 1 координаты x+, y+");
}
else if(number_first == 2)
{
    Console.WriteLine("Четверть 2 координаты x-, y+");
}
else if(number_first == 3)
{
    Console.WriteLine("Четверть 3 координаты x-, y-");
}
else if(number_first == 4)
{
    Console.WriteLine("Четверть 4 координаты x-, y-");
}
else
{
    Console.WriteLine("Такой координатной четвери нет");
}