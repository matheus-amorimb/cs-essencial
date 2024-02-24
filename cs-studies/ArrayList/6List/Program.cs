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

var fruit1 = fruits.Find(Search);

Console.WriteLine(fruit1);

static bool Search(string item)
{
    // return item.Contains('n');
    return item.StartsWith('L');
}