using System.Collections.Generic;
using System.Drawing;

namespace Valentine
{
    class Heart
    {
        List<Point> heartTale = new List<Point>();

        public Heart()
        {
            heartTale.Add(new Point(-30,-30));
        }


        public void AddHeartPart()
        {
            heartTale.Add(new Point(heartTale[heartTale.Count - 1].X, heartTale[heartTale.Count - 1].Y));
        }

        public void Move(int headX, int headY)
        {
            for (int i = heartTale.Count - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    heartTale[i].X = heartTale[i - 1].X;
                    heartTale[i].Y = heartTale[i - 1].Y;
                }
                else
                {
                    heartTale[i].X = headX;
                    heartTale[i].Y = headY;
                }
            }
        }

        public void Draw(Graphics e)
        {
            for (int i = 0; i < heartTale.Count; i++)
            {
                e.FillRectangle(Brushes.HotPink, heartTale[i].X * FormValentine.POINT, heartTale[i].Y * FormValentine.POINT, FormValentine.WIDTH, FormValentine.HEIGHT);
            }
        }

        public void DrawBig(Graphics e)
        {
            for (int i = 0; i < heartTale.Count; i++)
            {
                e.FillRectangle(Brushes.HotPink, (heartTale[i].X * FormValentine.POINT)+2, (heartTale[i].Y * FormValentine.POINT)+2, FormValentine.WIDTH+6, FormValentine.HEIGHT+6);
            }
        }
    }
}
