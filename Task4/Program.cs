// Программа проверяет пятизначное число на палиндромом
Console.WriteLine("Введите пятизначное число");
string s = Console.ReadLine();
char [] j = s.ToCharArray();
Array.Reverse(j);
string k = new string(j);
if (s == k){
    Console.WriteLine("Введеное число палиндром");
}
else{
    Console.WriteLine("Введеное число не палиндром");
} 
