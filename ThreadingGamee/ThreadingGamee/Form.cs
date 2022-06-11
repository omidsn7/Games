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

namespace ThreadingGamee
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        Thread th;
        Thread th1;
        Random rdm;
        private void btn_red_Click(object sender, EventArgs e)
        {
            th = new Thread(RedThread);
            th.Start();
        }

        private void RedThread()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(50);
            }
            MessageBox.Show("Red Is Complete");
        }
        private void BlueThread()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(50);
            }
            MessageBox.Show("Blue Is Complete");
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            th1 = new Thread(BlueThread);
            th1.Start();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            rdm = new Random();
        }
    }
}
