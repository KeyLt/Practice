// Дано число обозначающее день недели. Выяснить является номер дня недели выходынм
Console.WriteLine("Введите номер дня");
int s = Convert.ToInt16(Console.ReadLine());
    if(s > 5 && s < 8)Console.WriteLine("Выходной день");
    else if(s > 0 && s < 6)Console.WriteLine("Будний день");
    else Console.WriteLine("Такого дня нет");
return ;