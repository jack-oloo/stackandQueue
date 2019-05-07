using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Stack
    {
        private int[] arr;

        private int topOfStack;

        public int [] GetContent()
        {
            return arr;
        }

        public Stack(int size)
        {
            arr = new int[size];
            topOfStack = 0;
        }
        public void Push(int value)//inserts an object or value onto the stack
        {
            if (topOfStack > arr.Length - 1)
            {
                Array.Resize(ref arr, topOfStack + 1); //adds an extra slot to the array to fit the new value
                arr[topOfStack] = value;
            }
            else
            {
                arr[topOfStack] = value;
            }
            topOfStack++;
        }
        public int Pop()//removes the object or value at the top of the stack
        {
            int val;
            if (isEmpty())
            {
                System.Windows.Forms.MessageBox.Show("Stack is Empty");
                return 0;
            }
            else
            {
                topOfStack--;
                val = arr[topOfStack];
                return val;
            }
        }
        public bool isEmpty()//to check if the stack is empty
        {
            if (topOfStack >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int Peek()//Peek returns the value that is at the top of the stack
        {
            return arr[topOfStack - 1];
        }
    }
    
}
