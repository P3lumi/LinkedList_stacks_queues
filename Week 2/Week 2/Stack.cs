using System;
using System.Collections.Generic;
using System.Text;

namespace Week_2
{
    public class Pstack <T>
    {
        private Node<T> pel;
        private int size;
        public Pstack()
        {
            this.pel = null;
            this.size = 0;
        } 

        //..is empty
        public bool IsEmpty()
        {
            return this.size == 0;
        }

        //..Add item 
        public void Push(T item)
        {
            Node<T> _item = new Node<T>(item);  
            _item.Next = this.pel;
            this.pel = _item;
            this.size++;
        }

        // ...returns size
        public int Size()
        {
            return this.size;
        }

        //peek the head
        public T Peek()
        {
            if (this.size != 0)
            {
                
                return this.pel.Data;
            }
            else
            {
                throw new Exception("can't peek an empty stack");
            }
        }
        
        //popping an item

        public T Pop()
        {
            if (this.size != 0)
            {
                Node<T> oldPel = this.pel;
                this.pel = this.pel.Next;
                size--;
                return oldPel.Data;
            }
            else
            {
                throw new Exception("Can't Pop an empty Stack");
            }
        }

        //Display Method;
        public void Display()
        {
            Node<T> counter = this.pel;
            while (counter != null)
            {
                Console.WriteLine(counter.Data);
                counter = counter.Next;
            }
        }
    }
}
