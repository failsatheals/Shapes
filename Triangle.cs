class Triangle : Shape {
    private const string  defaultName = "Triangle";
    private double width;
    private double height;

    public Triangle(double width, double height, string name = defaultName) : base(name ){
        this.width = width;
        this.height = height;
    }
    public override double Area
    {
        get
        {
            return (.5*width) * height;
        }
    }
}