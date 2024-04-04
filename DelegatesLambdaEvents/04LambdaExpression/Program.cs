List<string> names = new List<string>();
names.Add("Matheus");
names.Add("Pedro");
names.Add("João");

string result = names.Find(name => name.Equals("Matheus"));

Console.WriteLine(result);


