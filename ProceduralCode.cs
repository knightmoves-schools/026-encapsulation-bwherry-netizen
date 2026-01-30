namespace knightmoves;

public class Rectangle
{

    private int _length;
    private int _height;
    
    public Rectangle (int length, int height) 
    {
            _length = length;
            _height = height;
    }

    public int CalculateArea() 
    {
        return _length * _height;
    }
}





