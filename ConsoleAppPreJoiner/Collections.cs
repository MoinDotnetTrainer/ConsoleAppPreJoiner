using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleAppPreJoiner
{
    public class Students
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    internal class Collections
    {
        public void List()
        {
            List<int> list = new List<int>();
            list.Add(24);
            list.Add(45);
            list.Add(67);
            list.Add(346);
            list.Add(67);
            list.Add(7567);
            list.Add(586);
            list.Add(24);
            list.Add(45);
            list.Add(67);
            list.Add(346);
            list.Add(67);
            list.Add(7567);
            list.Add(586);

            list.Remove(45);
            list.RemoveAt(4);
            list.Insert(0, 100);

            //collections , which looping statement should i use
            // for while dowhile , foreach

            foreach (var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine(item);
            }
        }
        public void Hashset()
        {
            Console.WriteLine("hashset");
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(145);
            numbers.Add(23);
            numbers.Add(1536);
            numbers.Add(145);
            numbers.Add(2456);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(145);
            numbers.Add(23);
            numbers.Add(1536);
            numbers.Add(1);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


        }
        public void sortedset()
        {
            Console.WriteLine("sortedset");
            SortedSet<int> numbers = new SortedSet<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(145);
            numbers.Add(23);
            numbers.Add(1536);
            numbers.Add(145);
            numbers.Add(2456);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(145);
            numbers.Add(23);
            numbers.Add(1536);
            numbers.Add(1);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        public void ListExample()
        {
            List<Students> std = new List<Students> {
            new Students{ ID=1,Name="xyz",Address="Hyd"},
            new Students{ ID=2,Name="Test",Address="Hyd"},
            new Students{ ID=3,Name="Sam",Address="Hyd"},
            new Students{ ID=4,Name="Abc",Address="Hyd"},
            new Students{ ID=5,Name="Abhi",Address="Hyd"}
            };

            foreach (var item in std)
            {
                Console.WriteLine($"Std is {item.ID} and Name {item.Name} and Add {item.Address}");
            }
        }

        public void Queuq()
        {
            Queue<string> orders = new Queue<string>();
            orders.Enqueue("Order1");
            orders.Enqueue("Order2");
            orders.Dequeue();

            foreach (var item in orders)
            {
                Console.WriteLine(item);
            }
        }

        public void Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(45);
            stack.Push(36);
            stack.Push(67);
            stack.Push(4558);
            stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public void NonGeneric() {
            ArrayList obj = new ArrayList();
            obj.Add(45);
            obj.Add("45");
            obj.Add(true);
            obj.Add(234.43);
            obj.Add(435);
            obj.Add(4567);
            obj.Add(47);
            obj.Add(4675);
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }
    }
}
