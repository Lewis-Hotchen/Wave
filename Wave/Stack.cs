using System;
using System.Collections.Generic;
using System.Text;

namespace Wave
{
    class Stack
    {
        private Node top;
        private int count = 0;
        private char letter;
        public Stack(char letter) {
            top = null;
            this.letter = letter;
        }

        public void push() {
            Node temp = new Node();
            temp.setData(letter);

            if (isEmpty()) {
                top = temp;
                top.setNext(null);  //You REALLY don't need this
            } else {
                temp.setNext(top);
                top = temp;
            }
            count++;
        }

        public void pop() {
            if (!isEmpty()) {
                Node temp = top;
                top = temp.getNext();
                count--;
            }
        }

        public Node peek() {
            return top;
        }

        private String display() {
            StringBuilder sb = new StringBuilder();
            Node temp = top;
            if (isEmpty()) {
                return "Empty Stack";
            }
            while(temp != null) {
                sb.Append(temp.getData());
                temp = temp.getNext();
            }
            return sb.ToString();
        }


        private Boolean isEmpty() {
            return top == null;
        }

        public override String ToString() {
            return display();
        }

    }
}
