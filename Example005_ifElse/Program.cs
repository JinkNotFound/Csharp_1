Console.Write("Введите имя пользователя: ");
string username  = Console.ReadLine();

if(username.ToLower() == "Pavel")
{
    Console.WriteLine("Урааа пятница");
}
else
{
    Console.Write("Првиет, ");
    Console.WriteLine(username);
}