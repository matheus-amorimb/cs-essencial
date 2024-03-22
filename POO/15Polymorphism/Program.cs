using _15Polymorphism;

var figures = new List<Figure>()
{
    new Triangle(),
    new Circle()
};

foreach (var figure in figures)
{
    figure.Draw();
}