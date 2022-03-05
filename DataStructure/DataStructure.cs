﻿using MyDataStructureLibrary;

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

Console.WriteLine("Insert 40 after 30");
int pos = list.Index(30);
list.Insert(pos + 1, 40);

Console.WriteLine("updated list:");
list.Display();
Console.ReadKey();