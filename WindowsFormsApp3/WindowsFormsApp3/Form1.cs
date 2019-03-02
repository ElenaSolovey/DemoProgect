using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;

       private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player%2 == 0)
            {
                button.Text = "X";
                player++;
                turns++;
            }
            else
            {
                button.Text = "O";
                player++;
                turns++;
            }
            if( CheckDraw() == true)
            {
                MessageBox.Show("Tie Game!");
                NewGame();
             }
            if(CheckWinner() == true)
            {
                if(button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show("O Won!");
                    s2++;
                    NewGame();
                }
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            {
                label1.Text = "X: " + s1;
                label2.Text = "O: " + s2;

            }

        }

        bool CheckDraw()
        {
            if (turns == 9)
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {//горизонтальные линии
            if ((button1.Text == button6.Text) && (button6.Text == button9.Text) && (button1.Text != ""))
                return true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (button2.Text != ""))
                return true;
            else if ((button3.Text == button4.Text) && (button4.Text == button7.Text) && (button3.Text != ""))
                return true;
            // вертикальные
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button1.Text != ""))
                return true;
            else if ((button6.Text == button5.Text) && (button5.Text == button4.Text) && (button6.Text != ""))
                return true;
            else if ((button9.Text == button8.Text) && (button8.Text == button7.Text) && (button9.Text != ""))
                return true;
            //диагональные
            if ((button1.Text == button5.Text) && (button5.Text == button7.Text) && (button1.Text != ""))
                return true;
            else if ((button9.Text == button5.Text) && (button5.Text == button3.Text) && (button9.Text != ""))
                return true;
            else
                return false;
        }

        
        public void NewGame()
        {
            player = 2;
            turns = 0;
            button1.Text = button6.Text = button9.Text = button2.Text = button5.Text = button8.Text = button3.Text = button4.Text = button7.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игроки по очереди ставят на свободные клетки поля 3х3 знаки (один всегда крестики, другой всегда нолики). Первый, выстроивший в ряд 3 своих фигуры по вертикали, горизонтали или диагонали, выигрывает. Первый ход делает игрок, ставящий крестики", "Help");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
