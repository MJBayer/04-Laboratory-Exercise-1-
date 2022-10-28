using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BasicThreading_Muit
{
    public partial class FrmBasicThread : Form
    {
        private Thread thread1, thread2;
        
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");

            ThreadStart delThreadStart = new ThreadStart(MyThreadClass.Thread1);

            thread1 = new Thread(delThreadStart);
            thread1.Name = "Thread A";

            thread2 = new Thread(delThreadStart);
            thread2.Name = "Thread B";

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("-End of Thread-");
            lblThreads.Text = "-End of Thread-";
        
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {

        }
    }
}
