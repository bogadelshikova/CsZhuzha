using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {

    public int x1 = 250;   //topleft to topright
    public int y1 = 250;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      x1 = rnd.Next(0, 500); ;   //topleft to topright
      y1 = rnd.Next(0, 500); ;
    }
    public Bitmap DrawLuch(Bitmap MyImage, Pen blackPen)
    {

      Random rnd = new Random();
      // Create coordinates of points that define line.


      // Draw line to screen.
      using (var graphics = Graphics.FromImage(MyImage))
      {
        for (int i = 0; i < 20; i++)
        {
          int x2 = rnd.Next(0, 500);
          int y2 = rnd.Next(0, 500);

          graphics.DrawLine(blackPen, x1, y1, x2, y2);
        }
      }
      return MyImage;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      // Stretches the image to fit the pictureBox.
      Bitmap MyImage;
      string fileToDisplay = @"1.jpg";
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

      MyImage = new Bitmap(fileToDisplay);

      // Create pen.
      Pen blackPen = new Pen(Color.MediumVioletRed, 5);
      MyImage = DrawLuch(MyImage, blackPen);

      pictureBox1.ClientSize = new Size(500, 500);
      pictureBox1.Image = (Image)MyImage;
    }
  }
}
