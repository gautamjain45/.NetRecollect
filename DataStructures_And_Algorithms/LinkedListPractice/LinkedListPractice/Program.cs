using System;
using LinkedListPractice.LinkedListDS;

namespace LinkedListPractice
{
    class Program 
    {
        static void Main(string[] args)
        {
            var list = LinkedList.CreateLinkedList();
            var newNodeAddedAtEnd = LinkedList.PushNodeAtTheEndOfList(list, 4);
            var newNodeAddedAtBeginning = LinkedList.PushNodeAtBeginningOfList(list, -1);
            var nodeAtGivenPosition = LinkedList.PushNodeAtGivenPosition(list,99,3);
            var deleteNodeAtGivenPosition = LinkedList.DeleteNodeFromListOnBasisOfPosition(list,3);
            LinkedList.DisplayData(deleteNodeAtGivenPosition);
        }
    }
}
