using System;

//Абстракция база класса
abstract class Shape
{
    //общий интерфейс
    public abstract double Area { get; }
    public abstract double Perimeter { get; }
}

class Rectangle : Shape //Наследование
{
    public double Width { get; } //скрытая инкапсуляция
    public double Height { get; }

    public Rectangle(double width, double height) 
    {
        Width = width;
        Height = height;
    }

    public override double Area => Width * Height; //абстрактный метод переопределение от базового класса
    public override double Perimeter => 2 * (Width + Height);

    public override string ToString()
    {
        return $"Rectangle: \n\tWidth = {Width}, \n\tHeight = {Height}, \n\tArea = {Area}, \n\tPerimeter = {Perimeter}";
    }
}


class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area => Math.PI * Radius * Radius;
    public override double Perimeter => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"Circle: \n\tRadius = {Radius}, \n\tArea = {Area}, \n\tPerimeter = {Perimeter}";
    }
}

class Triangle : Shape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double Area
    {
        get
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }

    public override double Perimeter => SideA + SideB + SideC;

    public override string ToString()
    {
        return $"Triangle: \n\tSide A = {SideA}, \n\tSide B = {SideB}, \n\tSide C = {SideC}, \n\tArea = {Area}, \n\tPerimeter = {Perimeter}";
    }
}
