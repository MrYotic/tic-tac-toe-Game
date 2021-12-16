namespace a{
    public partial class aa : System.Windows.Forms.Form{
        public aa() { InitializeComponent(); }
        bool[,] aaa = new bool[9, 2], a1 = new bool[1, 1]{new bool[1]{true}};
        private void aa1(object a1a, System.EventArgs e){
            if (aaa[((System.Windows.Forms.PictureBox)a1a).TabIndex - 1000, 0] == false){
                aaa[((System.Windows.Forms.PictureBox)a1a).TabIndex - 1000 , 0] = true;
                aaa[((System.Windows.Forms.PictureBox)a1a).TabIndex - 1000 , 1] = a1[0,0];
                if (a1[0,0]) a11a[((System.Windows.Forms.PictureBox)a1a).TabIndex - 1000].Image = a111(((System.Windows.Forms.PictureBox)a1a).TabIndex - 1000, (System.Drawing.Bitmap)a11a[((System.Windows.Forms.PictureBox)a1a).TabIndex - 1000].Image);
                else a11a[((System.Windows.Forms.PictureBox)a1a).TabIndex - 1000].CreateGraphics().DrawEllipse(new System.Drawing.Pen(System.Drawing.Brushes.Silver, 1), 10, 10, 80, 80);
                if (int.Parse(a11.Text[a11.Text.IndexOf("x: ") + 3].ToString()) > 8 || int.Parse(a11.Text[a11.Text.IndexOf("o: ") + 3].ToString()) > 8) this.Close();
                for (int i = 0; i < new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }.Length / 3; i++)
                    if (aaa[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 0], 0] && aaa[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 0], 1] == a1 && aaa[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 1], 0] && aaa[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 1], 1] == a1 && aaa[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 2], 0] && aaa[new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 6, 4, 2 } }[i, 2], 1] == a1[0,0]){
                        a11.Text = a1[0,0] == true ? "Счёт: x: " + (int.Parse(a11.Text[a11.Text.IndexOf("x: ") + 3].ToString()) + 1) + " / o: " + a11.Text[a11.Text.IndexOf("o: ") + 3] : "Счёт: x: " + a11.Text[a11.Text.IndexOf("x: ") + 3] + " / o: " + (int.Parse(a11.Text[a11.Text.IndexOf("o: ") + 3].ToString()) + 1);
                        aaa = new bool[9, 2];
                        for (int o = 0; o < a11a.Length; o++) a11a[o].Image = new System.Drawing.Bitmap(100, 100);}
                a1[0,0] = !a1[0,0];
                aaaa.Text = a1[0,0] == true ? "Сейчас ходит: Крестик" : "Сейчас ходит: Нолик";}}
        private Bitmap a111(int i, System.Drawing.Bitmap a1aa){
            for (int x = 0; x < a1aa.Width - 20 ; x++){
                a1aa.SetPixel(a1aa.Width - 10 - x, a1aa.Height - 10 - x, System.Drawing.Color.Silver);
                a1aa.SetPixel( x + 10, a1aa.Width - x - 10, System.Drawing.Color.Silver);}
             }return a1aa;}}
