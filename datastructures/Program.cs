// See https://aka.ms/new-console-template for more information
using datastructures;
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


linkedlistclass.node node1 = new linkedlistclass.node(5);
linkedlistclass.node node2 = new linkedlistclass.node(10);
linkedlistclass.node node3 = new linkedlistclass.node(15);
linkedlistclass.node node4 = new linkedlistclass.node(20);
linkedlistclass.node node5 = new linkedlistclass.node(25);

node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node5;

linkedlistclass.linkedclass printn = new linkedlistclass.linkedclass();
printn.printallnodes();