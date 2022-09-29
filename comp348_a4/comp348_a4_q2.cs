namespace comp348_a4_q12
{
    public static class Extensions
    {
        public static void Print(this IShape shape)
        {
            Console.WriteLine(shape);
        }
    }

    public partial class Rectangle
    {
        const string RectangleConst = "Rectangle";

        public static Rectangle? Parse(string input)
        {
            string[] inputSplit = input.Split(',');

            if (inputSplit.Length == 3)
            {
                if (inputSplit[0] == RectangleConst)
                {
                    bool isNumericLength = double.TryParse(inputSplit[1], out double length);
                    bool isNumericWidth = double.TryParse(inputSplit[2], out double width);

                    if (isNumericLength && isNumericWidth)
                    {
                        return new Rectangle(length, width);
                    }
                }
            }
            else if (inputSplit.Length == 1)
            {
                if (inputSplit[0] == RectangleConst)
                {
                    return new Rectangle();
                }
            }
            Console.WriteLine("Error, Invalid Shape");
            Environment.Exit(-1);
            return null;
        }
    }

    public partial class Circle 
    {
        const string CircleConst = "Circle";

        public static Circle? Parse(string input)
        {
            string[] inputSplit = input.Split(',');

            if (inputSplit.Length == 2)
            {
                if (inputSplit[0] == CircleConst)
                {
                    bool isNumericRadius = double.TryParse(inputSplit[1], out double radius);

                    if (isNumericRadius)
                    {
                        return new Circle(radius);
                    }
                }
            }
            else if (inputSplit.Length == 1)
            {
                if (inputSplit[0] == CircleConst)
                {
                    return new Circle();
                }
            }
            Console.WriteLine("Error, Invalid Shape");
            Environment.Exit(-1);
            return null;
        }
    }
}
