class Rectangle : Shape {
    private const string  defaultName = "Rectangle";
    private double width;
    private double height;

    public Rectangle(double width, double height, string name = defaultName) : base( name ){
        this.width = width;
        this.height = height;
    }
    public override double Area
    {
        get
        {
            return (width * height);
        }
    }
}