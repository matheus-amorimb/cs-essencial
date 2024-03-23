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

var spTeams = new HashSet<string>() {"Palmeiras", "São Paulo","Corinthians"};
var rjTeams = new HashSet<string>() {"Vasco", "Flamengo","Fluminense"};
var baTeams = new HashSet<string>() {"Bahia", "Viória","Juazeiro"};
var clubWorldCupChampions = new HashSet<string>(){"Santos", "Palmeiras", "São Paulo", "Flamengo"};
