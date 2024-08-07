using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task1
{
    internal class Program
    {
        Stacklist stacklist;
        static void Main(string[] args)
        {
            new Program();
            
        }
        public Program()
        {
            stacklist=new Stacklist();
            ReadFiles();
            stacklist.WriteOutput();
            WriteLine("the output is written in output.txt.");
        }
        public void ReadFiles()
        {
            StreamReader sr = new StreamReader("TestInputs.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                stacklist.push(line);
            }

        }
    }
    class Stacklist
    {
        private int count = 0;
        private Node listHead;
        
        public Stacklist()
        {
            listHead = null;
        }
        /// <summary>
        /// removing elements from the linked list 
        /// </summary>
        public string pop()
        {
            string top = " ";
            if (listHead == null)
            {
                Write("the stack is empty");
            }
            
            else
            {
                //update the head pointer
                listHead=listHead.Next;
                 top = listHead.name;
            }
            return top;
        }
        /// <summary>
        /// adding elements into the list 
        /// </summary>
        public void push(string name)
        {
            //Creates a new Node and assigns it as the new head of the list
            Node newNode=new Node(name);
            if(listHead == null)
            {
                listHead = newNode;
                
            }
            else
            {
                newNode.Next= listHead;
                listHead= newNode;
            }
        }
        /// <summary>
        /// view the tail 
        /// </summary>
        public string  peek()
        {
            return listHead.name;
        }
        public void WriteOutput()
        {
            StreamWriter wr = new StreamWriter("Output.txt");
            Node temp = listHead;
            while (temp != null) 
            { 
                wr.WriteLine(temp.name);
                temp= temp.Next;
            }
            wr.Close();
        }

    }
    class Node
    {
        public Node Next;
        public string name;
       

        public Node(string name)
        {
            this.Next = null;
            this.name = name;
            
        }
        public string Name()
        {
            return name;
        }
    }

}
