using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{

    class LinearQueue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;

        public LinearQueue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                //Console.WriteLine("Queue is Empty");
                //throw new System.ArgumentException("Parameter cannot be null", "rear");
                System.Windows.Forms.MessageBox.Show("Queue is Full");

            }
            else
            {
                ele[++rear] = item;
            }
        }

        public int Dequeue()
        {
            if (front == rear + 1)
            {
                //Console.WriteLine("Queue is Empty");
                System.Windows.Forms.MessageBox.Show("Queue is Empty");
                return 0;

            }
            else
            {
                
                return ele[front++];
            }
        }

        internal int[] GetContent()
        {
            return ele;
        }

       
    }

}

