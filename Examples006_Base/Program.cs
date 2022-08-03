// пример 3 лекция 1
Console.Write("Введите первое число: ");
int numeric1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numeric2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int numeric3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numeric4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int numeric5 = Convert.ToInt32(Console.ReadLine());
int max = numeric1;
if( numeric2>max) max = numeric2;
if( numeric3>max) max = numeric3;
if( numeric4>max) max = numeric4;
if( numeric5>max) max = numeric5;
Console.Write("Максимальное число будет равно: " + max);