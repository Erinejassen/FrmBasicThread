using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delthread = new ThreadStart(MyThreadClass.Thread1);

            Thread threadA = new Thread(delthread);
            threadA.Name = "Thread A";
            Thread threadB = new Thread(delthread);
            threadB.Name = "Thread B";

            Console.WriteLine(label1.Text.ToString());
            threadB.Start();
            threadA.Start();

            threadA.Join();
            threadB.Join();

            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}
