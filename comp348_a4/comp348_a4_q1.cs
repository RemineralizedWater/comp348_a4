namespace comp348_a4_q12
{
    public interface IShape
    {
        string Name { 
            get { return this.GetType().Name; }
            set { } 
        }

        double GetPerimeter();
        double GetArea();
    }

    public partial class Rectangle : IShape
    {
        public Rectangle()
        {
            Length = 0.0;
            Width = 0.0;
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length
        {
            set;
            get;
        }

        public double Width
        {
            set;
            get;
        }

        string Name
        {
            get { return this.GetType().Name; }
            set { }
        }

        public override string ToString()
        {
            return Name + "," + Length + "," + Width;
        }

        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public double GetArea()
        {
            return Length * Width;
        }
    }

    public partial class Circle : IShape
    {
        public Circle()
        {
            Radius = 0.0;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            set;
            get;
        }

        string Name
        {
            get { return this.GetType().Name; }
            set { }
        }

        public override string ToString()
        {
            return Name + "," + Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
