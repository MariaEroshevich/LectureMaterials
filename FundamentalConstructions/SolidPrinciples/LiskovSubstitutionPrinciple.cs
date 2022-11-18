abstract class Figure
{
    protected double Width = 0;
    protected double Height = 0;

    public abstract double GetArea();
}

class Rectangle : Figure
{
    public Drawable Render(double area)
    {
        // ...
    }

    public void SetWidth(double width)
    {
        Width = width;
    }

    public void SetHeight(double height)
    {
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }
}

class Square : Figure
{
    public double SetWidth(double width)
    {
        return Width = Height = width;
    }

    public double SetHeight(double height)
    {
        return Width = Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }
}

    Drawable RenderLargeRectangles(Figure rectangles)
    {
        foreach (rectangle in rectangles)
        {
            rectangle.SetWidth(4);
            rectangle.SetHeight(5);
            var area = rectangle.GetArea(); // BAD: Will return 25 for Square. Should be 20.
            rectangle.Render(area);
        }
    }


var shapes = new[] { new Rectangle(), new Rectangle(), new Square() };
RenderLargeRectangles(rectangles);