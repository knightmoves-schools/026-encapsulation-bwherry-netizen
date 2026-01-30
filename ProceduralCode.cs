namespace knightmoves;

public class ProceduralCode
{

    private int _length;
    private int _height;
    
    public class Rectangle(int length, int height) 
    {
            _length = length;
            _height = height;
    }

    public int CalculateArea() 
    {
        return _length * _height;
    }
}




