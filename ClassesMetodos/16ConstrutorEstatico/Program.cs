using _16ConstrutorEstatico;

//Invoca o construtor parametrizado e o estático
Person p1 = new Person(25, "Matheus");
Console.WriteLine($"{p1.Name}: {p1.Age}");
Console.WriteLine($"MinimumAge: {Person.MinimumAge}");
Console.WriteLine();

//Invoca somente o construtor parametrizado
//O construtor estático é chamado uma única vez
Person p2 = new Person(24, "Maria");
Console.WriteLine($"{p2.Name}: {p2.Age}");
Console.WriteLine($"MinimumAge: {Person.MinimumAge}");
