using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackAndQueue
{


    public partial class Form1 : Form
    {

        private Stack Stk = new Stack(5);
        private LinearQueue LnrQ = new LinearQueue(5);


        public Form1()
        {
            InitializeComponent();
        }

       private void displayStack()
        {
            int[] A = Stk.GetContent();
            txtS1.Text = A[0].ToString();
            txtS2.Text = A[1].ToString();
            txtS3.Text = A[2].ToString();
            txtS4.Text = A[3].ToString();
            txtS5.Text = A[4].ToString();


        }

        private void displayLinearQueue()
        {
            int[] B = LnrQ.GetContent();
            txt6.Text = B[0].ToString();
            txt7.Text = B[1].ToString();
            txt8.Text = B[2].ToString();
            txt9.Text = B[3].ToString();
            txt10.Text = B[4].ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Stk.Push(Int32.Parse(txtNew.Text));
            }
            catch
            {
                MessageBox.Show("queue not entered in correct format.");
            }
            
            displayStack();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNew.Text = Stk.Pop().ToString();
            displayStack();

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                LnrQ.Enqueue(Int32.Parse(txtNew1.Text));
            }
            catch
            {
                MessageBox.Show("queue not entered in correct format.");
            }
            displayLinearQueue();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNew1.Text = LnrQ.Dequeue().ToString();
            displayLinearQueue();
        }
    }
}
