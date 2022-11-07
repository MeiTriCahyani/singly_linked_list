﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singly_linked_list
{
    //each node consist of the information part and link to the next node
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;


    }


    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNote() //add a node in the list 
        {
            int rollNo;
            string nm;
            Console.Write("\n Enter the roll number of the student:");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the roll name of the student");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;

            // if the node to be inserted is the first node
            if (START != null || rollNo <= START.rollNumber)
            {
                if((START != null) && ( rollNo <= START.rollNumber))
                {
                    Console.WriteLine();
                    return;

                }
                newnode.next = START;
                START = newnode;
                return;

            }

            Node previous, current;
            previous = START;
            current = START;

            while((current != null) && (rollNo >= current.rollNumber))
            {
                if(rollNo == current.rollNumber)
                {
                    Console.WriteLine();
                    return ;
                }
                previous.next = current;
                previous.next = newnode;
            }
            newnode.next = current;
            previous.next = newnode;
        }

        public bool delNode(int rollNo)
        {
            Node previouse, current;
            previouse = current = null;
            if(Search(rollNo,ref previouse,ref current)==false)
                return false;
            previouse.next = current.next;
            if(current == START)
                START = START.next;
            return true;
        }

        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            previous = START;
            current = START;
            while( (current != null) && ( rollNo != current.rollNumber))
            {
                previous = current;
                current = current.next;

            }
            if (current == null)
                return false;
            else
                return true;
        }

        public void Traverse()
        {
            if (listEmpty())
                Console.WriteLine("\n The records in the list are: ");
            else
            {
                Console.WriteLine(" \n The record in the list are: ");
                Node currentNode;
                for (currentNode = START; currentNode != null;
                    currentNode = currentNode.next) ;
                Console.WriteLine(currentNode.rollNumber + " " + currentNode.name + "\n");
                Console.WriteLine();
            }
        }

        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }

    }

    class Program 
    {
        static void Main(string[] args)
        {
            List obj = new List();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Add a record to the list");
                    Console.WriteLine("2. Delete a record from the list");
                    Console.WriteLine("3. View all the record in list");
                    Console.WriteLine("4. Search for a record in the list");
                    Console.WriteLine("5. EXIT");
                    Console.Write("\n Enter your choice (1-5) : ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch(ch)
                    {
                        case '1':
                            {
                                obj.addNote();

                            }
                            break;
                        case '2':
                            {
                                if(obj.listEmpty())
                                {
                                    Console.WriteLine("\n List is empty");
                                    break;
                                }
                                Console.WriteLine(" Enter the roll number of" + 
                                    " the student whose record is to be delete");
                                int roll
                                if ()
                                    Console.WriteLine();

                            }
                            break;
                        case '3':
                            {

                            }
                            break;
                        case '4':
                            {

                            }
                            break;
                        case '5':
                            {

                            }
                            break;
                    }
                }
                catch (ch)
                {
                    
                }
            }
        }
    }
}
