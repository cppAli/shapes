using System;

static void PrintShapesInfo(Shape[] shapes)
{
    foreach (Shape shape in shapes)
    {
        Console.WriteLine(shape.ToString());
        Console.WriteLine();
    }
}


Shape[] shapes = new Shape[3];
shapes[0] = new Rectangle(6, 3);
shapes[1] = new Circle(3);
shapes[2] = new Triangle(3, 4, 5);

PrintShapesInfo(shapes);