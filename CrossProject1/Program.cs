using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Стек очереди

    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Push("Valera");
            queue.Push("Tolya");
            queue.Push("Steve");
            WriteLine($"Следующий идет : {queue.Pop()}");
        }
    }
    class Queue
    {
        string[] queue = new string[10];
        int start = 0;
        int end = 0;
        public void Push(string name) // 1-й атрибут доступа, 2-й тип возвращемого объекта, 3-й имя метода, 4-й параметры
        {
            queue[end] = name;
            end++;
        }
        public string Pop() 
        {
            // Pop();
            string name = queue[start];
            queue[start] = null;
            start++;
            return name;
        }
    }
}