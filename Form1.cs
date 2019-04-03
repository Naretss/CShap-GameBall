using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_tool.Visible = true;
        }
        int speed = 9;
        int vdir = +1;
        int slider_speed = 10;
        int score = 0;
        private void vert_Tick_1(object sender, EventArgs e)
        {
            //Console.WriteLine(ball.Top); ยิ่งตำแหน่งลงยิ่งมีค่ามาก ยิ่งสูงหรือชิดขอบมากๆ เกินขอบ จะติดลบ
            if (ball.Top < 0)
            {
                vdir = +1;
                /*
                Console.WriteLine("if ball.Top < 0)");
                Console.WriteLine("if "+ball.Top+" < 0");
                */
            }
            else if(ball.Top>(this.Height-ball.Height-slider.Height))
            {
                if (ball.Left < slider.Left || ((ball.Left + ball.Width) > (slider.Left + slider.Width))) //END GAME
                {
                    vert.Enabled = horz.Enabled = false;
                    panel1.Visible = true;
                    panel1.BackColor = Color.Red;
                    label2.Text = "GAME OVER";
                    label_sum.Text = "SCORE : "+score;
                    score = 0;
                    label_score.Text = "score : " + score;
                    label_score.Visible = false;
                }
                else
                {
                    label_score.Visible = true;
                    score++;
                    speed+=2; //เร่งความเร็วหากยังรับได้ 
                    label_score.Text = "score : " + score;
                    if (score > 4)
                    {
                        label_tool.Visible = false;
                    }

                }


                      vdir = -1;
            }
            ball.Top += (vdir*speed);
        }

        int hdir = +1;
        private void horz_Tick(object sender, EventArgs e)
        {
            if (ball.Top < 0)
            {
                hdir = +1;
            }
            else if (ball.Left > (this.Width - ball.Width))
            {
                hdir = -1;
            }
            ball.Left += (hdir * speed);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool _left = false, _right = false; //เลือนช้าย เลื่อนขวา
        bool game_over = false;
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                _right = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                _left = true;
            }
            else if (e.KeyCode == Keys.Escape) // กดปุ่ม esc จะหยุด
            {
                vert.Enabled = horz.Enabled = pause = false;
                panel1.BackColor = Color.Green;
                label2.Text = "GAME Pause";
            }
            else if (e.KeyCode == Keys.Enter) // กดปุ่ม enter จะเริ่มต่อ
            {
                if (!game_over)
                {

                }
                vert.Enabled = horz.Enabled = pause = true;
            }
        }

        bool pause
        {
            get
            {
                return !panel1.Visible;
            }
            set
            {
                panel1.Visible = !value;
            }
        }
    
        private void key_watch_Tick(object sender, EventArgs e)
        {
             if(_right && slider.Left<(this.Width - slider.Width))
            {
                slider.Left =slider.Left + 10;
            }
            else if (_left && slider.Left>0)
            {
                slider.Left = slider.Left - 10;
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left || e.KeyCode == Keys.Right)
            {
                _right = _left = false;
            }
        }
    }
}
