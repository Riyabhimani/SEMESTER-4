using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Program-1
            //1.Create an ArrayList for StudentName and perform following operations: 
            //a.Add() - To Add new student in list
            //b.Remove() - To Remove Student with specified index
            //c.RemoveRange() - To Remove student with specified range.
            //d.Clear() - To clear all the student from the list

            //ArrayList studentName = new ArrayList();

            // Add()
            //studentName.Add("abc");
            //studentName.Add("def");
            //studentName.Add("ghi");
            //studentName.Add("jkl");
            //studentName.Add("mno");

            //foreach (object student in studentName)
            //{
            //    Console.WriteLine(student);
            //}

            // Remove()
            //studentName.Remove("ghi");
            //foreach (object student in studentName)
            //{
            //    Console.WriteLine(student);
            //}

            // RemoveRange()
            //studentName.RemoveRange(0, 2);
            //foreach (object student in studentName)
            //{
            //    Console.WriteLine(student);
            //}

            // Clear()
            //studentName.Clear();

            // Program-2
            //2.Create a List for StudentName and perform following operations: 
            //a.Add() - To Add new student in list
            //b.Remove() - To Remove Student with specified index
            //c.RemoveRange() - To Remove student with specified range.
            //d.Clear() - To clear all the student from the list

            //List<string> list = new List<string>();

            //// Add()
            //Console.WriteLine("Add applied !");
            //list.Add("abc");
            //list.Add("pqr");
            //list.Add("lmn");
            //list.Add("stu");
            //list.Add("xyz");

            //foreach (object student in list)
            //{
            //    Console.WriteLine(student);
            //}

            //// remove()
            //Console.WriteLine("Remove applied !");
            //list.Remove("xyz");
            //foreach (object student in list)
            //{
            //    Console.WriteLine(student);
            //}

            //// RemoveRange()
            //Console.WriteLine("RemoveRange applied !");
            //list.RemoveRange(1, 3);
            //foreach (object student in list)
            //{
            //    Console.WriteLine(student);
            //}

            //// Clear()
            //Console.WriteLine("Clear applied !");
            //list.Clear();
            //foreach (object student in list)
            //{
            //    Console.WriteLine(student);
            //}

            // Program-3
            //3.Create a Stack which takes integer values and perform following operations: 
            //a.Push() - To Add new item in stack
            //b.Pop() - To Remove item from the stack
            //c.Peek() – To Return the top item from the stack. 
            //d.Contains() - To Checks whether an item exists in the stack or not. 
            //e.Clear() - To clear items from stack

            //Stack <int> integers = new Stack<int>();

            //// Push()
            //Console.WriteLine("Push Applied !");
            //integers.Push(1);
            //integers.Push(2);
            //integers.Push(3);
            //integers.Push(4);
            //integers.Push(5);

            //foreach (object integer in integers)
            //{
            //    Console.WriteLine(integer);
            //}

            //// Pop()
            //Console.WriteLine("Pop Applied !");
            //integers.Pop();

            //foreach (object integer in integers)
            //{
            //    Console.WriteLine(integer);
            //}

            //// Peek()
            //Console.WriteLine("Peek Applied !");
            //int peek = integers.Peek();
            //Console.WriteLine("Top item from the stack = " + peek);

            //// Contains()
            //Console.WriteLine("Contains applied !");
            //bool a =  integers.Contains(1);
            //bool b = integers.Contains(0);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //// Clear()
            //Console.WriteLine("Clear applied !");
            //integers.Clear();

            // Program-4
            //4.Create a Queue which takes integer values and perform following operations:  
            //a.Enqueue() - Adds an item into the queue.
            //b.Dequeue() - Returns an item from the beginning of the queue and
            //                          removes it from the queue. 
            //c.Peek() - Returns an first item from the queue without removing it.
            //d.Contains() - Checks whether an item is in the queue or not
            //e.Clear() - Removes all the items from the queue

            //Queue<int> queue = new Queue<int>();

            //// Enqueuq()
            //Console.WriteLine("Enqueue Applied !");
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //foreach (object queueitem in queue)
            //{
            //    Console.WriteLine(queueitem);
            //}

            //// Dequeue()
            //Console.WriteLine("Dequeue Applied !");
            //queue.Dequeue();

            //foreach (object queueitem in queue)
            //{
            //    Console.WriteLine(queueitem);
            //}

            //// Peek()
            //Console.WriteLine("Peek Applied !");
            //int a = queue.Peek();
            //Console.WriteLine(a);

            //// Contains()
            //Console.WriteLine("Contains applied !");
            //bool b = queue.Contains(3);
            //bool c = queue.Contains(0);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //// Clear()
            //Console.WriteLine("Clear applied !");
            //queue.Clear();

            // Program-5
            //5.Create a Dictionary collection class object and preform following operations: 
            //a.Add: Adds a key-value pair.
            //b.Remove: Removes a key-value pair by key. 
            //c.ContainsKey: Checks if a key exists in the hashtable. 
            //d.ContainsValue: Checks if a value exists in the hashtable. 
            //e.Clear: Removes all key-value pairs. 

            //Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();

            //// Add()
            //Console.WriteLine("Add Applied !");

            //keyValuePairs.Add("Name", "Abc");
            //keyValuePairs.Add("RollNo", 101);
            //keyValuePairs.Add("EnrollmentNo", 102);
            //keyValuePairs.Add("Email", "gwfgd@gmail.com");

            //foreach (KeyValuePair<string,object> key in keyValuePairs)
            //{
            //    Console.WriteLine(key.Key+" : "+key.Value);
            //}

            //// Remove()
            //Console.WriteLine("Remove Applied !");

            //keyValuePairs.Remove("Email");

            //foreach (KeyValuePair<string, object> key in keyValuePairs)
            //{
            //    Console.WriteLine(key.Key + " : " + key.Value);
            //}

            //// ContainsKey()
            //Console.WriteLine("ContainsKey Applied !");

            //bool keys = keyValuePairs.ContainsKey("EnrollmentNo");
            //Console.WriteLine(keys);

            //// ContainsValue()
            //Console.WriteLine("ContainsValue Applied !");

            //bool values = keyValuePairs.ContainsValue("Abc");
            //Console.WriteLine(values);

            //// Clear()
            //Console.WriteLine("Clear Applied !");
            //keyValuePairs.Clear();

            //Program-6
            //6.Create a Hashtable collection class object and preform following operations: 
            //a.Add: Adds a key-value pair.
            //b.Remove: Removes a key-value pair by key. 
            //c.ContainsKey: Checks if a key exists in the hashtable. 
            //d.ContainsValue: Checks if a value exists in the hashtable. 
            //e.Clear: Removes all key-value pairs. 

            Hashtable ht = new Hashtable();

            // Add()
            Console.WriteLine("Add Applied !");

            ht.Add("Name","Xyz");
            ht.Add("RollNo","101");
            ht.Add("EnrollmentNo", "23010101010");
            ht.Add("Email", "nwgd@gmail.com");

            foreach (DictionaryEntry obj in ht)
            {
                Console.WriteLine($"{obj.Key}:{obj.Value}");
            }

            //Remove()
            Console.WriteLine("Remove Applied !");

            ht.Remove("Email");
            foreach (DictionaryEntry obj in ht)
            {
                Console.WriteLine($"{obj.Key}:{obj.Value}");
            }

            // ContainsKey()
            Console.WriteLine("ContainsKey Applied !");

            bool keys = ht.ContainsKey("Name");
            Console.WriteLine(keys);

            //ContainsValues()
            Console.WriteLine("ContainsValue Applied !");

            bool values = ht.ContainsValue("102");
            Console.WriteLine(values);

            // Clear()
            Console.WriteLine("Clear Applied !");
            ht.Clear();
        }
}
}
