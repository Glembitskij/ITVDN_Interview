// 1. В чому різниця між классом та структурою?
// 2. Чи може структура наслідуватись від структури?, классу, інтерфейсу?
// 3. Яка операція буде відбуватися на, 9-мо рядоку, в чому є недолік цієї операції. 

Point[] points = CreateRandomPoint(1000);

foreach (Point point in points)
{
    Console.WriteLine(point);
}

static Point[] CreateRandomPoint(int count)
{
    Point[] points = new Point[count];
    Random random = new Random();

    for (int i = 0; i < count; i++)
    {
        points[i] = new Point() { X = random.Next(1, 100), Y = random.Next(1, 100) };
    }

    return points;
}

struct Point
{
    public int X { get; set; }

    public int Y  { get; set; }

    public override string ToString()
    {
        return $"{X} - {Y}";
    }
}
