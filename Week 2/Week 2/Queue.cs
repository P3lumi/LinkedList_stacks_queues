using System;
using System.Collections.Generic;
using System.Text;

namespace Week_2
{
    class Pqueue <T>
    {
        private Node<T> lum;
        private int size;

        public Pqueue()
        {
            this.lum = null;
            this.size = 0;
        }


        //..is empty
        public bool IsEmpty()
        {
            return this.size == 0;
        }

        //Method to enqueue item to the tail of the link and return the size
        public void Enqueue(T x)
        {
            Node<T> newnode = new Node<T>(x);

            if (this.size == 0)
            {
                this.lum = newnode;
            }
            else
            {
                Node<T> presentNode = this.lum;
                for (int i = 0; i < this.size; i++)
                {
                    if (presentNode.Next == null)
                    {
                        presentNode.Next = newnode;
                    }
                    else
                    {
                        presentNode = presentNode.Next;
                    }
                }
            }

            this.size++;

        }

        //Dequeue

        public T Dequeue()
        {
            if (this.size != 0)
            {
                Node<T> oldlum = this.lum;
                this.lum = this.lum.Next;
                size--;
                return oldlum.Data;
            }
            else
            {
                throw new Exception("Can't dequeue an empty queue");
            }
        }


        // ...returns size
        public int Size()
        {
            return this.size;
        }


        //Display Method;
        public void Display()
        {
            Node<T> counter = this.lum;
            while (counter != null)
            {
                Console.WriteLine(counter.Data);
                counter = counter.Next;
            }
        }



    }
    
    

}

