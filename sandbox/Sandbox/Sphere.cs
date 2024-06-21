class Sphere : Circle
{
    public double _height;
    public Sphere(double r) : base(r) { }
    public override double Area() 
    { 
        return 4 * base.Area();
    }
}