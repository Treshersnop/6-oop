using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _6_op
{
    class MyStorage
    {
        int size;
        Shape[] storage;
        public MyStorage()
        {
            size = 0;
        }
        public void setObject(int i, Shape obj)
        {
            storage[i] = obj;
        }
        public void addObject(Shape obj)
        {
            Array.Resize(ref storage, size + 1);
            storage[size] = obj;
            size = size + 1;
        }
        public bool isCheckedStorage(MouseEventArgs e)//проверяет нажато ли на какой-либо круг
        {
            for (int i = 0; i < size; i++)
                if (storage[i].isClicked(e) == true)
                    return true;
            return false;
        }
        public void MakeCheckedObjectStorage(MouseEventArgs e)//делает объект выделенным, если на него нажато
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].isClicked(e) == true)
                {
                    storage[i].MakeClickTrue();
                    i = size;
                }
            }
        }
        private void removeObject(int i)//удаление объекта
        {
            if (size > 1 && i < size)
            {
                Shape[] storage2 = new Shape[size - 1];
                for (int j = 0; j < i; j++)
                    storage2[j] = storage[j];
                storage[i] = null;
                for (int j = i; j < size - 1; j++)
                    storage2[j] = storage[j + 1];
                size = size - 1;
                storage = storage2;
            }
            else
            {
                size = 0;
                storage[size] = null;
            }
        }
        public void removeCheckedObject()//удаление выделенных объектов
        {
            for (int i = 0; i < size; i++)
            {
                if (storage[i].IsClick() == true)
                {
                    removeObject(i);
                    i = i - 1;
                }
            }
        }
        public void AllNotChecked()
        {
            for (int i = 0; i < size; i++)
                storage[i].MakeClickFalse();
        }
        public void DrawAll(PictureBox pb, Graphics g, Bitmap bmp)
        {
            for (int i = 0; i < size; i++)
                storage[i].Draw(pb, g, bmp);
        }
        public void Move(KeyEventArgs e)
        {
            for (int i = 0; i < size; i++)
                if (storage[i].IsClick() == true)
                    storage[i].Move(e);
        }
        public void Resize(KeyEventArgs e)
        {
            for (int i = 0; i < size; i++)
                if (storage[i].IsClick() == true)
                    storage[i].Resize(e);
        }
        public void ColorChange(Color color)
        {
            for (int i = 0; i < size; i++)
                if (storage[i].IsClick() == true)
                    storage[i].ColorChange(color);
        }
        public int getSize()
        {
            return size;
        }
    }
}
