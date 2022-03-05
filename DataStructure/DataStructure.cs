using MyDataStructureLibrary;

Console.Title = "My Data Structure";
Console.WriteLine("==========Custom Data Structure==========");

UnOrderedLinkedList<int> list = new UnOrderedLinkedList<int>();

Console.WriteLine("Adding 56, 30, 70 to list");
list.Append(56);
list.Append(30);
list.Append(70);

Console.WriteLine("\nInserting 30 at pos 1");
list.Insert(1, 30);


Console.WriteLine("List 1");
list.Display();
Console.ReadKey();