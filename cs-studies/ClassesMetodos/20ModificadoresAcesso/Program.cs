using _20ModificadoresAcesso;

MyClass myClass = new MyClass();
//myClass.MyField; //cannot access private field

MyStruct myStruct = new MyStruct();
//myStruct.MyField;//cannot access private field

Console.WriteLine(MyEnum.option1);