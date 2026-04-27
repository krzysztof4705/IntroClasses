using IntroClasses;

bool isPlaynig = true;
Vector2D startingPosition = new Vector2D(4, 2);
Player hero = new Player(startingPosition);
startingPosition.X = 0;
startingPosition.Y = 0;
// startingPosition = new Vector2D(0, 0);
Player anotherHero = new Player(startingPosition);
hero.Display();
anotherHero.Display();
while (isPlaynig)
{
   isPlaynig = hero.TakeTurn();
   isPlaynig = anotherHero.TakeTurn();
}
Console.WriteLine("Goodbye!");