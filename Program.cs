/* See https://aka.ms/new-console-template for more information
Console.Write("Введите число:");
string myString = Console.ReadLine();
Console.WriteLine("{0}  {1}  {2}", 7, 15, 100);
*/
//Задача 2.1
//a)
Console.Write("Введите значение х: ");
double.TryParse(Console.ReadLine(), out double x);
double y = 7* Math.Pow(x,2) + 3*x + 6;
Console.WriteLine("7x^2+3x+6="+ y +", при х равном "+x);
//b)
Console.Write("Введите значение a: ");
double.TryParse(Console.ReadLine(), out double a);
double b = 12* Math.Pow(a,2) + 7*a + 12;
Console.WriteLine("12a^2+7a+12="+b+", при а равном "+a);