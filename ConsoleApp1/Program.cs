using System.Collections;
using System.Diagnostics;

namespace ListArrayListLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListArrayListLinkedList();
        }

        public static void ListArrayListLinkedList()
        {
            List<int> list = new List<int>();
            ArrayList arrays = new ArrayList();
            LinkedList<int> linledLists = new LinkedList<int>();
            AllActions allActions = new();

            Console.WriteLine("\n-------Added-------\n");
            list = allActions.AddedRandomValues(list);
            arrays = allActions.AddedRandomValues(arrays);
            linledLists = allActions.AddedRandomValues(linledLists);

            Console.WriteLine("\n-------GetElement-------\n");
            allActions.GetElementWithIndex496753(list);
            allActions.GetElementWithIndex496753(arrays);
            allActions.GetElementWithIndex496753(linledLists);

            Console.WriteLine("\n-------DividedBy777-------\n");
            allActions.DividedBy777(list);
            allActions.DividedBy777(arrays);
            allActions.DividedBy777(linledLists);
        }
    }
}
