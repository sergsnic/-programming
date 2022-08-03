// 5 программа на С# if else урок 1
Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Салют Маша!!!");
}
else
{
    Console.WriteLine("Привет " + username);
}
