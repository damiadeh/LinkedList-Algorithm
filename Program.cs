﻿using System;
using LinkedList.LinkedListTypes;

namespace LinkedList
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int choice,data,a,b;
            bool state = true;

            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();
            while(state)
            {
                Console.WriteLine("Select which algorithm you want to run :-)");
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Show the number of nodes in list");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in the begining/empty list");
                Console.WriteLine("5. Insert a node at the end of the list");
                Console.WriteLine("6. Insert a node after a specified node");
                Console.WriteLine("7. Insert a node before a specified node");
                Console.WriteLine("8. Insert a node in a given position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete a node");
                Console.WriteLine("12. Reverse the list");

                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 19) break;

                switch(choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.WriteLine("Enter the element to search for:");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.SearchList(data);
                        break;
                    case 4:
                        Console.WriteLine("Enter the element to insert to the list:");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBeginning(data);
                        break;
                    case 5:
                        Console.WriteLine("Enter the element to insert to the list:");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 6:
                        Console.WriteLine("Enter the element to insert to the list:");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the node[element] you want to insert it after:");
                        a = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfterNode(data, a);
                        break;
                    case 7:
                        Console.WriteLine("Enter the element to insert to the list:");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the node[element] you want to insert it before:");
                        a = Convert.ToInt32(Console.ReadLine());
                        list.InsertBeforeNode(data, a);
                        break;
                    case 8:
                        Console.WriteLine("Enter the element to insert to the list:");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the position you want to insert it:");
                        a = Convert.ToInt32(Console.ReadLine());
                        list.InsertNodeSpecific(data, a);
                        break;
                    case 9:
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        list.DeleteLastNode();
                        break;
                    case 11:
                        Console.WriteLine("Enter the element you want to delete:");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 12:
                        list.ReverseList();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine("Enter 1 to continue or 0 to quit");
                
                try{
                    int stateCode = Convert.ToInt16(Console.ReadLine());
                    if(stateCode == 0){
                    state = false;
                    }
                }catch(Exception){

                }
                
            }
            Console.WriteLine("Exiting.....");
            Console.WriteLine("Bye :-/");
        }
    }
}
