using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21JulyDoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node first = new Node            
            {
                data = 12,
                next = null,
                prev = null,
            };
            linkedList.head = first;
            Node second = new Node
            {
                data = 20,
                next = null,
            };
            first.next = second;
            second.prev = first;
            Node third = new Node
            {
                data = 30,
                next = null
            };
            second.next = third;
            third.prev = second;
            linkedList.PrintLList();
            Console.ReadKey();
        }
    }
}
