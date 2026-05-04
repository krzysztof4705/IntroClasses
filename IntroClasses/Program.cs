using IntroClasses;

bool isPlaynig = true;
Vector2D startingPosition = new Vector2D(4, 2);
Character hero = new Player(startingPosition);
startingPosition.X = 0;
startingPosition.Y = 0;
// startingPosition = new Vector2D(0, 0);
Character anotherHero = new NPC(startingPosition);
List<Character> characters= [ hero, anotherHero];

foreach (Character character in characters)
{
   character.Display();
}
while (isPlaynig)
{
   foreach(Character character in characters)
   {
       character.TakeTurn();

   }
}
Console.WriteLine("Goodbye!");