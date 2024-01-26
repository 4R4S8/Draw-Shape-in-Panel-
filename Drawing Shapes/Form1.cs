using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Drawing_Shapes
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //    ShapeDrawing drawer = new ShapeDrawing();
            //    drawer.DrawTriangle(DrawingPanel, new Point[] { new Point((int)35.689197, (int)51.388974), new Point(100, 20), new Point(400, 300), new Point(300, 350), new Point(100, 380) });
            //35.689197

            //  51.388974
            //drawer.DrawStringRectangleFFormat(e);

        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            if (txtX.Text.Trim().Length > 0 && txtY.Text.Trim().Length > 0)
            {
                btnAddCodrd.Enabled = true;
            }
            else
            {
                btnAddCodrd.Enabled = false;
            }
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {
            if (txtX.Text.Trim().Length > 0 && txtY.Text.Trim().Length > 0)
            {
                btnAddCodrd.Enabled = true;
            }
            else
            {
                btnAddCodrd.Enabled = false;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (lstbxCordinations.Items.Count >= 3)
            {
                DrawingPanel.Refresh();
                List<int[]> Cordinations = new List<int[]>();
                string cordination;
                string[] points;

                for (int i = 0; i < lstbxCordinations.Items.Count; i++)
                {
                    cordination = lstbxCordinations.Items[i].ToString();
                    points = cordination.Split(',');
                    Cordinations.Add(new int[] { int.Parse(points[0]), int.Parse(points[1]) });
                }

                ShapeDrawing drawer = new ShapeDrawing();
                drawer.DrawShape(DrawingPanel, Cordinations);
                lstbxCordinations.Items.Clear();
            }
        }

        private void btnAddCodrd_Click(object sender, EventArgs e)
        {
            lstbxCordinations.Items.Add($"{txtX.Text} , {txtY.Text}");
            txtX.ResetText();
            txtY.ResetText();
        }
        private void btnEditCodrd_Click(object sender, EventArgs e)
        {

            string cord = lstbxCordinations.SelectedItem.ToString();
            string[] points = cord.Split(',');
            txtX.Text = points[0];
            txtY.Text = points[1];
            lstbxCordinations.Items.RemoveAt(lstbxCordinations.SelectedIndex);
        }
    }
    public class ShapeDrawing
    {
        public void DrawShape(Panel panel, List<int[]> Points/*, PaintEventArgs e*/)
        {
            Graphics graphics = panel.CreateGraphics();

            Point[] trianglePoints = new Point[Points.Count];
            for (int i = 0; i < Points.Count; i++)
            {
                trianglePoints[i] = new Point(Points[i][0], Points[i][1]);
            }
            // Set drawing properties
            Pen pen = new Pen(Color.DarkGreen, 3);
            Brush brush = new SolidBrush(Color.LightGreen);

            // Construct GraphicsPath object
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(trianglePoints);

            // Draw the triangle
            graphics.FillPath(brush, path);
            graphics.DrawPath(pen, path);

            // Write point values
            //Font font = new Font("Consolas", 10);
            //SolidBrush drawBrush = new SolidBrush(Color.Black);
            //foreach (Point point in trianglePoints)
            //{
            //    string text = $"{point.X},{point.Y}";

            //    // Draw the point values
            //    e.Graphics.DrawString(text, font, drawBrush, point.X + 2, point.Y + 10);
            //}

            graphics.Dispose();
        }
        public void DrawStringRectangleFFormat(PaintEventArgs e)
        {

            // Create string to draw.
            String drawString = "Sample Text";

            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            float x = 150.0F;
            float y = 150.0F;
            float width = 200.0F;
            float height = 50.0F;
            RectangleF drawRect = new RectangleF(x, y, width, height);

            // Draw rectangle to screen.
            Pen blackPen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;

            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
        }
    }

}
