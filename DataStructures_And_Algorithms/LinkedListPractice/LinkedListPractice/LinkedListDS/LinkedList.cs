using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice.LinkedListDS
{
    public class LinkedList
    {
       public Node head;

        /// <summary>
        /// Create Linked list
        /// </summary>
        /// <returns></returns>
        public static LinkedList CreateLinkedList()
        {
            LinkedList l = new LinkedList();

            l.head = new Node(0);
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            l.head.next = n1;
            n1.next = n2;
            n2.next = n3;

            return l;
        }

        /// <summary>
        /// To display the data of linkedlist
        /// </summary>
        /// <param name="list"></param>
        public static void DisplayData(LinkedList list)
        {
            if (list.head == null)
            {
                Console.WriteLine("LINKED LIST IS EMPTY!!!");
            }
            else
            {
                Node tempNode = list.head;
                while (tempNode != null)
                {
                    Console.WriteLine(tempNode.data);
                    tempNode = tempNode.next;
                }
            }
        }

        /// <summary>
        /// To add a new node at the end of the linked list.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static LinkedList PushNodeAtTheEndOfList(LinkedList list, int data)
        {
            Node newNode = new Node(data);
            Node lastNode = list.head;

            while(lastNode.next != null)
            {
                lastNode = lastNode.next;
            }

            if(lastNode.next == null)
            {
                lastNode.next = newNode;
            }

            return list;
        }        

        /// <summary>
        /// Add the node at the beginning of the list.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static LinkedList PushNodeAtBeginningOfList(LinkedList list, int data)
        {
            Node newHead = new Node(data);
            newHead.next = list.head;
            list.head = newHead;
            return list;
        }

        /// <summary>
        /// Push the node at given position
        /// </summary>
        /// <param name="list"></param>
        /// <param name="data"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static LinkedList PushNodeAtGivenPosition(LinkedList list, int data, int position)
        {
            if(position < GetSize(list))
            {
                Node newNode = new Node(data);
                int counter = 0;
                Node prevNode = list.head;
                Node tempNode;
                while(counter < position)
                {
                    prevNode = prevNode.next;
                    counter++;
                }
                if(counter == position)
                {
                    tempNode = prevNode.next;
                    prevNode.next = newNode;
                    newNode.next = tempNode;
                }
            }
            else
            {
                Console.WriteLine("POSITION OUT OF INDEX !!");
            }

            return list;
        }

        public static LinkedList DeleteNodeFromListOnBasisOfPosition(LinkedList list, int position)
        {
            if(position > GetSize(list))
            {
                Console.WriteLine("POSITION IS OUT OF INDEX !!");
                return list;
            }
            int counter = 0;
            Node tempNode = list.head;
            Node prev;
            while(counter < position)
            {
                tempNode = tempNode.next;
                counter++;
            }
            if(counter == position)
            {
                prev = tempNode;
                tempNode = tempNode.next;
                prev.next = tempNode.next;
            }

            return list;
        }

        /// <summary>
        /// Gets the size of linked list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static int GetSize(LinkedList list)
        {
            int counter = 0;
            Node tempNode = list.head;
            while(tempNode != null)
            {
                counter++;
                tempNode = tempNode.next;
            }
            return counter;
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
