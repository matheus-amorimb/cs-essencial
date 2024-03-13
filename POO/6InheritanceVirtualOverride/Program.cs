Cat cat = new Cat();
cat.Name = "Garfield";

Dog dog = new Dog();
dog.Name = "Max";

Console.WriteLine(cat.DisplayName());
Console.WriteLine(dog.DisplayName());
class Animal
{
    public string? Name {get; set;}
    public virtual string DisplayName() => $"Hey, I'm {Name}";
}

class Cat : Animal
{
    public override string DisplayName() => $"Hey, I'm {Name} and I'm a cat";
}
class Dog : Animal
{ }


