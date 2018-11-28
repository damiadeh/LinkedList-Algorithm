using System;

namespace LinkedList
{
    class Node
    {
        public int info; //can be any primitive type
        public Node link;
        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}