using IntroClasses;

bool isPlaynig = true;
Player hero = new Player();
hero.Display();
while (isPlaynig)
{
   isPlaynig = hero.TakeTurn();
}
Console.WriteLine("Goodbye!");