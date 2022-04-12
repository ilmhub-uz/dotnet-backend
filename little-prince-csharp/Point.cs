public struct Point
{
    // 1. no return type
    // 2. always public
    // 3. same name as struct/class
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; set; }
    
    public int Y { get; set; }
    
    
    public double DistanceTo(Point point)
    {
        var aKvadrat = Math.Pow(point.X - X, 2);
        var bKvadrat = Math.Pow(point.Y - Y, 2);
        var cKvadrat = aKvadrat + bKvadrat;

        return Math.Sqrt(cKvadrat);
    }
}