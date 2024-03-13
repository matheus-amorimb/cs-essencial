var creditLimit = new List<Limit>();

for (int i = 1; i < 16; i++)
{
    creditLimit.Add(new Limit(){Number = i});
}

// var limitsWithRestriction = creditLimit.Where(x => x.CheckLimit());
//limitsWithRestriction[0]; Cannot apply indexing to an expression of type 'System.Collections.Generic.IEnumerable<Limit>'

var limitsWithRestriction = creditLimit.Where(x => x.CheckLimit()).ToList();

//IT'S BETTER TO USE IEnumerable
var firstLimitWithRestriction = limitsWithRestriction.FirstOrDefault();

// IT'S BETTER TO USE TO.LIST(). IEnumerable WOULD EVALUATE TWO TIMES IN THIS CASE
// if (limitsWithRestriction.Count() > 3)
// {
//     Console.WriteLine("\n ### Temos mais de 3 limites com restrição");
// }
//
// if (limitsWithRestriction.Count() > 5)
// {
//     Console.WriteLine("\n ### Temos mais de 5 limites com restrição");
// }



Console.WriteLine("\n Fim do processamento");
public class Limit
{
    public int Number { get; set; }
    private bool _isRestriciton;

    public Limit()
    {
        var seed = Guid.NewGuid().GetHashCode();
        var randomNumber = new Random(seed).Next(1, 4);
        _isRestriciton = randomNumber == 1;
    }

    public bool CheckLimit()
    {
        Console.WriteLine($"Executa análise de limite de Crédito para o limite {Number}");
        return _isRestriciton;
    }
}