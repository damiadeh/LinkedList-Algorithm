using System;

namespace LinkedList.LinkedListTypes
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }
        
        public void CreateList()
        {
            int i,n,data;

            Console.WriteLine("Enter number of nodes to insert:");
            n = Convert.ToInt32(Console.ReadLine());

            if(n == 0){
                return;
            }          
            for(i = 1; i <= n; i++){
                Console.WriteLine("Enter the element to insert in position " +i+":");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }  
        }
        public void DisplayList()
        {
            Node n;
            if(start == null){
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List contains : ");
            n = start;
            while(n != null)
            {
                Console.Write(n.info + " ");
                n =n.link;
            }
            Console.WriteLine(n.info + " ");
        }
        public void CountNodes()
        {
            int count = 0;
            Node n = start;
            while(n != null){
                count++;
                n = n.link;
            }
            Console.WriteLine("There are " + count + " node(s) in the list");
        }

        public void SearchList(int i)
        {
            int position = 1;
            Node n = start;
            while(n != null){
                position++;
                n = n.link;
            }
            if(n == null){
                Console.WriteLine(i + " is not found in the list");
            }else{
                Console.WriteLine("The Node info("+ i +") ");
            }
        }

        public void InsertAtBeginning(int i)
        {
            Node temp = new Node(i);
                temp.link = start;
                start = temp;
                Console.WriteLine("--Inserted");
        }

        public void InsertAtEnd(int i)
        { 
            Node temp = new Node(i);
            Node n;
            if(start == null){
                start = temp;
                Console.WriteLine("Node was inserted in the begining since the list is empty");
                return;
            }
            n = start;
            while(n != null){
                n = n.link;
            }
            n.link = temp;
            Console.WriteLine("--Inserted");
        }
    }
}