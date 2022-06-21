Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower == "Маша") //== равен .ToLower перевод всех букв в нижний регистр
{
    Console.WriteLine("Ура, это же МАША!");
}
else {
    Console.Write("Привет, ");
    Console.WriteLine(username);
}