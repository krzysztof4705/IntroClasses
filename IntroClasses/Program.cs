using IntroClasses;


Player hero = new Player();
hero.Display();
ConsoleKeyInfo input = Console.ReadKey(true);
switch (input.Key)
{
    case ConsoleKey.S:
        hero.Move(0, 1);
        break;
    case ConsoleKey.W:
        hero.Move(0, -1);
        break;
    case ConsoleKey.A:
        hero.Move(-1, 0);
        break;
    case ConsoleKey.D:
        hero.Move(1, 0);
        break;
} hero.Display();
