using System;
using System.Drawing;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Xml.Resolvers;
using static System.Net.Mime.MediaTypeNames;

namespace lab2
{
    public partial class MainForm : Form
    {
        public Color bkgrnd;
        public int yn, xn, yk, xk, xc, yc, r;

        Color currentBorderColor = Color.Black;

       //Point startPoint; // Переменная для хранения начальной точки многоугольника
        Bitmap bmp; // Переменная для хранения изображения
        Color fillColor; // Переменная для хранения цвета заливки
        Graphics g; // Объявление переменной g
        Point startPoint = new Point(100, 100);
        public MainForm()


        {
            InitializeComponent(); 
        }




        //  окружность 

        private void DrawCircle(int xc, int yc, int r)
        {
            int x = 0;
            int y = r;
            int d = 1 - r;

            DrawCirclePoints(xc, yc, x, y);

            while (y > x)
            {
                if (d < 0)
                {
                    d = d + 2 * x + 3;
                    x++;
                }
                else
                {
                    d = d + 2 * (x - y) + 5;
                    x++;
                    y--;
                }
                DrawCirclePoints(xc, yc, x, y);
            }
        }
        //

        //многоугольник 

        private void FillPolygon(Point startPoint, Bitmap bmp, Color targetColor, Color fillColor)
        {
            if (startPoint.X < 0 || startPoint.X >= bmp.Width || startPoint.Y < 0 || startPoint.Y >= bmp.Height)
                return;

            if (bmp.GetPixel(startPoint.X, startPoint.Y) != targetColor)
                return;

            bmp.SetPixel(startPoint.X, startPoint.Y, fillColor);

            FillPolygon(new Point(startPoint.X + 1, startPoint.Y), bmp, targetColor, fillColor);
            FillPolygon(new Point(startPoint.X - 1, startPoint.Y), bmp, targetColor, fillColor);
            FillPolygon(new Point(startPoint.X, startPoint.Y + 1), bmp, targetColor, fillColor);
            FillPolygon(new Point(startPoint.X, startPoint.Y - 1), bmp, targetColor, fillColor);
        }
        //



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (CDA_radio.Checked)
            {
                yn = e.Y;
                xn = e.X;

            }

            if (CDA_THICC_button.Checked)
            {
                yn = e.Y;
                xn = e.X;
            }

            if (Fill_radio.Checked)
            {

                bmp = pictureBox1.Image as Bitmap;
                yn = e.Y;
                xn = e.X;
                FloodFill(xn, yn);
                pictureBox1.Image = bmp;
                pictureBox1.Refresh();

            }

            if (buttonFill.Checked)
            {
                yn = e.Y;
                xn = e.X;
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {


            if (CDA_radio.Checked)
            {
                int index, nodesNumber;
                double NextX, NextY, dx, dy;
                Pen new_Pen = new Pen(currentBorderColor, 1);
                Graphics drawer = Graphics.FromHwnd(pictureBox1.Handle);

                xk = e.X;
                yk = e.Y;
                dx = xk - xn;
                dy = yk - yn;
                nodesNumber = 200;
                NextX = xn;
                NextY = yn;
                for (int i = 1; i < nodesNumber; i++)
                {
                    Bitmap_pixel_set((int)NextX, (int)NextY, 2);
                    NextX = NextX + dx / nodesNumber;
                    NextY = NextY + dy / nodesNumber;
                }
                pictureBox1.Image = bmp;
                pictureBox1.Refresh();
            }
            if (CDA_THICC_button.Checked)
            {
                int index, nodesNumber;
                double NextX, NextY, dx, dy;
                Pen new_Pen = new Pen(currentBorderColor, 1);
                Graphics drawer = Graphics.FromHwnd(pictureBox1.Handle);

                xk = e.X;
                yk = e.Y;
                dx = xk - xn;
                dy = yk - yn;
                nodesNumber = 200;
                NextX = xn;
                NextY = yn;
                for (int i = 1; i < nodesNumber; i++)
                {
                    Bitmap_pixel_set((int)NextX, (int)NextY, 3);
                    NextX = NextX + dx / nodesNumber;
                    NextY = NextY + dy / nodesNumber;
                }
                pictureBox1.Image = bmp;
                pictureBox1.Refresh();
            }
            if (buttonFill.Checked)
            {
                FillPolygon(startPoint, bmp, bmp.GetPixel(startPoint.X, startPoint.Y), currentBorderColor);
                pictureBox1.Image = bmp;
            }
        }

        // окружность 
        private void DrawCirclePoints(int xc, int yc, int x, int y)
        {
            Bitmap_pixel_set(xc + x, yc + y, 1);
            Bitmap_pixel_set(xc - x, yc + y, 1);
            Bitmap_pixel_set(xc + x, yc - y, 1);
            Bitmap_pixel_set(xc - x, yc - y, 1);
            Bitmap_pixel_set(xc + y, yc + x, 1);
            Bitmap_pixel_set(xc - y, yc + x, 1);
            Bitmap_pixel_set(xc + y, yc - x, 1);
            Bitmap_pixel_set(xc - y, yc - x, 1);
        }
        //






        private void Bitmap_pixel_set(int x, int y, int range)
        {
            for (int i = 0; i < range; i++)
            {
                bmp.SetPixel(x + i, y, currentBorderColor);
                bmp.SetPixel(x + i, y + i, currentBorderColor);
                bmp.SetPixel(x + i, y - i, currentBorderColor);
                bmp.SetPixel(x - i, y + i, currentBorderColor);
                bmp.SetPixel(x - i, y - i, currentBorderColor);
                bmp.SetPixel(x - i, y, currentBorderColor);
                bmp.SetPixel(x, y + i, currentBorderColor);
                bmp.SetPixel(x, y - i, currentBorderColor);

            }

        }
        private void Clear_button_Click(object sender, EventArgs e)
        {



            Color newPixelColor = bkgrnd;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    bmp.SetPixel(x, y, newPixelColor);
                }
            }
            pictureBox1.Image = bmp;
        }


        private void color_button_Click(object sender, EventArgs e)
        {
            DialogResult diadresult = colorDialog1.ShowDialog();
            if (diadresult == DialogResult.OK && CDA_radio.Checked)
            {
                currentBorderColor = colorDialog1.Color;
            }
        }
        private void CDA(int StartX, int StartY, int EndX, int EndY)
        {
            int index, numberNodes;
            double xOutput, yOutput, dx, dy;

            xn = StartX;
            yn = StartY;
            xk = EndX;
            yk = EndY;
            dx = xk - xn;
            dy = yk - yn;
            numberNodes = 200;
            xOutput = xn;
            yOutput = yn;
            for (index = 1; index <= numberNodes; index++)
            {
                bmp.SetPixel((int)xOutput, (int)yOutput,
               currentBorderColor);
                xOutput = xOutput + dx / numberNodes;
                yOutput = yOutput + dy / numberNodes;
            }
        }

        private void use_button_Click(object sender, EventArgs e)
        {
            use_button.Enabled = false;
            Clear_button.Enabled = false;

            using (Graphics g = Graphics.FromHwnd(pictureBox1.Handle))
            {
                if (CDA_radio.Checked)
                {
                    CDA(10, 10, 10, 110);
                    CDA(10, 10, 110, 10);
                    CDA(10, 110, 110, 110);
                    CDA(110, 10, 110, 110);
                    //рисуем треугольник
                    CDA(150, 10, 150, 200);
                    CDA(250, 50, 150, 200);
                    CDA(150, 10, 250, 150);
                }

                else if (radioButton1.Checked)
                {
                    // Здесь вызываем функцию для рисования окружности по алгоритму Брезенхема
                    DrawCircle(200, 200, 100);
                }

                else
                {
                    if (Fill_radio.Checked)
                    {
                        bmp = pictureBox1.Image as Bitmap;
                        xn = 160;
                        yn = 40;
                        FloodFill((int)xn, (int)yn);
                    }
                }
                pictureBox1.Image = bmp;
                pictureBox1.Refresh();
                use_button.Enabled = true;
                Clear_button.Enabled = true;
            }
        }
        private void FloodFill(int x1, int y1)
        {
            Color oldPixelColor = bmp.GetPixel(x1, y1);
            if ((oldPixelColor.ToArgb() != currentBorderColor.ToArgb()) && (oldPixelColor.ToArgb() != fillColor.ToArgb()) && ((x1 + 2) < bmp.Width) && ((x1) < bmp.Width) && ((y1) < bmp.Height) && ((y1) < bmp.Height) && (x1 > 0) && (y1 > 0))
            {
                bmp.SetPixel(x1, y1, fillColor);
                FloodFill(x1 + 1, y1);
                FloodFill(x1 - 1, y1);
                FloodFill(x1, y1 + 1);
                FloodFill(x1, y1 - 1);
            }
            else
            {
                return;
            }

        }




        private void MainForm_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width + 1, pictureBox1.Height + 1);
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
            bkgrnd = bmp.GetPixel(0, 0);

        }

        private void fill_color_button_Click(object sender, EventArgs e)
        {
            DialogResult diadresult = colorDialog1.ShowDialog();
            if (diadresult == DialogResult.OK)
            {
                fillColor = colorDialog1.Color;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                use_button_Click(sender, e); // Обновляем изображение при выборе алгоритма Брезенхема
            }
        }


        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

        }



        private void buttonFill_Click(object sender, EventArgs e)
        {
            //FillPolygon(startPoint, bmp, bmp.GetPixel(startPoint.X, startPoint.Y), fillColor);
            //pictureBox1.Image = bmp;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);

            // Рисуем многоугольник как пример
            Point[] points = { new Point(50, 50), new Point(100, 75), new Point(150, 50), new Point(100, 150) };
            g.FillPolygon(Brushes.Black, points);

            pictureBox1.Image = bmp;
        }
    }
}

    