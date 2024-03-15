using _10InheritanceIsAs;

//############################ AS ############################
Circle circle = new Circle();
Shape shape = circle; //upcasting

Circle circle2 = shape as Circle; //downcasting

Console.WriteLine("############ AS OPERATOR ############");
if (circle2 != null)
{
    circle2.PaintCircle();
}
else
{
    Console.WriteLine("Downcasting operation is invalid");
}

//############################ IS ############################
Circle circleIs = new Circle();
Shape shapeIs = circle;

Console.WriteLine("\n############ IS OPERATOR ############");
if (shapeIs is Circle)
{
    Console.WriteLine("Shape was converted to Circle");
    //((Circle)Forma).PaintCircle();
    var type = shapeIs as Circle;
    type?.PaintCircle();
}
else
{
    Console.WriteLine("Downcasting operation is invalid");
}