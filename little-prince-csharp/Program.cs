var testCases = int.Parse(Console.ReadLine());

while(testCases-- > 0)
{
    var coords = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    var shaxzoda = new Point(coords[0], coords[1]);
    var malika = new Point(coords[2], coords[3]);

    var numOfPlanets = int.Parse(Console.ReadLine());

    var kesibOtishlar = 0;

    while(numOfPlanets-- > 0)
    {
        var planetCoords = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        
        var planet = new Circle(new Point(planetCoords[0], planetCoords[1]), planetCoords[2]);

        var shaxzodaIchidami = planet.IsInside(shaxzoda);
        var malikaIchidami = planet.IsInside(malika);

        var kesibOtadimi = shaxzodaIchidami ^ malikaIchidami;
        if(kesibOtadimi)
        {
            kesibOtishlar++;
        }
    }

    Console.WriteLine($"{kesibOtishlar}");
}