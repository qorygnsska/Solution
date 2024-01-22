using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Picture1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1, y1, x2, y2;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X; 
            y2 = e.Y;  

            Graphics g = CreateGraphics(); //그래픽 생성 메서드, 자료형 : Graphics(델리게이트), 변수 : g(대리자), 델리게이트 : 메소드를 참조하는 변수
            Pen pen = new Pen(Color.Blue, 10); //색과 포인트
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

    }
}
