using comp348_a4_q12;

// Q1
Console.WriteLine("Q1:");
Rectangle? r1 = new(1.2,2.2);
Circle? c1 = new(1.1);
Console.WriteLine("Rectangle Perimeter: " + r1?.GetPerimeter());
Console.WriteLine("Rectangle Area: " + r1?.GetArea());
Console.WriteLine("Circle Perimeter: " + c1?.GetPerimeter());
Console.WriteLine("Circle Area: " + c1?.GetArea());
Console.WriteLine("Rectangle ToString: " + r1);
Console.WriteLine("Circle ToString: " + c1);
Console.WriteLine();

// Q2
Console.WriteLine("Q2:");
Rectangle? r2noparam = new();
Rectangle? r2param = new(1.4,2.1);
Rectangle? r2noparamparse = Rectangle.Parse("Rectangle");
Rectangle? r2paramparse = Rectangle.Parse("Rectangle,1.4,2.1");
Circle? c2noparam = new();
Circle? c2param = new(2.3);
Circle? c2noparamparse = Circle.Parse("Circle");
Circle? c2paramparse = Circle.Parse("Circle,2.3");

Console.WriteLine("Rectangle:");
Console.WriteLine("ToString:");
Console.WriteLine(r2noparam);
Console.WriteLine(r2param);
Console.WriteLine(r2noparamparse);
Console.WriteLine(r2paramparse);
Console.WriteLine("Print:");
r2noparam?.Print();
r2param?.Print();
r2noparamparse?.Print();
r2paramparse?.Print();
Console.WriteLine("Rectangle Perimeter: " + r2paramparse?.GetPerimeter());
Console.WriteLine("Rectangle Area: " + r2paramparse?.GetArea());
Console.WriteLine();

Console.WriteLine("Circle:");
Console.WriteLine("ToString:");
Console.WriteLine(c2noparam);
Console.WriteLine(c2param);
Console.WriteLine(c2noparamparse);
Console.WriteLine(c2paramparse);
Console.WriteLine("Print:");
c2noparam?.Print();
c2param?.Print();
c2noparamparse?.Print();
c2paramparse?.Print();
Console.WriteLine("Circle Perimeter: " + c2paramparse?.GetPerimeter());
Console.WriteLine("Circle Area: " + c2paramparse?.GetArea());
