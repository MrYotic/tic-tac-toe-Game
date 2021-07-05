using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace a
{
    partial class aa
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void Controls_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                ((Control)sender).Capture = false;
                var m = Message.Create(Handle, 0xa1, new IntPtr(0x2), IntPtr.Zero);
                WndProc(ref m);
            }
        }

        public void panels_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, a11a[((PictureBox)sender).TabIndex - 1000].ClientRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        public void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aaaa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.a11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.a11);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.aaaa);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 424);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(46, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 300);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.aaaa.AutoSize = true;
            this.aaaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aaaa.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aaaa.ForeColor = System.Drawing.Color.Silver;
            this.aaaa.Location = new System.Drawing.Point(41, 13);
            this.aaaa.Name = "label1";
            this.aaaa.Size = new System.Drawing.Size(235, 26);
            this.aaaa.TabIndex = 0;
            this.aaaa.Text = "Сейчас ходит:  Крестик";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(373, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.a11.AutoSize = true;
            this.a11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a11.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a11.ForeColor = System.Drawing.Color.Silver;
            this.a11.Location = new System.Drawing.Point(41, 372);
            this.a11.Name = "label2";
            this.a11.Size = new System.Drawing.Size(148, 26);
            this.a11.TabIndex = 2;
            this.a11.Text = "Счёт: x: 0 / o: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.MouseDown += Controls_MouseDown;
            //
            //_pic
            //
            for (int i = 0; i < a11a.Length; i++)
            {
                a11a[i] = new PictureBox();
                a11a[i].BackColor = Color.White;
                a11a[i].Size = new Size(100, 100);
                a11a[i].Location = new Point(i / 3 * 100, i % 3 * 100);
                a11a[i].TabIndex = 1000 + i;
                a11a[i].Image = new Bitmap(100, 100);
                a11a[i].Paint += panels_Paint;
                a11a[i].Click += aa1;
            }
            panel2.Controls.AddRange(a11a);
        }

        #endregion

        private PictureBox[] a11a = new PictureBox[9];
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label aaaa;
        private System.Windows.Forms.Label a11;
    }
}

