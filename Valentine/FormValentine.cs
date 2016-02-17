using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valentine
{
    public partial class FormValentine : Form
    {
        Heart heart = new Heart();

        public const int HEIGHT = 20;
        public const int WIDTH = 20;
        public const int POINT = 20;

        int[] moveX = {12,13,13,12, 11, 10, 9,  9,  10, 10, 11, 11, 12, 13, 14, 15, 15, 16, 16, 16, 15, 15, 14, 13, 12, 11, 10, 9,  8,  7,  7,  6,  6,  6,  6,  7,  8,  8,  9,  9,  10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 20, 20, 19, 18, 17, 17, 18, 19, 20, 21, 21, 21, 21, 22, 23, 24, 25, 25, 25, 25, 24, 23, 23, 22, 22, 22, 22, 23};                                         
        int[] moveY = {15,14,13,12, 12, 13, 14, 15, 16, 17, 17, 18, 18, 18, 17, 17, 16, 15, 14, 13, 12, 11, 10, 10, 10, 10, 10, 11, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 20, 21, 21, 21, 21, 21, 21, 20, 19, 18, 18, 18, 19, 20, 21, 22, 22, 21, 20, 19, 19, 20, 21, 22, 23, 24, 25, 25, 25, 24, 23, 22, 21, 20, 19, 18, 18, 17, 16, 15, 14};

        int[] heartX = { 24, 24, 24, 24, 24, 23, 22, 21, 21, 20, 19, 18, 17, 17, 16, 15, 14, 14, 13, 12, 11, 11, 10 ,9, 8, 7, 7, 6, 5,  4,  4,  4,  4,  4,  5,  6,  7,  8,  9,  10, 11, 11, 12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 21, 22, 23};
        int[] heartY = { 14, 13, 12, 11, 10, 9,  8,  8,  7,  7,  7,  7,  7,  8,  8,  9,  10, 9,  9,  8,  8,  7,  7,  7,  7, 7, 8, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 19, 19, 20, 20, 21, 21, 22, 21, 20, 20, 19, 19, 19, 18, 17, 16, 15};

        int point = -1;
        int pointH = -1;
        long pulse = 0;

        public FormValentine()
        {
            InitializeComponent();
        }
    
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (point < 54) heart.AddHeartPart();

            if (point < moveX.Count()-1)
            {
                point++;
                heart.Move(moveX[point], moveY[point]);
            }
            else if(pointH < heartX.Count()-1)
            {
                pointH++;
                heart.Move(heartX[pointH], heartY[pointH]);
            }
            else
            {
                MainTimer.Enabled = false;
                LastTimer.Enabled = true;
                lblFinal1.Visible = true;
                lblFinal2.Visible = true;
            }
            MainPanel.Invalidate();
        }
        private void FirstTimer_Tick(object sender, EventArgs e)
        {
            pulse++;
            MainPanel.Invalidate();
        }
        private void LastTimer_Tick(object sender, EventArgs e)
        {
            pulse++;
            MainPanel.Invalidate();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            if (FirstTimer.Enabled)
            {
                if (pulse % 3 != 0)
                {
                    e.Graphics.DrawImage(new Bitmap("hearts2.png"), 110, 210, 120, 120);
                }
                else e.Graphics.DrawImage(new Bitmap("hearts2.png"), 100, 200, 130, 130);
            }
            else if(MainTimer.Enabled)
            {
                heart.Draw(e.Graphics);
            }
            else
            {
                if (pulse % 3 != 0)
                {
                    heart.Draw(e.Graphics);
                }
                else heart.DrawBig(e.Graphics);
            }
            Invalidate();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            lblStart.Visible = false;
            FirstTimer.Enabled = false;
            MainTimer.Enabled = true;
        }

        private void lblStart_MouseHover(object sender, EventArgs e)
        {
            lblStart.Font = new Font("Constantia", 27, FontStyle.Italic);
        }

        private void lblStart_MouseLeave(object sender, EventArgs e)
        {
            lblStart.Font = new Font("Constantia", 28, FontStyle.Italic);
        }
    }
}
