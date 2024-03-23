Stack<int> numbers = new Stack<int>();
numbers.Push(10);
numbers.Push(20);
numbers.Push(30);

//Not supported
// var value = numbers[0]

int[] array = new int[]{1, 2, 3, 4};
Stack<int> stack1 = new Stack<int>(array);

Console.WriteLine("Elements of the stack");
foreach (var item in stack1)
{
    Console.Write($"{item}, ");
}

var top1 = stack1.Pop();
var top2 = stack1.Peek();

Console.WriteLine($"\n\nHow many items are in the stack? {stack1.Count}");
Console.WriteLine($"Element at the top of the list: {top1}");
Console.WriteLine($"Element at the top of the list after removing {top1}: {top2}");
Console.WriteLine($"Is there a element 10 in the stack? {stack1.Contains(10)}");