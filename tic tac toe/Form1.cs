using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Controls_MouseDown;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DrawingPanelBoxes();
            variotes = new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8}, { 0, 3, 6}, { 1, 4, 7}, { 2, 5, 8}, {0, 4, 8 }, { 6, 4, 2} };
        }
        PictureBox[] _pic = new PictureBox[9];
        private void DrawingPanelBoxes()
        {
            for (int i = 0; i < _pic.Length; i++)
            {
                _pic[i] = new PictureBox();
                _pic[i].BackColor = Color.White;
                _pic[i].Size = new Size(100, 100);
                _pic[i].Location = new Point( i / 3 * 100, i % 3 * 100);
                _pic[i].TabIndex = 1000 + i;
                _pic[i].Paint += panels_Paint;
                _pic[i].Click += ClickPanel;
            }
            panel2.Controls.AddRange(_pic);
        }

        bool state = true; //true - X ; false - О
        bool[,] states = new bool[9, 2];// занято / не занято || крестик / нолик
        private void ClickPanel(object sender, EventArgs e)
        {
            if (!states[((PictureBox)sender).TabIndex - 1000, 0])
            {
                states[((PictureBox)sender).TabIndex - 1000, 0] = true;
                states[((PictureBox)sender).TabIndex - 1000 , 1] = state;
                if (state)
                    DraweXtic(((PictureBox)sender).TabIndex - 1000);
                else
                    _pic[((PictureBox)sender).TabIndex - 1000].CreateGraphics().DrawEllipse(new Pen(Brushes.Silver, 3), 10, 10, 80, 80);
                CheckWin(state);
                state = !state;
                label1.Text = state == true ? "Сейчас ходит: Крестик" : "Сейчас ходит: Нолик";
            }
            else
                return;
        }
        int[,] variotes = new int[8, 3];
        private void CheckWin(bool state2)
        {
            if (int.Parse(label2.Text[label2.Text.IndexOf("x: ") + 3].ToString()) > 8 || int.Parse(label2.Text[label2.Text.IndexOf("o: ") + 3].ToString()) > 8)
                Process.GetCurrentProcess().Kill();

            for (int i = 0; i < variotes.Length / 3; i++)
                if (states[variotes[i, 0], 0] && states[variotes[i, 0], 1] == state2 && states[variotes[i, 1], 0] && states[variotes[i, 1], 1] == state2 && states[variotes[i, 2], 0] && states[variotes[i, 2], 1] == state2)
                {
                    label2.Text = state2 == true ? "Счёт: x: " + (int.Parse(label2.Text[label2.Text.IndexOf("x: ") + 3].ToString())+1) + " / o: " + label2.Text[label2.Text.IndexOf("o: ") + 3] : "Счёт: x: " + label2.Text[label2.Text.IndexOf("x: ") + 3] + " / o: " + (int.Parse(label2.Text[label2.Text.IndexOf("o: ") + 3].ToString()) + 1);
                    states = new bool[9,2];
                    for (int o = 0; o < _pic.Length; o++)
                        _pic[o].Image = new Bitmap(100, 100);
                }  
        }
        private void DraweXtic(int i)
        {            
            Bitmap bitmap = new Bitmap(100, 100);
            for (int x = 10; x < bitmap.Width - 10 ; x++)
                for (int y = 0; y < 3; y++)
                {
                    bitmap.SetPixel(x + y, x, Color.Silver);
                    bitmap.SetPixel(x + y, bitmap.Width  - x, Color.Silver);
                }
            _pic[i].Image = bitmap;
        }
    }
}