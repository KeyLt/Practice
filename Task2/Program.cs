//По двум заданным числам проверять является ли одно квадратом второго
Console.Write("Введите первое число ");
string First_number = Console.ReadLine();
int number_first = Convert.ToInt32(First_number);
Console.Write("Введите второе число ");
string Second_number = Console.ReadLine();
int number_second = Convert.ToInt32(Second_number);
int Numbers_one = 0;
int Numbers_two = 0;
Numbers_one = number_first / number_second;
Numbers_two = number_second / number_first;
if(Numbers_one == number_second)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else if(Numbers_two == number_first)
{
   Console.WriteLine("Второе число является квадратом первогочисла");
}
else
{
    Console.WriteLine("Числа не являются кваратами друг друга");
}
