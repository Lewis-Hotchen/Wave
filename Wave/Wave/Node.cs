using System;
using System.Collections.Generic;
using System.Text;

namespace Wave
{
    class Node
    {
        private char data;
        Node next;
        Node prev;
        public Node() {
        }

        public Node getNext() {
            return next;
        }

        public Node getPrev() {
            return prev;
        }

        public void setNext(Node next) {
            this.next = next;
        }

        public void setPrev(Node prev) {
            this.prev = prev;
        }

        public void setData(char data) {
            this.data = data;
        }

        public char getData() {
            return data;
        }
    }
}
