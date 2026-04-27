namespace IntroClasses;

public class Player
{
   private Vector2D _position = new Vector2D(4, 2);
    private string _avatar = "@";

    public Player(Vector2D startingPosition)
    {
        _position = startingPosition;
    }

    public void Display()
    {
        Console.SetCursorPosition(_position.X,_position.Y);
        Console.Write(_avatar);
    }

    public void Move(int diffX, int diffY)
    {
        int targetX= _position.X + diffX;
        int targetY = _position.Y + diffY;
        if (targetX>= 0 && targetX < Console.BufferWidth)
        {
        _position.X = targetX;
        }
        if (targetY >= 0 && targetY < Console.BufferHeight)
        {
            _position.Y = targetY;
        }
    }
   

    public bool TakeTurn()
    {
        bool isPlaying = true;
        ConsoleKeyInfo input = Console.ReadKey(true);
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.Write(" ");
        switch (input.Key)
        {
            case ConsoleKey.S:
                Move(0, 1);
                break;
            case ConsoleKey.W:
                Move(0, -1);
                break;
            case ConsoleKey.A:
                Move(-1, 0);
                break;
            case ConsoleKey.D:
                Move(1, 0);
                break;
             case ConsoleKey.Q:
                isPlaying = false;
                  break;
        }
        Display();
        return isPlaying;
    }
}
