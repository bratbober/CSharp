using _003_Task;

Point p1 = new Point(1,3);
Point p2 = new Point(5,10);

Circle c1 = new Circle(p1, 5);
Console.WriteLine(c1.Area());
Console.WriteLine(c1.Lenghs());
Console.WriteLine(c1.InCircle(p2));

