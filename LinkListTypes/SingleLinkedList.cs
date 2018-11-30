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
            while(n.link != null)
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
                temp.link = start;
                start = temp;
                Console.WriteLine("Node was inserted in the begining since the list is empty");
                return;
            }
            n = start;
            while(n.link != null){
                n = n.link;
            }
            n.link = temp;
            Console.WriteLine("--Inserted");
        }

        public void InsertAfterNode(int i, int x){
            Node temp = new Node(i);
            Node n;
            if(start == null){
                temp.link = start;
                start = temp;
                Console.WriteLine("Node was inserted in the begining since the list is empty");
                return;
            }
            n = start;
            while(n.link != null){
                if(n.info == x){
                    break;
                }
                n = n.link;
            }
            if(n.link == null){
                Console.WriteLine("Node[element] not found. Try again");
                return;
            }else{
                temp.link = n.link;
                n.link = temp;
            Console.WriteLine("Node inserted after the "+ x +" element");
            }   
        }

        public void InsertBeforeNode(int i, int x){
            Node temp = new Node(i);
            Node n;
            if(start == null){
                temp.link = start;
                start = temp;
                Console.WriteLine("Node was inserted in the begining since the list is empty");
                return;
            }
            n = start;
            while(n.link != null){
                if(n.link.info == x){
                    break;
                }
                n = n.link;
            }
            if(n.link == null){
                Console.WriteLine("Node[element] not found. Try again");
                return;
            }else{
                temp.link = n.link;
                n.link = temp;
            Console.WriteLine("Node inserted before the "+ x +" element");
            }   
        }

        public void InsertNodeSpecific(int i, int x){
            int count = 0; 
            Node temp = new Node(i);
            Node n;
            if(start == null){
                temp.link = start;
                start = temp;
                Console.WriteLine("Node was inserted in the begining since the list is empty");
                return;
            }
            n = start;
            if(x == 1){
                temp.link = start;
                start = temp;
                Console.WriteLine("Node inserted in position "+ x);
                return;
            }
            if(x == 0){
                Console.WriteLine("0 is not a valid position. retry");
            }
            for(int j = 1; j < x-1 && n.link != null; j++){
                n = n.link;
            }
            while(n.link != null){
                if(count < x){
                    break;
                }
                count++;
                n = n.link;
            }
            if(n.link == null){
                Console.WriteLine("Node[element] not found. Try again");
                return;
            }else{

                temp.link = n.link;
                n.link = temp;
            Console.WriteLine("Node inserted in position "+ x);
            }   
        }
    }
}