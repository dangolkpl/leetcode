using System;

namespace Leetcode
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }

    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            this.head = null;
        }

        public void InsertAtFirst(int data)
        {
            var newNode = new Node(data);
            newNode.next = this.head;
            this.head = newNode;
        }

        public void InsertAtLast(int data)
        {
            if (this.head == null)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                this.head = newNode;
                return;
            }

            var currNode = this.head;
            while (currNode.next != null)
            {
                currNode = currNode.next;
            }

            currNode.next = new Node(data);
        }

        public Node GetAtIndex(int index)
        {
            if (index < 0)
            {
                return null;
            }

            var currIndex = 0;
            var currNode = this.head;
            while (currIndex < index)
            {
                if (currNode == null)
                {
                    return null;
                }

                currNode = currNode.next;
                ++ currIndex ;
            }

            return currNode;
        }

        public Node InsertAtIndex(int index, int data)
        {
            if (index < 0)
            {
                return null;
            }

            if (index == 0)
            {
                this.InsertAtFirst(data);
            }

            var preNode = this.GetAtIndex(index - 1);
            var next = preNode.next;
            var newNode = new Node(data);
            preNode.next = newNode;
            newNode.next = next;
            return newNode;
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0 || this.head == null)
            {
                return;
            }

            var preNode = this.GetAtIndex(index - 1);
            preNode.next = this.GetAtIndex(index + 1);
        }

        public void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void ClearAll()
        {
            this.head = null;
        }
    }
}