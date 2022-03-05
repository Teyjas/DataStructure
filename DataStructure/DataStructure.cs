using MyDataStructureLibrary;

Console.Title = "My Data Structure";
Console.WriteLine("==========Custom Data Structure==========");

UnOrderedLinkedList<int> list = new UnOrderedLinkedList<int>();

Console.WriteLine("Adding 56, 30, 70 to list");
list.Append(56);
list.Append(30);
list.Display();

Console.WriteLine("\nInserting 30 at pos 1");
list.Insert(1, 30);
list.Display();

Console.WriteLine("List 1");
list.Display();

Console.WriteLine("Searching for 30");
Console.WriteLine(list.Search(30));
Console.WriteLine("Searching for 48");
Console.WriteLine(list.Search(48));
Console.ReadKey();