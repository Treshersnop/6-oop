using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _6_op
{
    class Shape
    {
        protected bool isClick = false;
        protected int x;
        protected int y;
        protected int radius;
        protected Pen pen;
        protected SolidBrush brush = new SolidBrush(Color.White);

        public void MakeClickTrue()//выделить
        {
            isClick = true;
        }
        public void MakeClickFalse()//антивыделение
        {
            isClick = false;
        }

        virtual public void Draw(PictureBox pb, Graphics g, Bitmap bmp)//метод, рисующий фигуры 
        {
            if (isClick == true)
                pen = new Pen(Color.Red, 2);
            else
                pen = new Pen(Color.Black);
        }
        protected void CheckBoard(PictureBox pb, Graphics g, Bitmap bmp)
        {
            if ((x + radius / 2) > pb.Width)//проверяет на границы по ширине
                x = pb.Width - (radius / 2);
            else if ((x - radius / 2) < 0)
                x = radius / 2;
            if ((y + radius / 2) > pb.Height)//проверка на границы по высоте
                y = pb.Height - (radius / 2);
            else if ((y - radius / 2 - 85) < 0)
                y = 85 + radius / 2;
            if (radius > pb.Width)//проверка на радиус, больше он формы или нет
                radius = pb.Width;
            if (radius > pb.Height - 85)
                radius = pb.Height - 85;
        }
        virtual public bool isClicked(MouseEventArgs e)//нажато ли в область фигуры
        {
            return false;
        }

        virtual public void Move(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                y = y - 5;
            else if (e.KeyCode == Keys.S)
                y = y + 5;
            else if (e.KeyCode == Keys.A)
                x = x - 5;
            else if (e.KeyCode == Keys.D)
                x = x + 5;
        }
        virtual public void Resize(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
                radius += 5;
            else if (e.KeyCode == Keys.Subtract && radius > 5)
                radius -= 5;
        }
        virtual public void ColorChange(Color color)
        {
            brush.Color = color;
        }

        public bool IsClick()//возвращает нажато ли на фигуру
        {
            return isClick;
        }
    }

    class Circle : Shape
    {
        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            isClick = true;
        }

        public override void Draw(PictureBox pb, Graphics g, Bitmap bmp)//метод, который рисует круг 
        {
            Rectangle r=new Rectangle((x - (radius / 2)), (y - (radius / 2)), radius, radius);
            base.Draw(pb, g, bmp);
            CheckBoard(pb, g, bmp);
            g.FillEllipse(brush, r);
            g.DrawEllipse(pen, r);
            pb.Image = bmp;
        }
        public override bool isClicked(MouseEventArgs e)//нажато ли в область круга
        {
            if (((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y)) <= radius * radius)
                return true;
            else
                return false;
        }
        /*public override void Resize(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
                radius += 5;
            else if (e.KeyCode == Keys.Subtract && radius > 5)
                radius -= 5;
        }*/
    }
    class Square : Shape
    {
        public Square(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            isClick = true;
        }
        public override void Draw(PictureBox pb, Graphics g, Bitmap bmp)//метод, который рисует квадрат 
        {
            Rectangle r = new Rectangle((x - (radius / 2)), (y - (radius / 2)), radius, radius);
            base.Draw(pb, g, bmp);
            CheckBoard(pb, g, bmp);
            g.FillRectangle(brush, r);
            g.DrawRectangle(pen, r);
            pb.Image = bmp;
        }
        public override bool isClicked(MouseEventArgs e)//нажато ли в область квадрата
        {
            if (e.X < x + radius && e.X > x - radius && e.Y < y + radius && e.Y > y - radius)
                return true;
            else
                return false;
        }
    }
    class Triangle: Shape
    {
        private Point[] points;
        public Triangle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            isClick = true;
            points = new Point[3];
        }
        public override void Draw(PictureBox pb, Graphics g, Bitmap bmp)
        {
            points[0].X = x; points[0].Y = y - radius/2;
            points[1].X = x - radius / 2; points[1].Y = y + radius/2;
            points[2].X = x + radius / 2; points[2].Y = y + radius/2;
            base.Draw(pb, g, bmp);
            CheckBoard(pb, g, bmp);
            g.FillPolygon(brush, points);           
            g.DrawPolygon(pen, points);
            pb.Image = bmp;
        }
        public override bool isClicked(MouseEventArgs e)
        {
            if (e.X < x + radius && e.X > x - radius && e.Y < y + radius && e.Y > y - radius)
                return true;
            else
                return false;
        }
    }
    class Line:Shape
    {
        public Line(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            isClick = true;
        }
        public override void Draw(PictureBox pb, Graphics g, Bitmap bmp)
        {
            base.Draw(pb, g, bmp);
            CheckBoard(pb, g, bmp);
            g.DrawLine(pen, x + radius / 2, y + radius / 2, x - radius / 2, y - radius / 2);
            pb.Image = bmp;
        }
        public override bool isClicked(MouseEventArgs e)
        {
            if (((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y)) <= radius/4 * radius/4)
                return true;
            else
                return false;
        }
    }
}
