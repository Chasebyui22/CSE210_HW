class Cylinder : Circle
{
    public double _height;
    public Cylinder(double r, double h) : base(r) { _height = h; }
    public override double Area() 
    { 
        return 2 * base.Area() + 2 * Math.PI * _radius * _height; 
    }
}