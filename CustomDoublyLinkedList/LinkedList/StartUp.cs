﻿using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();

            //for (int i = 1; i <= 3; i++)
            //{
            //    doublyLinkedList.AddLast(i);
            //}

            //for (int i = 1; i <= 4; i++)
            //{
            //    doublyLinkedList.RemoveLast();
            //}

            DoublyLinkedList<string> doublyLinkedList = new DoublyLinkedList<string>();

            for (int i = 1; i <= 10; i++)
            {
                doublyLinkedList.AddFirst("Pesho" + i);
            }

            for (int i = 1; i <= 10; i++)
            {
                doublyLinkedList.AddLast("Pesho" + i);
            }

            doublyLinkedList.ForEach(n=>Console.Write(n + " "));

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                doublyLinkedList.RemoveFirst();
            }

            doublyLinkedList.ForEach(n=>Console.Write(n + " "));
            Console.WriteLine();

            Console.WriteLine(doublyLinkedList[0]);

            string[] arr = doublyLinkedList.ToArray();

            foreach (var element in doublyLinkedList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
