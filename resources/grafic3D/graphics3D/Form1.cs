using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        myGraphics T;
        private void Form1_Load(object sender, EventArgs e)
        {
            T = new myGraphics();
            T.InitGraph(pictureBox1);


            /*View Demo = new PointsCollection();
            (Demo as PointsCollection).Add(new Point3D(3, 1, 1));
            (Demo as PointsCollection).Add(new Point3D(1, 1, 5));
            Demo.setCameraPosition(new Point3D(0, -1, 9));
            Demo.setCameraRotation(0.3f, 0.5f, 0.1f);
            Demo.setCanvas(400, 400, 100);
            Demo.Draw(T, Color.Red);*/



            /*View Demo2 = new Function();
            Demo2.setCameraPosition(new Point3D(1, -40, 7));
            Demo2.setCameraRotation(1.4f, 3.14f, 3.14f);
            Demo2.setCanvas(pictureBox1.Width/2, pictureBox1.Height/2, 1500);
            Demo2.Draw(T, Color.Black);*/


            View Demo3 = new ChaoticMap();
            Demo3.setCameraPosition(new Point3D(0, 0, -80));
            Demo3.setCameraRotation(0f, 0f, 0.8f);
            Demo3.setCanvas(pictureBox1.Width / 2, pictureBox1.Height / 2, 1000);
            Demo3.Draw(T, Color.Black);


            T.RefreshGraph();

        }
    }
}
