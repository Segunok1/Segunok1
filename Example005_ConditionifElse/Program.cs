Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);  
}

