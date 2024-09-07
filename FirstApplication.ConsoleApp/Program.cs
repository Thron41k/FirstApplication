var data = new string?[3];
Console.WriteLine("Как Вас зовут?");
data[0] = Console.ReadLine();
Console.WriteLine("Откуда вы?");
data[1] = Console.ReadLine();
Console.WriteLine("Сколько вам лет?");
data[2] = Console.ReadLine();
Console.WriteLine($"Здравствуйте, {data[0]}! Вам {data[2]} года, вы из {data[1]}.");

