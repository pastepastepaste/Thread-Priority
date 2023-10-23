using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Activity;

namespace Threading_Priority
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Thread ThreadA, ThreadB, ThreadC, ThreadD;

        private void btn_Click_1(object sender, EventArgs e)
        {
            
            ThreadStart Thread = new ThreadStart(MyThreadClass.Thread1);
            ThreadA = new Thread(MyThreadClass.Thread1);

            ThreadB = new Thread(MyThreadClass.Thread2);

            ThreadC = new Thread(MyThreadClass.Thread1);

            ThreadD = new Thread(MyThreadClass.Thread2);


            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;


            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";
            ThreadC.Name = "Thread C";
            ThreadD.Name = "Thread D";
            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();





            label.Text = (" - End of Thread - ");


            Console.WriteLine(label.Text.ToString());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
