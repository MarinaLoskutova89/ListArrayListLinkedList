using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArrayListLinkedList
{
    internal class AllActions
    {
        public List<int> AddedRandomValues(List<int> lists)
        {
            Random rand = new();
            Stopwatch stpwtch = new();

            stpwtch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                lists.Add(rand.Next());
            }
            stpwtch.Stop();
            string? stpElapsed = $"\nTime for list: {stpwtch.Elapsed}\n";
            Console.WriteLine(stpElapsed);
            stpwtch.Restart();

            return lists;
        }

        public ArrayList AddedRandomValues(ArrayList arrList)
        {
            Random rand = new();
            Stopwatch stpwtch = new();

            stpwtch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                arrList.Add(rand.Next());
            }
            stpwtch.Stop();
            string? stpElapsed = $"\nTime for arrayList: {stpwtch.Elapsed}\n";
            Console.WriteLine(stpElapsed);
            stpwtch.Restart();

            return arrList;
        }

        public LinkedList<int> AddedRandomValues(LinkedList<int> linkedList)
        {
            Random rand = new();
            Stopwatch stpwtch = new();

            stpwtch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                linkedList.AddLast(rand.Next());
            }
            stpwtch.Stop();
            string? stpElapsed = $"\nTime for linkedList: {stpwtch.Elapsed}\n";
            Console.WriteLine(stpElapsed);
            stpwtch.Restart();

            return linkedList;
        }

        public void GetElementWithIndex496753(List<int> lists)
        {
            Stopwatch stpwtch = new();

            stpwtch.Start();
            int listValue = lists[496753];
            stpwtch.Stop();
            Console.WriteLine($"listValue: " + listValue);
            string? stpElapsed = $"\nTime for list: {stpwtch.Elapsed}\n";
            Console.WriteLine(stpElapsed);
            stpwtch.Restart();
        }

        public void GetElementWithIndex496753(ArrayList arrList)
        {
            Stopwatch stpwtch = new();

            stpwtch.Start();
            var arrListValue = (int)arrList[496753]!;
            stpwtch.Stop();
            Console.WriteLine($"arrayListValue: " + arrListValue);
            string? stpElapsed = $"\nTime for arrayList: {stpwtch.Elapsed}\n";
            Console.WriteLine(stpElapsed);
            stpwtch.Restart();
        }

        public void GetElementWithIndex496753(LinkedList<int> linkedList)
        {
            Stopwatch stpwtch = new();

            stpwtch.Start();
            int linkedListValue = linkedList.ElementAt(496753);
            stpwtch.Stop();
            Console.WriteLine($"linkedListValue: " + linkedListValue);
            string? stpElapsed = $"\nTime for linkedList: {stpwtch.Elapsed}\n";
            Console.WriteLine(stpElapsed);
            stpwtch.Restart();
        }
        public void DividedBy777(List<int> list)
        {
            Stopwatch stpwtch = new();

            stpwtch.Start();
            foreach (int listValue in list)
            {
                if (listValue % 777 == 0) Console.WriteLine(listValue);
            }
            stpwtch.Stop();
            string? stpElapsed = $"\nTime for list: {stpwtch.Elapsed}\n";
            Console.WriteLine(stpElapsed);
            stpwtch.Restart();
        }
        public void DividedBy777(ArrayList arrList)
        {
            Stopwatch stpwtch = new();

            stpwtch.Start();
            foreach (int arrListValue in arrList)
            {
                if (arrListValue % 777 == 0) Console.WriteLine(arrListValue);
            }
            stpwtch.Stop();
            string? stpElapsed = $"\nTime for arrayList: {stpwtch.Elapsed}\n";
            Console.WriteLine(stpElapsed);
            stpwtch.Restart();
        }
        public void DividedBy777(LinkedList<int> linledList)
        {
            Stopwatch stpwtch = new();

            stpwtch.Start();
            foreach (int linledListValue in linledList)
            {
                if (linledListValue % 777 == 0) Console.WriteLine(linledListValue);
            }
            stpwtch.Stop();
            string? stpElapsed = $"\nTime for linledList: {stpwtch.Elapsed}\n";
            Console.WriteLine(stpElapsed);
            stpwtch.Restart();
        }
    }
}
