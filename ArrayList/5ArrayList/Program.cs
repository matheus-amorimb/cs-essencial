using System.Collections;

//INITIALIZER
ArrayList list;
list = new ArrayList();

ArrayList list1 = new ArrayList();

var list2 = new ArrayList();

ArrayList list3 = new ();

ArrayList list4 = new ArrayList(5);

var list5 = new ArrayList(5);

ArrayList list6 = new (5);

ArrayList list7 = new (5);

list7.Add("Paulo");
list7.Add(4.5);
list7.Add(5);
list7.Add(true);
list7.Add("");
list7.Add(null);

var list8 = new ArrayList(){"Paulo", 4.5, 5, true, " ", null};

//ADD
list7.Insert(1, "Matheus");

foreach (var item in list7)
    
{
    Console.WriteLine(item);
}