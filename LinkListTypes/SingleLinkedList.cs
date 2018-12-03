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
            try{
                n = Convert.ToInt32(Console.ReadLine());
            }catch(Exception){
                return;
            }
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

        public void DeleteFirstNode()
        {
            if(start != null)
            {
                start = start.link;
                Console.WriteLine("First node has been deleted successfully");
            }else{
                Console.WriteLine("Action can't be executed, The link is empty");
            }
        }

        public void DeleteLastNode()
        {
            if(start == null){
                Console.WriteLine("Action can't be executed, The link is empty");
                return;
            }
            if(start.link == null) {
                start = null;
                Console.WriteLine("Success, the only node in the list has been deleted");
                return;
            }
            Node n = start;
            while(n.link.link != null){
                n = n.link;
            }
            n.link = null;
            Console.WriteLine("Last node has been deleted successfully");
        }

        public void DeleteNode(int i)
        {
            if(start == null){
                Console.WriteLine("Action can't be executed, The link is empty");
                return;
            }
            if(start.info == i){
                start = start.link;
            }
            Node n = start;
            while(n.link != null){
                if(n.link.info == i) break;
                n = n.link;
            }
            if(n.link == null){
                Console.WriteLine("Element "+i+" not found");
            }else{
                n.link = n.link.link;
                Console.WriteLine("Node with element "+i+" has been deleted successfully");
            }    
        }

        public void ReverseList()
        {
            if(start == null){
                Console.WriteLine("Action can't be executed, The link is empty");
                return;
            }
            Node n, prev, next;
            prev = null;
            n = start;
            while(n != null){
                next = n.link;
                n.link = prev;
                prev = n;
                n = next;
            }
            start = prev;
        }
    }
}