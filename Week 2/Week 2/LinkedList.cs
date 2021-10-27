using System;
using System.Collections.Generic;
using System.Text;

namespace Week_2
{
    class LinkedList<T>
    {
        private Node<T> pelz;
        private int size;
        public LinkedList()
        {
            this.pelz = null;
            this.size = 0;
        }
        //Method to add item to the tail of the link and return the size
      public int AddItem(T x)
        {
            Node<T> newnode = new Node<T>(x);

            if (this.size == 0)
            {
                this.pelz = newnode;
            }else
            {
                Node<T> presentNode = this.pelz;
                for(int i = 0; i<this.size; i++)
                {
                    if(presentNode.Next== null)
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
            return this.size;
        }

        //Method to delete the first occurence of an item and return true if the item is found
        public bool Delete(T x) {
            Node<T> counter = this.pelz;
            if (counter.Data.ToString() == x.ToString())
            {
                this.pelz = counter.Next;
                this.size--;
                return true;
            }
            else
            {
                for (int i = 0; i < this.size; i++)
                {
                    if (counter.Next.Data.ToString() == x.ToString())
                    {
                        counter.Next = counter.Next.Next;
                        this.size--;
                        return true;
                    }
                    else
                    {
                        counter = counter.Next;
                    }
                }
            }
            this.size--;
            return false;
        }

        //Index that returns the index of an item or -1 if it doesn't exist

        public int Index(T item)
        {
            Node<T> _item = this.pelz;
            for (int i = 0; i < this.size; i++)
            {
                if (_item.Data.Equals(item))
                {
                    return i;       
                }
                _item = _item.Next;
            }
            return -1;
        }
        
        //Checks for a specific item in the list and return a boolean
        public bool Check(T item)
        {
            Node<T> _item = this.pelz;
            for(int i = 0; i<this.size; i++)
            {
                if (_item.Data.Equals(item))
                {
                    return true;
                }
                _item = _item.Next;
            }
            return false;
        }

        //Display Method;
        public void Display()
        {
            Node<T> counter = this.pelz;
            while(counter!=null)
            {
                Console.WriteLine(counter.Data);
                counter = counter.Next;
            }
        }
    }
}
