// See https://aka.ms/new-console-template for more information
using datastructures;
using System.Collections.Concurrent;
using static datastructures.arraysclass;

//arraysclass.Main();
//arraysclass.Animal animal1 = new arraysclass.Animal("Hippo", "Mon Deng","Brown");
//arraysclass.Animal animal2 = new arraysclass.Animal("Penguin", "Pesto", "Black");

//animal1.introduceSelf();
//animal2.introduceSelf();

//arraysclass.Person person1 = new arraysclass.Person("CareTaker1", "harsh" , true);
//arraysclass.Person person2 = new arraysclass.Person("CareTaker2", "caring", false);

//person1.animal = animal1;
//person2.animal = animal2;

//person2.animal.introduceSelf();


//linkedlistclass.node node1 = new linkedlistclass.node(6);
//linkedlistclass.node node2 = new linkedlistclass.node(10);
//linkedlistclass.node node3 = new linkedlistclass.node(15);
//linkedlistclass.node node4 = new linkedlistclass.node(20);
//linkedlistclass.node node5 = new linkedlistclass.node(25);

//node1.next = node2;
//node2.next = node3;
//node3.next = node4;
//node4.next = node5;

//Console.WriteLine("This is linked list: ");
//Console.WriteLine(linkedlistclass.printallnodes(node1));

//stacksandqueues stack1 = new stacksandqueues(5);
//stack1.Push(1);
//stack1.Push(2);
//stack1.Push(3);
//stack1.Push(4);
//stack1.Push(5);

//Console.WriteLine("The current list for the stack: ");
//foreach (var item in stack1.array)
//{
//    Console.Write(item + ", ");
//}

//treeclass.tree trees = new treeclass.tree();
//trees.insert(39);
//trees.insert(8);
//trees.insert(45);
//trees.insert(40);
//trees.insert(52);
//trees.insert(44);
//trees.insert(53);
//Console.WriteLine("Present Numbers: ");
//trees.currently(trees.returntoroot());
//Console.WriteLine(" ");
//Console.WriteLine();
//Console.WriteLine("Advance Numbers: ");
//trees.before(trees.returntoroot());
//Console.WriteLine(" ");
//Console.WriteLine();
//Console.WriteLine("After Numbers: ");
//trees.after(trees.returntoroot());

//graphsclass graphs = new graphsclass(5);
//graphs.Addnum(0,1);
//graphs.Addnum(0,2);
//graphs.Addnum(1,2);
//graphs.Addnum(2,1);
//graphs.Addnum(2,4);
//graphs.Addnum(3,4);
//graphs.Addnum(4,4);
//graphs.PrintAdjancent();

//Console.WriteLine("Graphs 1 starting from Vertex 1:");
//graphs.graphss1(1);
//Console.WriteLine("Graphs 2 starting from Vertex 1:");
//graphs.graphss2(1);

//hashingclass.HashTable hasht = new hashingclass.HashTable(15);
//hasht.insert("Jane");
//hasht.insert("maria");
//hasht.insert("john");
//hasht.insert("masayoshi");
//hasht.insert("quarterjade");


//heapsclass.node root = new heapsclass.node(45);
//heapsclass.Max_heap heap = new heapsclass.Max_heap(root);
//heap.insert(new heapsclass.node(23));
//heap.insert(new heapsclass.node(8));
//heap.insert(new heapsclass.node(15));

//Console.WriteLine(" ");
//heap.bfs_travers();

//sortclass.quicksortclass quick = new sortclass.quicksortclass();

int[] arr = { 3, -2, 0, -1, 2, 4, 1 };
//quick.QuickSort(arr ,0, 6);
//quick.printal(arr);

//sortclass.bubblesort bubl = new sortclass.bubblesort();
//bubl.bubbles(arr);
//bubl.printal(arr);

//sortclass.selectionsortcl sel = new sortclass.selectionsortcl();
//sel.selection(arr);
//sel.printal(arr);

//sortclass.mergesortcl mer = new sortclass.mergesortcl();
//mer.mergesor(arr);
//mer.printal(arr);

//sortclass.insertionsortcl ins = new sortclass.insertionsortcl();
//ins.insertion(arr);
//ins.printal(arr);

//int num1 = -1;
//int num = searchingalgo.linearclass.linearsearch(arr, num1);
//searchingalgo.linearclass.printal(num);

//int num = searchingalgo.binaryclass.binaryse(arr, num1);
//searchingalgo.binaryclass.printal(num);

//int[] array = { 30, 15, 10, 2, 1 };
////int num = 78;
////greedyalgo.greedyclas(array, num);

//Console.WriteLine("Orifinal Array: " + string.Join(",", array));
//divideandcon.mergesor(array, 0, array.Length-1);
//Console.WriteLine("Sorted Array: " + string.Join(",", array));

//int[] arr = { 20, 25, 30, 40 };
int num = 25;
//var comb = new List<List<int>>();
//backtrackingcl.combinationcl(arr, num, 0, new List<int>(), comb);
//backtrackingcl back = new backtrackingcl();
//back.printal(comb);

//int fd = spaceandtimecl.lineart.findnum(arr, num);
//if (fd == 0)
//{
//    Console.WriteLine("Sorry but your number isnt found");
//}
//else
//{
//    Console.WriteLine("Your number has been found");
//}

//spaceandtimecl.quadrat quad = new spaceandtimecl.quadrat();
//quad.bblsort(arr);
//quad.printal(arr);
