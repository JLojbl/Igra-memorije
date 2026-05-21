using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn[0] = button2;
            btn[1] = button3;
            btn[2] = button4;
            btn[3] = button5;
            btn[4] = button6;
            btn[5] = button7;
            btn[6] = button8;
            btn[7] = button9;
            btn[8] = button10;
            btn[9] = button11;
            btn[10] = button12;
            btn[11] = button13;

        }
       // int i = 0;
        int b1 = -1;
        int b2 = -1;
        int[,] m = new int[4,3];
       // int[] n ={1,2,1,5,6,6,3,4,3,5,4,2};
       // bool[] n1 = { false, false, false, false, false, false, false, false, false, false, false, false };
        Button[] btn = new Button[12];
        private void obrisi(Button button)
        {
            button.Image = null;
        }
        private bool ostavi(Button button, Button button1)
        {
            if (button.Image==button1.Image)
	        {
                return true;
	        }
            return false;
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (b1 != b2)
            {
                obrisi(btn[b1]);
                obrisi(btn[b2]);
            }
            else
                obrisi(button2);
            b1 = -1;
            b2 = -1;
            timer2.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b1 == -1) b1 = 0;
            else b2 = 0;
            
            button2.Image = Image.FromFile("s1.png", true);
            timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (b1 == -1) b1 = 1;
            else b2 = 1;
            button3.Image=Image.FromFile("s2.png", true);
            timer2.Start();
        }
        private void button4_Click(object sender, EventArgs e)
        {
             if (b1 == -1) b1 = 2;
            else b2 = 2;
            button4.Image = Image.FromFile("s1.png", true);
            timer2.Start();
        }
        private void button5_Click(object sender, EventArgs e)
        {
             if (b1 == -1) b1 = 3;
            else b2 = 3;
            button5.Image = Image.FromFile("s5.png", true);
            timer2.Start();
        }
        private void button6_Click(object sender, EventArgs e)
        { 
            if (b1 == -1) b1 = 4;
            else b2 = 4;
            button6.Image = Image.FromFile("s6.png", true);
            timer2.Start();
        }
        private void button7_Click(object sender, EventArgs e)
        {
             if (b1 == -1) b1 = 5;
            else b2 = 5;
            button7.Image = Image.FromFile("s6.png", true);
            timer2.Start();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (b1 == -1) b1 = 6;
            else b2 = 6;
            button8.Image = Image.FromFile("s3.png", true);
            timer2.Start();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (b1 == -1) b1 = 7;
            else b2 = 7;
            button9.Image = Image.FromFile("s4.png", true);
            timer2.Start();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (b1 == -1) b1 = 8;
            else b2 = 8;
            button10.Image = Image.FromFile("s3.png", true);
            timer2.Start();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (b1 == -1) b1 = 9;
            else b2 = 9;
            button11.Image = Image.FromFile("s5.png", true);
            timer2.Start();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (b1 == -1) b1 = 10;
            else b2 = 10;
            button12.Image = Image.FromFile("s4.png", true);
            timer2.Start();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (b1 == -1) b1 = 11;
            else b2 = 11;
            button13.Image = Image.FromFile("s2.png", true);
            timer2.Start();
        }
    }
}