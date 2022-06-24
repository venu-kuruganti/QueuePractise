using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePractise
{
    internal class Program
    {
        class QueueItem
        {
            public int value { get; set; }            
            public QueueItem next { get; set; }
        }
        class MyQueue
        {
            public QueueItem Head { get; set; }

            public MyQueue()
            {
                Head = null;//Queue is empty
            }

            public void DisplayQueue()
            {
                if (Head==null)
                {
                    Console.WriteLine("Queue is empty!");
                }
                else
                {
                    Console.Write("\t{0} (First in queue!)", Head.value);

                    QueueItem queueIterator = Head.next;

                    while (queueIterator!=null)
                    {
                        if (queueIterator.next==null)//Back of the queue
                            Console.Write("\t{0} (Back of the queue)", queueIterator.value);
                        else
                            Console.Write("\t{0}",queueIterator.value.ToString());

                        queueIterator = queueIterator.next;
                    }//End of while
                }//End of else


                Console.WriteLine();
                Console.WriteLine();

                Console.ReadKey();

            }//Display stack

            public void Insert(int value)
            {
                QueueItem item = new QueueItem { value = value, next = null };

                if (Head==null)
                    Head = item;
                else
                {
                    //Go to the back of the queue from the front.
                    QueueItem queueIterator = Head;

                    while (queueIterator.next!=null)
                        queueIterator = queueIterator.next;

                    queueIterator.next = item;                    
                }

            }

            public void Remove()
            {
                QueueItem temp = Head.next;
                Head = temp;
            }
        }


        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            queue.DisplayQueue();

            queue.Insert(1);
            queue.DisplayQueue();

            queue.Insert(5);

            queue.Insert(9);

            queue.Insert(10);

            queue.Insert(7);
            queue.DisplayQueue();

            queue.Insert(23);
            queue.DisplayQueue();

            queue.Insert(72);
            queue.DisplayQueue();

            queue.Insert(82);
            queue.DisplayQueue();

            queue.Insert(88);
            queue.DisplayQueue();

            queue.Insert(100);
            queue.DisplayQueue();

            queue.Remove();
            queue.DisplayQueue();

            queue.Remove();
            queue.Remove();
            queue.DisplayQueue();
        }
    }
}
