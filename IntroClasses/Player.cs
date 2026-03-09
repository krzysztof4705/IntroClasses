namespace IntroClasses;

public class Player
{
    private int _x;
    private int _y;
    private string _avatar = "@";

    public void Display()
    {
        Console.WriteLine(_avatar);
        Console.WriteLine($"Position: {_x}, {_y}");
    }

    public void Move(int diffX, int diffY)
    {
        _x += diffX;
        _y += diffY;
    }
}
