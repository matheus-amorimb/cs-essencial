HashSet<int> numbers = new HashSet<int>{1, 2, 3, 4, 5};
HashSet<string> fruits = new HashSet<string>{"uva", "banana", "pera"};
HashSet<int> evenNumbers = new HashSet<int>();
for(int i = 0; i < 6; i++)
{
    evenNumbers.Add(i * 2);
}

//Constructor using IEnumerable
var odds = new int[] {1, 3, 5, 7, 9, 11, 13};
HashSet<int> set = new HashSet<int>(odds);

//Methods
var spTeams = new HashSet<string>() {"Palmeiras", "São Paulo", "Santos"};
var rjTeams = new HashSet<string>() {"Vasco", "Flamengo","Fluminense"};
var baTeams = new HashSet<string>() {"Bahia", "Viória","Juazeiro"};
var clubWorldCupChampions = new HashSet<string>(){"Santos", "Palmeiras", "São Paulo", "Flamengo"};

if(!(spTeams.Contains("Corinthians")))
{
    spTeams.Add("Corinthians");
}

Console.WriteLine("\n##### Is there at least one team from rj with CWCT? #####");
Console.WriteLine(rjTeams.Overlaps(clubWorldCupChampions));

Console.WriteLine("\n##### Is spTeams a subset of clubWorldCupChampions? #####");
Console.WriteLine(spTeams.IsSubsetOf(clubWorldCupChampions));

Console.WriteLine("\n##### Union between sp, ba e rj teams #####");
spTeams.UnionWith(baTeams);
spTeams.UnionWith(rjTeams);

foreach (var team in spTeams)
{
    Console.Write($"{team}, ");
}

Console.WriteLine("\n\n##### Teams from sp, ba e rj ordered #####");
var allTimes = new SortedSet<string>(spTeams);

foreach (var team in allTimes)
{
    Console.Write($"{team}, ");
}

Console.WriteLine("\n\n##### Teams with CWCT #####");
spTeams.IntersectWith(clubWorldCupChampions);
foreach (var team in spTeams)
{
    Console.Write($"{team}, ");
}