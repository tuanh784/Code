using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestFireSim
{
    class LinkList
    {
        Node head;
        int count;

        public LinkList()
        {
            head = null;
            count = 0;
        }

        public void add(int x, int y)
        {
            Node addedNode = new Node(x, y);
            Node temp = head;
            if (head == null)
            {
                head = addedNode;
            }
            else
            {
                while (temp.getNext() != null)
                {
                    temp = temp.getNext();
                }
                temp.setNext(addedNode);
            }
            count++;
        }

        public Node remove()
        {
            if (count <= 0)
            {
                return null;
            }

            else
            {
                Node temp = head;
                head = head.getNext();
                count--;
                return temp;
            }
        }

        public Boolean isEmpty()
        {
            if (count <= 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

    class Node
    {
        Node next;
        int row;
        int column;


        public Node(int x, int y)
        {
            row = x;
            column = y;
            next = null;
        }

        public Node getNext()
        {
            return next;
        }

        public void setNext(Node x)
        {
            next = x;
        }

        public int getRow()
        {
            return row;
        }

        public int getColumn()
        {
            return column;
        }
    }
}
