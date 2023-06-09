﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MandelbrotSet
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public Fractal fractal;
        public int maxIterations;

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.Initialize(display);
            Engine.Refresh();
            fractal = new Fractal();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.textBox1.Text, out maxIterations))
            {
                maxIterations = 0;
                MessageBox.Show("Please write a number.");
            }
            fractal.maxIterations = maxIterations;
            fractal.Draw();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Engine.Clear();
            fractal.twoD = false;
            fractal.threeD = false;
            fractal.colorful = false;
            fractal.blackWhite = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PNG Image|*.png";
            saveFile.Title = "Save an Image File";
            saveFile.ShowDialog();
            display.Image.Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isColorful = comboBoxColor.SelectedItem.ToString() == "Colorful";
            if (isColorful)
                fractal.colorful = true;
            else
                fractal.blackWhite = true;
        }

        private void comboBoxDimension_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isTwoD = comboBoxDimension.SelectedItem.ToString() == "2D";
            if (isTwoD)
                fractal.twoD = true;
            else
                fractal.threeD = true;

        }

        private void display_MouseDown(object sender, MouseEventArgs e)
        {
            int zoomWidth = pictureBoxZoom.Width / 3;
            int zoomHeight = pictureBoxZoom.Height / 3;
            Bitmap tmpBitmap = new Bitmap(zoomWidth, zoomHeight);

            for (int x = 0; x < zoomWidth; x++)
            {
                for (int y = 0; y < zoomHeight; y++)
                {
                    int sourceX = e.X - zoomWidth / 2 + x;
                    int sourceY = e.Y - zoomHeight / 2 + y;
                    Color pixelColor = Engine.bmp.GetPixel(sourceX, sourceY);
                    tmpBitmap.SetPixel(x, y, pixelColor);
                }
            }
            pictureBoxZoom.Image = tmpBitmap;
        }
    }
}
