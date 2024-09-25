int[] age = new int[3];
string[] name = new string[3];
try
{
    Console.WriteLine("Каталог пользователей. \nБудет предложено ввести 3 пользователя.");
    Console.Write("Пользователь 1 (Имя): ");
    name[0] = Console.ReadLine();
    Console.Write("Пользователь 1 (Возраст): ");
    age[0] = int.Parse(Console.ReadLine());

    Console.Write("Пользователь 2 (Имя): ");
    name[1] = Console.ReadLine();
    Console.Write("Пользователь 2 (Возраст): ");
    age[1] = int.Parse(Console.ReadLine());

    Console.Write("Пользователь 3 (Имя): ");
    name[2] = Console.ReadLine();
    Console.Write("Пользователь 3 (Возраст): ");
    age[2] = int.Parse(Console.ReadLine());

    Console.WriteLine("Укажите номер пользователя которого хотите найти: ");
    int i = int.Parse(Console.ReadLine());
    Console.WriteLine($"Пользователь {i} - Имя: {name[i]} Возраст: {age[i]}");  


} catch (Exception ex)
{
    Console.WriteLine($"Вы ввели некорректные данные. {ex.Message}");
}