List<string> list;
list = new List<string>();

List<int> list1 = new List<int>();
var list2 = new List<int>();
List<double> list3 = new();

var list4 = new List<string>()
{
    "Matheus", "Maria", "Cris"
}; 

//METHOD FIND()

List<string> fruits = new()
{
    "Uvas", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

var fruit1 = fruits.Find(Search); //using predicate

var fruit2 = fruits.Find(i => i.Contains('n')); //using lambda

var fruit3 = fruits.FindAll(i => i.Contains('n'));

Console.Write("\nFindAll : ");
foreach (var fruit in fruit3)
{
    Console.Write($"{fruit} ");
}


// Console.WriteLine(fruit1);
// Console.WriteLine(fruit2);

static bool Search(string item)
{
    // return item.Contains('n');
    return item.Contains('n');
}