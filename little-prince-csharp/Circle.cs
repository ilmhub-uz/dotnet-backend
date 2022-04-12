public struct Circle
{
    public Circle(Point center, int radius)
    {
        Radius = radius;
        Center = center;
    }

    public int Radius { get; set; }
    
    public Point Center { get; set; }
    
    
    public bool IsInside(Point point)
    {
        var distanceToCenter = point.DistanceTo(Center);

        return distanceToCenter < Radius;
    }
}