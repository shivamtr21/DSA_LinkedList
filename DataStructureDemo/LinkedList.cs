﻿using DataStructureDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data); //object of new and push data into node
            if (this.head == null)
                this.head = node;

            else
            {

                Node temp = head;
                while (temp.next != null)
                {
                    //Console.WriteLine("temp value is " +temp.next.data);
                    temp = temp.next;

                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
            // Console.WriteLine("Value of node is: " + node);
        }

        internal void Display()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node InsertAtPerticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");

            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;

                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("position out of range");
            }
            Console.WriteLine("inserted value is " + head);
            return head;

        }


    }
}

