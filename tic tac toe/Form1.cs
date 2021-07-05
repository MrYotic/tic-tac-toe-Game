using System;
using System.Drawing;
using System.Windows.Forms;
namespace tic_tac_toe{
    public partial class Form1 : Form{
        public Form1() { InitializeComponent(); }    
        bool state = true;
        bool[,] states = new bool[9, 2];
        private void ClickPanel(object sender, EventArgs e){
            if (states[((PictureBox)sender).TabIndex - 1000, 0] == false){
                states[((PictureBox)sender).TabIndex - 1000 , 0] = true;
                states[((PictureBox)sender).TabIndex - 1000 , 1] = state;
                if (state) DraweXtic(((PictureBox)sender).TabIndex - 1000, (Bitmap)_pic[((PictureBox)sender).TabIndex - 1000].Image);
                else _pic[((PictureBox)sender).TabIndex - 1000].CreateGraphics().DrawEllipse(new Pen(Brushes.Silver, 1), 10, 10, 80, 80);
                if (int.Parse(label2.Text[label2.Text.IndexOf("x: ") + 3].ToString()) > 8 || int.Parse(label2.Text[label2.Text.IndexOf("o: ") + 3].ToString()) > 8) this.Close();
                for (int i = 0; i < new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }.Length / 3; i++)
                    if (states[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 0], 0] && states[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 0], 1] == state && states[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 1], 0] && states[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 1], 1] == state && states[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 2], 0] && states[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 2], 1] == state){
                        label2.Text = state == true ? "Счёт: x: " + (int.Parse(label2.Text[label2.Text.IndexOf("x: ") + 3].ToString()) + 1) + " / o: " + label2.Text[label2.Text.IndexOf("o: ") + 3] : "Счёт: x: " + label2.Text[label2.Text.IndexOf("x: ") + 3] + " / o: " + (int.Parse(label2.Text[label2.Text.IndexOf("o: ") + 3].ToString()) + 1);
                        states = new bool[9, 2];
                        for (int o = 0; o < _pic.Length; o++) _pic[o].Image = new Bitmap(100, 100);}
                state = !state;
                label1.Text = state == true ? "Сейчас ходит: Крестик" : "Сейчас ходит: Нолик";}}
        private void DraweXtic(int i, Bitmap bitmap){
            for (int x = 0; x < bitmap.Width - 20 ; x++){
                bitmap.SetPixel(bitmap.Width - 10 - x, bitmap.Height - 10 - x, Color.Silver);
                bitmap.SetPixel( x + 10, bitmap.Width - x - 10, Color.Silver);}
            _pic[i].Image = bitmap;}}}