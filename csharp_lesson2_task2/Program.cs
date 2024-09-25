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

    switch(i)
    {
        case 1: 
            Console.WriteLine($"Пользователь 1 - Имя: {name[0]} Возраст: {age[0]}");
            break;
        case 2:
            Console.WriteLine($"Пользователь 2 - Имя: {name[1]} Возраст: {age[1]}");
            break;
        case 3:
            Console.WriteLine($"Пользователь 3 - Имя: {name[2]} Возраст: {age[2]}");
            break;
        default:
            Console.WriteLine("Данный пользователь не найден");
            break;
    }

} catch (Exception ex)
{
    Console.WriteLine($"Вы ввели некорректные данные. {ex.Message}");
}