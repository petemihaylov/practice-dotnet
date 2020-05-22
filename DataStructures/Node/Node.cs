using System;
using System.Collections.Generic;
using System.Text;

namespace Node
{
    class Node<Type>
    {
        private Type value;
        private Node<Type> next; // pointer to the next value

        public Node(Type value)
        {
            this.value = value;
        }

        public Type Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public Node<Type> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }




    }
}
