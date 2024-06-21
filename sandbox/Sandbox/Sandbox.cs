class Program
{
    static void Main()
    {
        string greeting = "Hello, World!";
        Console.WriteLine(greeting);

        List<RoundShape> mylist = new List<RoundShape>();

        mylist.Add(new Circle(1));
        mylist.Add(new Cylinder(1, 2));
        mylist.Add(new Sphere(1));

        foreach (RoundShape shape in mylist)
        {
            Console.WriteLine(shape.Area());
        }
    }
}