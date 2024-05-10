using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() {1, 10, -30, 10, -5};
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(10);
            intStack.Push(-30);
            intStack.Push(10);
            intStack.Push(-5);
            Queue<int> intQ = new Queue<int>();
            intQ.Enqueue(1);
            intQ.Enqueue(10);
            intQ.Enqueue(-30);
            intQ.Enqueue(10);
            intQ.Enqueue(-5);
            HashSet<int> intHSet = new HashSet<int>() {1, 10, -30, 10, -5};

            List<IEnumerable<int>> iterables = new List<IEnumerable<int>> {intList, intStack, intQ, intHSet}; 

            foreach (var iterable in iterables)
            {
                Console.Write(iterable.GetType().Name.Split('`')[0] + ": ");
                foreach (var item in iterable)
                {
                    //TODO: get rid of last comma
                    Console.Write(item + ", ");
                }
                Console.Write("\n");
            }
        }
    }
}