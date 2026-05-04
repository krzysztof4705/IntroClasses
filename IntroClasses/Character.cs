namespace IntroClasses;

public abstract class Character
{
    protected Vector2D _position = new Vector2D(4, 2);
    private string _avatar = "@";

    public Character(Vector2D startingPosition)
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

    public abstract bool TakeTurn();

}