using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linkedlistMXH
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Quanly());
        }
        public class Node
        {
            public string Data { get; set; }
            public Node Next { get; set; }

            public Node(string data)
            {
                Data = data;
                Next = null;
            }
        }

        public class LinkedList
        {
            private Node head;

            public void AddPost(string data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }
            public void EditPost(int index, string newData)
            {
                Node current = head;
                int currentIndex = 0;
                while (current != null && currentIndex < index)
                {
                    current = current.Next;
                    currentIndex++;
                }

                if (current != null)
                {
                    current.Data = newData;
                }
            }

            public void DeletePost(int index)
            {
                if (head == null) return;

                if (index == 0)
                {
                    head = head.Next;
                    return;
                }

                Node current = head;
                Node previous = null;
                int currentIndex = 0;

                while (current != null && currentIndex < index)
                {
                    previous = current;
                    current = current.Next;
                    currentIndex++;
                }

                if (current != null)
                {
                    previous.Next = current.Next;
                }
            }

                public IEnumerable<string> GetAllPosts()
            {
                Node current = head;
                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
        }
    }
}
