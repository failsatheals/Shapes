using System;
class Circle : Shape {
    private const string  defaultName = "Circle";
    private double radius;

    public Circle(double radius,string name = defaultName) : base(name ){
        this.radius = radius;
    }
    public override double Area
    {
        get
        {
            return Math.PI * (Math.Pow(this.radius,2));
        }
    }

}