namespace IntroClasses;

public class Player
{
    private int _x;
    private int _y;
    private string _avatar = "@";

    public void Display()
    {
        Console.SetCursorPosition(_x,_y);
        Console.Write(_avatar);
    }

    public void Move(int diffX, int diffY)
    {
        _x += diffX;
        _y += diffY;
    }
}
